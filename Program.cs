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

        public static string gender { get; set; } // 0 - �������, 1 - �������


        public static string passportSN { get; set; } // ����� � �����

        public static string passportW { get; set; } // ��� �����

        public static DateTime passportDI { get; set; } // ���� ������


        public static string eduLvl { get; set; } // ������� �����������

        public static string organization { get; set; } // �������� �����������

        public static string location { get; set; } // �������������� ��������������� �����������

        public static string spec { get; set; } // �������������

        public static string qual { get; set; } // ������������
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
