using System;

namespace PI_IDO
{
   static class model
    {
        public static string fio { get; set; }
        
        public static DateTime birthday { get; set; }

        public static string gender { get; set; }


        public static string passportSN { get; set; } // Серия и номер

        public static string passportW { get; set; } // Кем выдан

        public static DateTime passportDI { get; set; } // Дата выдачи


        public static string eduLvl { get; set; } // Уровень образования

        public static string organization { get; set; } // Название организации

        public static string location { get; set; } // Местоположение образовательной организации


        public static string special { get; set; } // Специальность

        public static string qual { get; set; } // Квалификация


        public static string phone { get; set; } // Телефон

        public static string email { get; set; } // E-mail

        public static string address { get; set; } // Адрес
    }
}
