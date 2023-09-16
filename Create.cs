using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

            else if (string.IsNullOrEmpty(FIO.Text) || string.IsNullOrEmpty(phone.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(address.Text))
            {
                MessageBox.Show("ОШИБКА!\r\nВведите ФИО");
                return;
            }

            else if (string.IsNullOrEmpty(passSeries.Text) || string.IsNullOrEmpty(passNum.Text))
            {
                MessageBox.Show("ОШИБКА!\r\nВведите серию/номер");
                return;
            }


            else if (string.IsNullOrEmpty(edulvl.Text) || string.IsNullOrEmpty(eduOrg.Text) || string.IsNullOrEmpty(orgLoc.Text) || string.IsNullOrEmpty(special.Text) || string.IsNullOrEmpty(qual.Text))
            {
                MessageBox.Show("ОШИБКА!\r\nВведите сведения об организации");
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
            model.special = special.Text;
            model.qual = qual.Text;
            model.phone = phone.Text;
            model.email = email.Text;
            model.address = address.Text;
            Close();

        }
    }
}
