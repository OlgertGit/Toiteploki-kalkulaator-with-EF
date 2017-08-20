using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using ToiteplokkKalkulaator.Models;

namespace ToiteplokkKalkulaator.Klassid
{
class ToiteplokkVoimsus:Komponendid
{
    IMessageService _service = new MessageService();

    public double PowerProtsessor
    {
        get;
        set;
    }
    public double PowerRAM
    {
        get;
        set;
    }
    public double PowerVideokaart
    {
        get;
        set;
    }
    public double PowerStorage
    {
        get;
        set;
    }
    public double PowerOptical
    {
        get;
        set;
    }

    public double Vastus() // Meetod "ShowData()"
    {
        double _vastus = PowerProtsessor + PowerRAM + PowerVideokaart + PowerStorage + PowerOptical; // Muutuja määramine ja kõik muutujate liitmine.
        return _vastus; // Tagastab muutuja.
    }

    public double VastusRecommended() // Meetod "VastusRecommended()"
    {
        double _vastusRecommended = Math.Round(Vastus() * 120 / 100); // Muutuja määramine ja vastuse ümmardamine.
        return _vastusRecommended; // Tagastab muutuja.
    }

    public void Vordle()
    {
        try // Proovi
        {
            if (VastusRecommended() <= 150) // Kui alla 150.
            {
                Process.Start(Toiteplokk_200()); //200
            }
            else if (VastusRecommended() <= 151 && VastusRecommended() <= 250) // Kui alla 151 ja 250.
            {
                Process.Start(Toiteplokk_300()); //300
            }
            else if (VastusRecommended() <= 251 && VastusRecommended() <= 350) // Kui alla 251 ja 350.
            {
                Process.Start(Toiteplokk_400()); // 400
            }
            else if (VastusRecommended() <= 351 && VastusRecommended() <= 450) // Kui alla 351 ja 450.
            {
                Process.Start(Toiteplokk_500()); // 500
            }
            else if (VastusRecommended() <= 451 && VastusRecommended() <= 550) // Kui alla 451 ja 550.
            {
                Process.Start(Toiteplokk_600()); // 600
            }
            else if (VastusRecommended() <= 551 && VastusRecommended() <= 650) // Kui alla 551 ja 650.
            {
                Process.Start(Toiteplokk_700()); // 700
            }
            else if (VastusRecommended() <= 651 && VastusRecommended() <= 750) // Kui alla 651 ja 750.
            {
                Process.Start(Toiteplokk_800()); // 800
            }
            else if (VastusRecommended() <= 751 && VastusRecommended() <= 850) // Kui alla 751 ja 850.
            {
                Process.Start(Toiteplokk_900()); // 900
            }
            else if (VastusRecommended() <= 851 && VastusRecommended() <= 950) // Kui alla 851 ja 950.
            {
                Process.Start(Toiteplokk_1000()); // 1000
            }
            else if (VastusRecommended() <= 951 && VastusRecommended() <= 1050) // Kui alla 951 ja 1050.
            {
                Process.Start(Toiteplokk_1200()); // 1200
            }
            else if (VastusRecommended() <= 1051 && VastusRecommended() <= 1150) // Kui alla 1051 ja 1150.
            {
                Process.Start(Toiteplokk_1250());  // 1250
            }
            else if (VastusRecommended() <= 1151 && VastusRecommended() <= 1250) // Kui alla 1151 ja 1250.
            {
                Process.Start(Toiteplokk_1300()); // 1300
            }
            else if (VastusRecommended() <= 1251 && VastusRecommended() <= 1350) // Kui alla 1251 ja 1350.
            {
                Process.Start(Toiteplokk_1400()); // 1400
            }
            else if (VastusRecommended() <= 1351 && VastusRecommended() <= 1600) // Kui alla 1251 ja 1350.
            {
                Process.Start(Toiteplokk_1600()); // 1600
            }
            else // Muu
            {
                return; // Tagastab.
            }
        }
        catch (Exception ex) // Püüab viga.
        {
            _service.MessageError(ex.Message, "Viga!"); // Näitab viga messagebox'is.
        }
    }


    public string Toiteplokk_200() // Meetod "string"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 1).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }
    }

    public string Toiteplokk_300() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 2).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_400() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 3).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_500() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 4).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_600() // Meetod "string"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 5).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_700() // Meetod "string"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 6).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_800() // Meetod "string"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 7).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_900() // Meetod "string"
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 8).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_1000() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 9).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_1200() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 10).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_1250() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 11).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_1300() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 12).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_1400() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 13).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }
    public string Toiteplokk_1600() // Meetod "string"
    {

        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            string _power = null;
            var query = _context.ToiteplokkPower.Where(t => t.Id == 14).Select(t => t.Aadress).ToList();
            foreach (var item in query)
            {
                _power = item;
            }
            return _power;
        }

    }

    public override List<ToiteplokkAndmed> AndmedM()
    {
        throw new NotImplementedException();
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
                    cmd.CommandText = "SELECT * FROM ToiteplokkPower";
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

    public override void LisaVeergM(string Nimi, string Muutuja)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE ToiteplokkPower ADD " + Nimi + " " + Muutuja + "");
        }
    }

    public override void KustutaVeergM(string Nimi)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("ALTER TABLE ToiteplokkPower DROP COLUMN " + Nimi + "");
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
                    cmd.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = 'ToiteplokkPower'";
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

    public override List<string> IdM()
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.ToiteplokkPower.Select(a => a.Id.ToString()).ToList();
            return query;
        }
    }

    public override void Uuendamine(string Veerg, string ID, string Nimetus)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = _context.Database.ExecuteSqlCommand("UPDATE ToiteplokkPower SET " + Veerg + "= '" + Nimetus + "' WHERE Id = " + ID + "");
        }
    }

    public override void Sisestamine(string Nimetus, string Voimsus)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new ToiteplokkPower()
            {
                Toiteplokk = Nimetus,
                Aadress = Voimsus
            };
            _context.ToiteplokkPower.Add(query);
            _context.SaveChanges();
        }
    }

    public override void Kustutamine(string ID)
    {
        using (var _context = new ToiteplokkKalkulaatorDBContext())
        {
            var query = new ToiteplokkPower { Id = int.Parse(ID) };
            _context.ToiteplokkPower.Attach(query);
            _context.ToiteplokkPower.Remove(query);
            _context.SaveChanges();
        }
    }

    public override string ValitudTabel()
    {
        return "Valitud tabel: 'Toiteplokk Power'"; // Tagastab teksti.
    }

    public override string NimetusM()
    {
        return "Toiteplokk: "; // Tagastab teksti.
    }

    public override string VoimsusM()
    {
        return "Aadress: "; // Tagastab teksti.
    }
}
}
