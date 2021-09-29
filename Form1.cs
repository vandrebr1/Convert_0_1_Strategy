using Convert_0_1_Strategy.Constantes;
using Convert_0_1_Strategy.Factory;
using Convert_0_1_Strategy.Interface;
using System;
using System.Windows.Forms;

namespace Convert_0_1_Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void Processar()
        {
            AddTextRitch("Texto Original:");
            AddTextRitch(Constante.binario);

            string resultado = "";
            foreach (char c in Constante.binario)
            {
                IBit bit = BitFactory.Of(c);

                if (bit != null)
                {
                    resultado += bit.Inverter();
                }

            }
            AddTextRitch("###############################");
            AddTextRitch("Texto Alterado:");
            AddTextRitch(resultado);
        }

        private void AddTextRitch(string saida)
        {
            rtbSaida.AppendText(saida + "\r\n");
            rtbSaida.ScrollToCaret();
        }
    }
}
