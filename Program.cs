using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_IDO
{
    static class Data
    {
        public static string fio { get; set; }
        
        public static DateTime birthday { get; set; }

        public static string gender { get; set; } // 0 - женский, 1 - мужской


        public static string passportSN { get; set; } // Серия и номер

        public static string passportW { get; set; } // Кем выдан

        public static DateTime passportDI { get; set; } // Дата выдачи


        public static string eduLvl { get; set; } // Уровень образования

        public static string organization { get; set; } // Название организации

        public static string location { get; set; } // Местоположение образовательной организации

        public static string spec { get; set; } // Специальность

        public static string qual { get; set; } // Квалификация
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
