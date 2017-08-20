using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToiteplokkKalkulaator.Klassid
{
class SqlMuutujadClass
{
    public string[] SqlMuutujad() // Massiivi muutuja meetod.
    {

        string[] _sqlMuutujad = { "varchar(50)", "int", "float", "text" }; // Massiivi muutuja.
        return _sqlMuutujad; // Tagastab muutuja
    }
}
}
