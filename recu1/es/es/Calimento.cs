using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    internal class Calimento
    {

        public string Nome { get; private set; }
        public double Prezzo { get; private set; }
        public int Quantità { get; private set; }

        public Calimento() { }

        public Calimento(string nome, double prezzo, int quantità)
        {
            //MessageBox.Show(prezzo.ToString());
            Nome = nome;
            Prezzo = prezzo;
            Quantità = quantità;
        }

        public string visualizza()
        {
            return $"nome: {Nome}, prezzo: {Prezzo}, quantità{Quantità}";
        }

    }
}
