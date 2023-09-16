using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_IDO
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        List<string> listString = new List<string>(); // 100 - число макс. кол-ва работников, число может быть другое, но кол-во сотрудников не должно его превышать
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ComboLoad.Text))
            {
                MessageBox.Show("ОШИБКА Не выбрана запись из списка.");
                return;
            }
            char[] charsList = listString[ComboLoad.SelectedIndex].ToCharArray();
            int delimCounter = 0;
            string tempString = "";
            for (int i = 0; i < charsList.Length - 1; i++)
            {

                // не готово
                tempString += charsList[i];
                if (charsList[i + 1] == ';')
                {
                    // if (charsList[i+2] == ';') { Debug.WriteLine("Раз-раз, проверка"); }
                    delimCounter++;
                    i++;
                    try
                    {
                        //   Debug.WriteLine(tempString);
                        switch (delimCounter)
                        {
                            case 0:
                                break;
                            case 1:
                                model.fio = tempString;
                                tempString = "";
                                break;
                            case 2:
                                model.birthday = DateTime.Parse(tempString);
                                tempString = "";
                                break;
                            case 3:
                                model.gender = tempString;
                                tempString = "";
                                break;
                            case 4:
                                model.passportSN = tempString;
                                tempString = "";
                                break;
                            case 5:
                                model.passportW = tempString;
                                tempString = "";
                                break;
                            case 6:
                                model.passportDI = DateTime.Parse(tempString);
                                tempString = "";
                                break;
                            case 7:
                                model.eduLvl = tempString;
                                tempString = "";
                                break;
                            case 8:
                                model.organization = tempString;
                                tempString = "";
                                break;
                            case 9:
                                model.location = tempString;
                                tempString = "";
                                break;
                            case 10:
                                model.special = tempString;
                                tempString = "";
                                break;
                            case 11:
                                model.qual = tempString;
                                tempString = "";
                                break;
                            case 12:
                                model.phone = tempString;
                                tempString = "";
                                break;
                            case 13:
                                model.email = tempString;
                                tempString = "";
                                break;
                            case 14:
                                model.address = tempString;
                                tempString = "";
                                break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при чтении!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }



            Close();
        }




        private void Load_Load(object sender, EventArgs e)
        {
            int allLines = 0;
            try
            {
                 allLines = File.ReadAllLines(Main.fileName).Length;
            }
            catch { return; }
            StreamReader SR = new StreamReader(Main.fileName);

            ComboLoad.Items.Clear();

            for (int i = 0; i <= allLines - 1; i++)
            {
                listString.Add(SR.ReadLine());
                char[] charsList = listString[i].ToCharArray();
                string tempString = "";
                for (int j = 0; j < charsList.Length; j++)
                {
                    if (charsList[j] == ';') break;
                    else tempString += charsList[j];
                }


                ComboLoad.Items.Add(tempString);
            }
            label1.Text = $"Кол-во строк в файле: {allLines}";


            SR.Close();
        }

        private void EHandled(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
