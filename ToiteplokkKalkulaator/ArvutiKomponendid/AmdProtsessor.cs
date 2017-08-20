using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ToiteplokkKalkulaator.Models;


namespace ToiteplokkKalkulaator.Klassid
{
class AmdProtsessor:Komponendid
{
    public override List<ToiteplokkAndmed> AndmedM() // Meetod "List<ToiteplokkAndmed>"
    {
        var _amd = new List<ToiteplokkAndmed>(); // Muutuja, kus andmed on listis.
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var list = _context.AMD.ToList();

            foreach (var a in list)
            {
                var Amd = new ToiteplokkAndmed(); // Klassi kutsumine.
                Amd.Id = a.Id; // Loeb Id veerust.
                Amd.Name = a.CPU; // Loeb CPU veerust.
                Amd.Power = a.Power; // Loeb Power veerust.
                _amd.Add(Amd); // Lisab andmed listi.
            }
            return _amd; // Tagastab muutuja.
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
                    cmd.CommandText = "SELECT * FROM AMD";
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
            _service.MessageError(ex.Message,"Viga");
        }
        finally
        {
            if (connectionState != ConnectionState.Open)
                _connect.Close();
        }
        return dt;
    }

    public override void LisaVeergM(string Nimi, string Muutuja) // Meetod "AmdLisaVeergO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE AMD ADD " + Nimi + " " + Muutuja + "");
        }
    }

    public override void KustutaVeergM(string Nimi) // Meetod "AmdKustutaVeergO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE AMD DROP COLUMN " + Nimi + "");
        }
    }

    public override List<string> ListVeerudM() // Meetod "AmdVeerudO"
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
                    cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = 'AMD'";
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

    public override List<string> IdM() // Meetod "AmdIDO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.AMD.Select(a => a.Id.ToString()).ToList();
            return query;
        }
    }


    public override void Uuendamine(string Veerg, string ID, string Nimetus) // Meetod "AmdMuutmineO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("UPDATE AMD SET " + Veerg + "= '" + Nimetus + "' WHERE Id = " + ID + "");
        }
    }

    public override void Sisestamine(string Nimetus, string Voimsus) // Meetod "AmdTabelInsertO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new AMD()
            {
                CPU = Nimetus,
                Power = int.Parse(Voimsus)
            };
            _context.AMD.Add(query);
            _context.SaveChanges();
        }
    }

    public override void Kustutamine(string ID)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new AMD { Id = int.Parse(ID) };
            _context.AMD.Attach(query);
            _context.AMD.Remove(query);
            _context.SaveChanges();
        }
    }

    public override string ValitudTabel() // Meetod "AmdValitudTabelO()"
    {
        return "Valitud tabel: 'AMD Protsessor'"; // Tagastab teksti.
    }

    public override string NimetusM() // Meetod "AmdNimetusO()"
    {
        return "Nimetus: "; // Tagastab teksti.
    }

    public override string VoimsusM() // Meetod "AmdVoimsusO()"
    {
        return "Võimsus: "; // Tagastab teksti.
    }
}
}
