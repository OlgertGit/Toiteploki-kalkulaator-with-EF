using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ToiteplokkKalkulaator.Models;

namespace ToiteplokkKalkulaator.Klassid
{
class Login:Komponendid // Klass LoginClass.
{
    IMessageService _service = new MessageService();

    public string Access
    {
        get;
        set;
    }

    public void Sisselogimine(string Login, string Password)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var name = _context.Users.FirstOrDefault(u => u.Login == Login);

            if (!string.IsNullOrEmpty(Login) || !string.IsNullOrEmpty(Password))
            {
                if (name != null)
                {
                    string hashedpassword = GenerateSHA256Hash(Password, name.Salt);
                    if (name.Hash == hashedpassword)
                    {
                        AdminForm adminF = new AdminForm(); // Kutsume AdminFormi klassi.
                        adminF.Show(); // Adminformi avamine.
                    }
                    else
                        Access = "Vale parool!";
                }
                else
                {
                    Access = "Sellist kasutajad " + Login + " ei ole olemas!";
                }
            }
            else
            {
                Access = "Sisestage andmed!";
            }
        }
    }

    private string CreateSalt(int size)
    {
        var rng = new RNGCryptoServiceProvider();
        var buffer = new byte[size];
        rng.GetBytes(buffer);
        return Convert.ToBase64String(buffer);
    }

    private string GenerateSHA256Hash(string input, string salt)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
        SHA256Managed sha256hashstring = new SHA256Managed();
        byte[] hash = sha256hashstring.ComputeHash(bytes);

        return ByteArrayToHexString(hash);
    }

    private static string ByteArrayToHexString(byte[] hash)
    {
        StringBuilder hex = new StringBuilder(hash.Length * 2);
        foreach (byte b in hash)
        {
            hex.AppendFormat("{0:x2}", b);
        }
        return hex.ToString();
    }
    public override List<ToiteplokkAndmed> AndmedM()
    {
        throw new NotImplementedException();
    }

    public override List<string> IdM()
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Users.Select(a => a.Id.ToString()).ToList();
            return query;
        }
    }

    public override void Kustutamine(string ID)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new Users { Id = int.Parse(ID) };
            _context.Users.Attach(query);
            _context.Users.Remove(query);
            _context.SaveChanges();
        }
    }

    public override void KustutaVeergM(string Nimi)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE Users DROP COLUMN " + Nimi + "");
        }
    }

    public override void LisaVeergM(string Nimi, string Muutuja)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE Users ADD " + Nimi + " " + Muutuja + "");
        }
    }

    public override List<string> ListVeerudM()
    {
        List<string> _veerudeNimed = new List<string>();
        var _context = new ToiteplokkKalkulaatorDBContext();
        var _connect = _context.Database.Connection;
        var connectionState = _connect.State;
        try
        {
            using (_context)
            {
                if (connectionState != ConnectionState.Open)
                    _connect.Open();
                using (var cmd = _connect.CreateCommand())
                {
                    cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = 'Users'";
                    cmd.CommandType = CommandType.Text;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _veerudeNimed.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            var _service = new MessageService();
            _service.MessageError(ex.Message, "Viga");
        }
        finally
        {
            if (connectionState != ConnectionState.Open)
                _connect.Close();
        }
        return _veerudeNimed;
    }

    public override string NimetusM()
    {
        return "Kasutaja: "; // Tagastab teksti.
    }

    public override void Sisestamine(string Login, string Password)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            Users users = new Users()
            {
                Login = Login
            };
            if (!string.IsNullOrEmpty(Login) || !string.IsNullOrEmpty(Password))
            {
                string _salt = CreateSalt(10);
                users.Salt = _salt;
                users.Hash = GenerateSHA256Hash(Password, _salt);
                try
                {
                    _context.Users.Add(users);
                    _context.SaveChanges();
                    _service.MessageInformation("Registreeritud", "Info");
                }
                catch (Exception ex)
                {
                    _service.MessageError(ex.Message, "Viga");
                }
            }
            else
            {
                _service.MessageExclamation("Sisestage andmed!", "Sõnum");
            }
        }
    }

    public override DataTable TabelM()
    {
        DataTable dt = new DataTable();
        var _context = new ToiteplokkKalkulaatorDBContext();
        var _connect = _context.Database.Connection;
        var connectionState = _connect.State;
        try
        {
            using (_context)
            {
                if (connectionState != ConnectionState.Open)
                    _connect.Open();
                using (var cmd = _connect.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandType = CommandType.Text;
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            var _service = new MessageService();
            _service.MessageError(ex.Message, "Viga");
        }
        finally
        {
            if (connectionState != ConnectionState.Open)
                _connect.Close();
        }
        return dt;
    }

    public override void Uuendamine(string Veerg, string ID, string Nimetus)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("UPDATE Users SET " + Veerg + "= '" + Nimetus + "' WHERE Id = " + ID + "");
        }
    }

    public override string ValitudTabel()
    {
        return "Valitud tabel: 'Kasutajad'"; // Tagastab teksti.
    }

    public override string VoimsusM()
    {
        return "Parool: "; // Tagastab teksti.
    }
}
}
