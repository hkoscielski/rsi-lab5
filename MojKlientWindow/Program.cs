using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Przestrzeń nazw aplikacji klienckiej z interfejsem graficznym. Zawiera implementację aplikacji klienckiej wraz zapewnieniem jej łączności z serwisem.
/// Autor: 228172. Hubert Kościelski.
/// </summary>
namespace MojKlientWindow
{
    /// <summary>
    /// Główna klasa aplikacji klienckiej. To ona jest wywoływana jako pierwsza. Wywołuje ona aplikację okienkową jako klasę Form1, która zapewnia interfejs graficzny klienta.
    /// Autor: 228172. Hubert Kościelski.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji. Metoda wywołuje aplikację okienkową będącą klasą Form1, która zapewnia interfejs graficzny klienta.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
