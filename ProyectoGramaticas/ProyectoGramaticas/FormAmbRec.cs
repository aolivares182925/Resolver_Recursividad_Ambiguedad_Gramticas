using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaFunciones;

namespace ProyectoGramaticas
{
    public partial class FormAmbRec : Form
    {
        //Metodos necesarios 
        Metodos M = new Metodos();
        public FormAmbRec()
        {
            InitializeComponent();
        }

        //obtener las reglas del txt
        private void obtener(List<List<string>> A)
        {
            //dividir en lineas
            string[] Campos = null;
            Campos = txtReglas.Text.Split(new char[] { '\n' });
            //campos = {{"regla 1"},{"regla 2"}...}
            //oredenar
            //Array.Sort(Campos);
            //numero de reglas
            int n = Campos.Length;
            //crear lista de reglas(listas)
            //List<List<string>> A = new List<List<string>>();
            //añadir a listas

            for (int i = 0; i < n; i++)
            {
                List<string> cadena = new List<string>();
                string[] aux = null;
                aux = Campos[i].Split(' '); //aux = {"A","=","E","+"..}
                cadena.Add(aux[0]);
                cadena.Add(aux[2]);

                string resto = "";

                for (int j = 3; j < aux.Length; j++)
                {
                    if (j == aux.Length - 1)
                        resto += aux[j];
                    else
                        resto += aux[j] + " ";
                }
                cadena.Add(resto);
                A.Add(cadena);
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                //crear lista A
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                string Rec = M.Recursividad(A);
                string Amb = M.Ambiguedad(A);
                txtRespuesta.Text = Rec + "\n" + Amb;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error);
            }
        }
    }
}
