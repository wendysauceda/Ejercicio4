using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            string[] Nombre = new string[1];
            int[] Edad = new int[1];


            for (int i = 0; i < Nombre.Length; i++)
            {
                Nombre[i] = txt_Nombre.Text;
                Edad[i] = Convert.ToInt32(txt_Edad.Text);

            }

            for (int i = 0; i < Nombre.Length; i++)
            {
                cb_ListaEst.Items.Add(Nombre[i] + " " + Edad[i]);

            }


            

            Limpiar();


        }
        private void Limpiar()
        {
            txt_Nombre.Clear();
            txt_Edad.Clear();
            txt_Nombre.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Ordenar.Sorted = false;
        }

        private void btn_Menor_Click(object sender, EventArgs e)
        {
            cb_Ordenar.Sorted = true;
        }
    }


}






