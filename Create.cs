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
            model.fio = FIO.Text;
            model.birthday = DTP1.Value;

            if (gen.Checked == true) model.gender = "Мужской";
            else model.gender = "Женский";

            model.passportSN = $"{passSeries.Text} {passNum.Text}";
            model.passportW = passwhom.Text;
            model.passportDI = dateTimePicker2.Value;

            model.eduLvl = edulvl.Text;
            model.organization = eduOrg.Text;
            model.location = orgLoc.Text;
            model.spec = special.Text;
            model.qual = qual.Text;
            Close();

        }
    }
}
