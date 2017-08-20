using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToiteplokkKalkulaator.Klassid
{
class ToiteplokkAndmed
{
    public int Id // Meetod "Id" omadus.
    {
        get; // Loeb.
        set; // Asendab.
    }
    public string Name // Meetod "Name" omadus.
    {
        get; // Loeb.
        set; // Asendab.
    }
    public int Power // Meetod "Power" omadus.
    {
        get; // Loeb.
        set; // Asendab.
    }
    public override string ToString() // Meetod "ToString" teisendamine.
    {
        return Name; // Tagastab muutuja.
    }
}
}
