using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaseObjekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnesiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Klasa osoba = new Klasa(Unos_String.Text, Convert.ToInt32(UnosInt.Text));
                rtxIspis.Text = osoba.ToString();
            }
            catch (Exception greska)
            {
                MessageBox.Show("Greška");
            }
        }
    }
}
