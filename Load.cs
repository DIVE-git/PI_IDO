using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int allLines = File.ReadAllLines(Main.fileName).Length;
        private void Load_Load(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader(Main.fileName);

            ComboLoad.Items.Clear();

            for (int i = 1; i <= allLines ;i++)
            {
                ComboLoad.Items.Add(SR.ReadLine());
            }
             label1.Text = $"Кол-во строк в файле: {allLines}";


            SR.Close();
        }
    }
}
