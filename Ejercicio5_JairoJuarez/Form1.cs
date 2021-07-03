using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_JairoJuarez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtM.Clear();
            TxtN.Clear();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            int Fila; Fila = Convert.ToInt32(TxtN.Text);
            int Columna; Columna = Convert.ToInt32(TxtM.Text);

            Random Aleatorios = new Random();

            int[,] Matriz = new int[Fila, Columna];

            for (int N = 0; N < Matriz.GetLength(1); N++)
            {
                for (int M = 0; M < Matriz.GetLength(1); N++)
                {
                    Matriz[N, M] = (Aleatorios.Next(1, 99));
                    MessageBox.Show(N + " , " + M + " = " + Matriz[N, M]);

                }
            }
        }
    }

}