using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToiteplokkKalkulaator.Klassid
{
abstract class Komponendid
{
    public abstract List<ToiteplokkAndmed> AndmedM();
    public abstract DataTable TabelM();
    public abstract void LisaVeergM(string Nimi, string Muutuja);
    public abstract void KustutaVeergM(string Nimi);
    public abstract List<string> ListVeerudM();
    public abstract List<string> IdM();
    public abstract void Uuendamine(string Veerg, string ID, string Nimetus);
    public abstract void Sisestamine(string Nimetus, string Voimsus);
    public abstract void Kustutamine(string ID);
    public abstract string ValitudTabel();
    public abstract string NimetusM();
    public abstract string VoimsusM();

}
}
