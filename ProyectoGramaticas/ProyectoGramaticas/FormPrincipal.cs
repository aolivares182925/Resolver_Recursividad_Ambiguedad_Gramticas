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
    public partial class FormPrincipal : Form
    {
        //Metodos necesarios 
        Metodos M = new Metodos();
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #region mover ventana
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        #endregion mover ventana
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            for (int i=0; i < n;i++)
            {
                List<string> cadena = new List<string>();
                string[] aux = null;
                aux = Campos[i].Split(' '); //aux = {"A","=","E","+"..}
                cadena.Add(aux[0]);
                cadena.Add(aux[2]);

                string resto = "";
                
                for(int j=3;j < aux.Length;j++)
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

        //BOTONES

        private void btnRRecyAmb_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPrimySig_Click(object sender, EventArgs e)
        {
            try
            {
                 //resolver recursividad y ambigüedad
                //crear lista A
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                string Rec = M.Recursividad(A);
                string Amb = M.Ambiguedad(A);

                //hallar siguientes
                //obtener simbolos completos
                List<List<string>> L = new List<List<string>>();      
                M.ObtenerSimbolos(L, A);

                //filtrar lo simbolos no terminales
                List<string> N = M.FiltrarNT(L);
           
                //hallar primeros
                Dictionary<string, List<string>> Primeros = M.ConjuntosPrimerosI(L);

                string prim_texto = M.Resultado_dicc("Primero", Primeros);

                //hallar siguientes
                Dictionary<string, List<string>> Sig = new Dictionary<string, List<string>>();
                
                foreach (string elemento in N)
                {
                    Dictionary<string, List<string>> S = new Dictionary<string, List<string>>();
                    List<string> Aux = M.Siguientes(elemento, L, N, S, Primeros);
                    Aux = new HashSet<string>(Aux).ToList();
                    Sig.Add(elemento, Aux);
                }

                string sig_texto = M.Resultado_dicc("Siguiente", Sig);


                string Respuesta_final = Rec + "\n" + Amb + "\n" + prim_texto + "\n" + sig_texto;

                txtRespuesta.Text = Respuesta_final;
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error);
            }

        }

        private void panelprograma1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
