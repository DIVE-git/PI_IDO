using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_IDO
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Ehandled(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Onlydigits(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != 8) e.Handled = true;
        }

        private void Save(object sender, EventArgs e)
        {
            if (gen.Checked == false && der.Checked == false)
            {
                MessageBox.Show("ОШИБКА!\r\nВыберите пол!");
                return;
            }
            Data.fio = FIO.Text;
            Data.birthday = DTP1.Value;
            if (gen.Checked == true) Data.gender = "Мужской";
            else Data.gender = "Женский";

            Data.passportSN = $"{passSeries.Text} {passNum.Text}";
            Data.passportW = passwhom.Text;
            Data.passportDI = dateTimePicker2.Value;

            Data.eduLvl = edulvl.Text;
            Data.organization = eduOrg.Text;
            Data.location = orgLoc.Text;
            Data.spec = special.Text;
            Data.qual = qual.Text;
            Close();

        }
    }
}
