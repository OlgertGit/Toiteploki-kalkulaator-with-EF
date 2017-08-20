using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToiteplokkKalkulaator.Models;

namespace ToiteplokkKalkulaator.Klassid
{
class OptilineSeade:Komponendid
{
    public override List<ToiteplokkAndmed> AndmedM()
    {
        var _optical = new List<ToiteplokkAndmed>(); // Muutuja, kus andmed on listis.
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var list = _context.Optical.ToList();

            foreach (var a in list)
            {
                var Optical = new ToiteplokkAndmed(); // Klassi kutsumine.
                Optical.Id = a.Id; // Loeb Id veerust.
                Optical.Name = a.OpticalDrive; // Loeb CPU veerust.
                Optical.Power = a.Power; // Loeb Power veerust.
                _optical.Add(Optical); // Lisab andmed listi.
            }
            return _optical; // Tagastab muutuja.
        }
    }

    public override List<string> IdM()
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Optical.Select(a => a.Id.ToString()).ToList();
            return query;
        }
    }

    public override void Kustutamine(string ID)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new Optical { Id = int.Parse(ID) };
            _context.Optical.Attach(query);
            _context.Optical.Remove(query);
            _context.SaveChanges();
        }
    }

    public override void KustutaVeergM(string Nimi)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE Optical DROP COLUMN " + Nimi + "");
        }
    }

    public override void LisaVeergM(string Nimi, string Muutuja)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE Optical ADD " + Nimi + " " + Muutuja + "");
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
                    cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = 'Optical'";
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
        return "Nimetus: "; // Tagastab teksti.
    }

    public override void Sisestamine(string Nimetus, string Voimsus)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new Optical()
            {
                OpticalDrive = Nimetus,
                Power = int.Parse(Voimsus)
            };
            _context.Optical.Add(query);
            _context.SaveChanges();
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
                    cmd.CommandText = "SELECT * FROM Optical";
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
            var query = _context.Database.ExecuteSqlCommand("UPDATE Optical SET " + Veerg + "= '" + Nimetus + "' WHERE Id = " + ID + "");
        }
    }

    public override string ValitudTabel()
    {
        return "Valitud tabel: 'Optiline seade'"; // Tagastab teksti.
    }

    public override string VoimsusM()
    {
        return "Võimsus: "; // Tagastab teksti.
    }
}
}
