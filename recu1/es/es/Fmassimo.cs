using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Fmassimo : Form
    {
        public double massimo { get; private set; }

        public Fmassimo()
        {
            InitializeComponent();
        }

        private void btn_massimo_Click(object sender, EventArgs e)
        {
            if (txt_massimo.Text == null || txt_massimo.Text == "")
            {
                MessageBox.Show("inserisci un numero valido");
            } else {
                massimo = double.Parse(txt_massimo.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txt_massimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool puoInserireVirgola = !txt_massimo.Text.Contains(',') && e.KeyChar == ',';
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !puoInserireVirgola)
            {
                e.Handled = true;
            }
        }
    }
}
