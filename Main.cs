using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_IDO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        static string fileName = "Excel is not DB.csv";


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Чтение/запись CSV";
        }


        private void Exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Help(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь могла быть ваша реклама");
        }

        private void Create(object sender, EventArgs e)
        {
            Create fm2 = new Create();
            fm2.ShowDialog();
            output.Text = $"ФИО: {Data.fio}\r\nДата рождения: {Data.birthday.ToString("dd.MM.yyyy")}\r\nПол: {Data.gender}\r\nСерия и номер: {Data.passportSN}\r\nКем выдан: {Data.passportW}\r\nДата выдачи: {Data.passportDI.ToString("dd.MM.yyyy")}\r\nУровень образования: {Data.eduLvl}\r\nОбразовательная организация: {Data.organization}\r\nМестоположение организации: {Data.location}\r\nСпециальность: {Data.spec}\r\nКвалификация: {Data.qual}";
        }

        private void Save(object sender, EventArgs e)
        {
           StreamWriter SW = new StreamWriter(fileName, true, System.Text.Encoding.UTF8);

            SW.WriteLine($"{Data.fio},{Data.birthday.ToString("dd.MM.yyyy")};{Data.gender};{Data.passportSN};{Data.passportW};{Data.passportDI.ToString("dd.MM.yyyy")};{Data.eduLvl};{Data.organization};{Data.location};{Data.spec};{Data.qual}");

            SW.Close();   
        }

        private void LoadList(object sender, EventArgs e)
        {
            // StreamReader SR = new StreamReader(fileName);
            MessageBox.Show($"Кол-во строк в файле: {File.ReadAllLines(fileName).Length}");
        }
    }
}
