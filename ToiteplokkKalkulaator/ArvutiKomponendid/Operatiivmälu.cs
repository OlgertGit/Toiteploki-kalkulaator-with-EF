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
class Operatiivmälu:Komponendid
{

    public override List<ToiteplokkAndmed> AndmedM()
    {
        var _ram = new List<ToiteplokkAndmed>(); // Muutuja, kus andmed on listis.
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var list = _context.RAM.ToList();

            foreach (var a in list)
            {
                var Ram = new ToiteplokkAndmed(); // Klassi kutsumine.
                Ram.Id = a.Id; // Loeb Id veerust.
                Ram.Name = a.Memory; // Loeb CPU veerust.
                Ram.Power = a.Power; // Loeb Power veerust.
                _ram.Add(Ram); // Lisab andmed listi.
            }
            return _ram; // Tagastab muutuja.
        }
    }

    public override List<string> IdM()
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.RAM.Select(a => a.Id.ToString()).ToList();
            return query;
        }
    }

    public override void Kustutamine(string ID)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new RAM { Id = int.Parse(ID) };
            _context.RAM.Attach(query);
            _context.RAM.Remove(query);
            _context.SaveChanges();
        }
    }

    public override void KustutaVeergM(string Nimi)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE RAM DROP COLUMN " + Nimi + "");
        }
    }

    public override void LisaVeergM(string Nimi, string Muutuja)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE RAM ADD " + Nimi + " " + Muutuja + "");
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
                    cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = 'RAM'";
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
            var query = new RAM()
            {
                Memory = Nimetus,
                Power = int.Parse(Voimsus)
            };
            _context.RAM.Add(query);
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
                    cmd.CommandText = "SELECT * FROM RAM";
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
            var query = _context.Database.ExecuteSqlCommand("UPDATE RAM SET " + Veerg + "= '" + Nimetus + "' WHERE Id = " + ID + "");
        }
    }

    public override string ValitudTabel()
    {
        return "Valitud tabel: 'Operatiivmälu'"; // Tagastab teksti.
    }

    public override string VoimsusM()
    {
        return "Võimsus: "; // Tagastab teksti.
    }
}
}
