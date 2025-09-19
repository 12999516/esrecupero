using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        int q;
        List<Calimento> lista = new List<Calimento>();
        public Form1()
        {
            InitializeComponent();
            q = 0;
            prendidati();
            dtg_main.DataSource = lista;
        }

        public void prendidati()
        {
            using (StreamReader sr = new StreamReader("lista.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    string[] campi = riga.Split(';');

                    lista.Add(new Calimento(campi[0], double.Parse(campi[1]), Int32.Parse(campi[2])));
                }
            }

            dtg_main.DataSource = lista;
        }

        public int gestform()
        {
            int qt = 0;

            using (Fagg f = new Fagg())
            {
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    qt = f.quantità;
                    
                }
            }
            return qt;
        }

        public void crealist()
        {
            if (lista.Count >= q)
            {
                MessageBox.Show("Sei arrivato al massimo di alimenti.");
                return;
            }

            string nome = txt_nome.Text.ToLower();
            double prezzo = double.Parse(txt_prezzo.Text);
            int quantità = Int32.Parse(txt_quantità.Text);

            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i].Nome.ToLower() == nome.ToLower())
                {
                    MessageBox.Show("Questo alimento è già presente.");
                    return;
                }
            }


            lista.Add(new Calimento(nome, prezzo, quantità));


            txt_nome.Clear();
            txt_prezzo.Clear();
            txt_quantità.Clear();


            dtg_main.DataSource = null;
            dtg_main.DataSource = lista;
        }




        private void btn_conferma_Click(object sender, EventArgs e)
        {
            crealist();
        }

        private void btn_disponibili_Click(object sender, EventArgs e)
        {
            List<Calimento> disp = new List<Calimento>();

            for (int i = 0; i < lista.Count(); i++) 
            {

                if (lista[i].Quantità > 0) 
                {

                    disp.Add(lista[i]);

                }
            
            }

            dtg_main.DataSource = disp;

        }

        private void btn_filtra_Click(object sender, EventArgs e)
        {
            List<Calimento> filtra = new List<Calimento>();
            double max = 0;

            using (Fmassimo fm = new Fmassimo())
            {
                DialogResult dr = fm.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    max = fm.massimo;
                }
            }

            for(int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].Prezzo <= max)
                {
                    filtra.Add(lista[i]);
                }
            }

            dtg_main.DataSource = filtra;

        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_prezzo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool puoInserireVirgola = !txt_prezzo.Text.Contains(',') && e.KeyChar == ',';
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !puoInserireVirgola)
            {
                e.Handled = true;
            }
        }

        private void txt_quantità_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_agg_Click(object sender, EventArgs e)
        {
            q += gestform();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            using (StreamWriter sr = new StreamWriter("lista.csv", append: false))
            {
                for (int i = 0; i < lista.Count(); i++)
                {
                    sr.WriteLine($"{lista[i].Nome.ToString()};{lista[i].Prezzo.ToString()};{lista[i].Quantità.ToString()}");
                }
            }
        }
    }
}
