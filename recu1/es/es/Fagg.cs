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
    public partial class Fagg : Form
    {
        public int quantità { get; private set; }
        public Fagg()
        {
            quantità = 0;
            InitializeComponent();
            txt_qt.Visible = false;
            lbl_qt.Visible = false;
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            txt_qt.Visible = true;
            lbl_qt.Visible = true;

        }




        private void txt_qt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            if (txt_qt.Text == null || txt_qt.Text == "")
            {
                MessageBox.Show("inserisci un numero valido");
            } else
            {
                int qt;
                Int32.TryParse(txt_qt.Text, out qt);

                if (qt > 0 && qt <= 100)
                {
                    quantità = qt;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("inserisci una quantità maggiore di zero o schiaccia no");
                }

                if (qt > 0 & qt <= 100)
                    Close();
            }
        }
    }
}
