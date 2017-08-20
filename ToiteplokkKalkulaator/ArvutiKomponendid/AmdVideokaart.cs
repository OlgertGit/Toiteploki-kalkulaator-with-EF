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
class AmdVideokaart:Komponendid
{
    public override List<ToiteplokkAndmed> AndmedM() // Meetod "List<ToiteplokkAndmed"
    {
        var _amdGpu = new List<ToiteplokkAndmed>(); // Muutuja, kus andmed on listis.
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var list = _context.AMD_GPU.ToList();

            foreach (var a in list)
            {
                var AmdGpu = new ToiteplokkAndmed(); // Klassi kutsumine.
                AmdGpu.Id = a.Id; // Loeb Id veerust.
                AmdGpu.Name = a.GPU; // Loeb CPU veerust.
                AmdGpu.Power = a.Power; // Loeb Power veerust.
                _amdGpu.Add(AmdGpu); // Lisab andmed listi.
            }
            return _amdGpu; // Tagastab muutuja.
        }
    }

    public override DataTable TabelM() // Meetod "DataTable"
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
                    cmd.CommandText = "SELECT * FROM AMD_GPU";
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


    public override void LisaVeergM(string Nimi, string Muutuja) // Meetod "AmdGpuLisaVeergO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE AMD_GPU ADD " + Nimi + " " + Muutuja + "");
        }
    }

    public override void KustutaVeergM(string Nimi) // Meetod "AmdGpuKustutaVeergO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE AMD_GPU DROP COLUMN " + Nimi + "");
        }
    }

    public override List<string> ListVeerudM() // Meetod "AmdGpuVeerudO"
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
                    cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = 'AMD_GPU'";
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

    public override List<string> IdM() // Meetod "AmdGpuIDO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.AMD.Select(a => a.Id.ToString()).ToList();
            return query;
        }
    }


    public override void Uuendamine(string Veerg, string ID, string Nimetus) // Meetod "AmdKustutaVeergO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("UPDATE AMD_GPU SET " + Veerg + "= '" + Nimetus + "' WHERE Id = " + ID + "");
        }

    }

    public override void Sisestamine(string Nimetus, string Voimsus) // Meetod "AmdGpuTabelInsertO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new AMD_GPU()
            {
                GPU = Nimetus,
                Power = int.Parse(Voimsus)
            };
            _context.AMD_GPU.Add(query);
            _context.SaveChanges();
        }
    }

    public override void Kustutamine(string ID) // Meetod "AmdGpuTabelDeleteO"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new AMD_GPU { Id = int.Parse(ID) };
            _context.AMD_GPU.Attach(query);
            _context.AMD_GPU.Remove(query);
            _context.SaveChanges();
        }
    }

    public override string ValitudTabel() // Meetod "AmdGpuValitudTabelO()"
    {
        return "Valitud tabel: 'AMD Videokaart'"; // Tagastab teksti.
    }


    public override string NimetusM() // Meetod "AmdGpuNimetusO()"
    {
        return "Nimetus: "; // Tagastab teksti.
    }

    public override string VoimsusM() // Meetod "AmdGpuVoimsusO()"
    {
        return "Võimsus: "; // Tagastab teksti.
    }
}
}
