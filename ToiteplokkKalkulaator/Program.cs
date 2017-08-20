using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToiteplokkKalkulaator
{
static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles(); // Lubab rakendusel kasutada stiile.
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new ToiteplokkForm()); // Avab esimese akna, see on pea aken(ToiteplokkForm).
    }
}
}
