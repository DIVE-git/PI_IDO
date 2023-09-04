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

        static public string fileName = "Excel is not DB.csv"; // название .csv файла


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
                MessageBox.Show("Приложение перезапустится, это норма!", "One moment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }


        private void Exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Help(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа взаимодействует со списком сотрудником в виде .CSV файла, а именно создаёт записи, загружает записи и многое другое[В РАЗРАБОТКЕ]");
        }

        private void Create(object sender, EventArgs e)
        {
            Create fm2 = new Create();
            fm2.ShowDialog();
            output.Text = view.PrintAllData();
        }

        private void Save(object sender, EventArgs e)
        {
            if (model.fio == null || model.gender == null || model.birthday == null)
            {
                MessageBox.Show("ОШИБКА, отсутствуют основные данные для сохранения");
                return;
            }
            StreamWriter SW = new StreamWriter(fileName, true, System.Text.Encoding.UTF8);

            SW.WriteLine($"{model.fio};{model.birthday.ToString("dd.MM.yyyy")};{model.gender};{model.passportSN};{model.passportW};{model.passportDI.ToString("dd.MM.yyyy")};{model.eduLvl};{model.organization};{model.location};{model.spec};{model.qual};;");

            SW.Close();
            MessageBox.Show("УСПЕШНО");
        }

        private void LoadList(object sender, EventArgs e)
        {
            Load fm3 = new Load();
            fm3.ShowDialog();

            output.Text = view.PrintAllData();
        }

    }
}
