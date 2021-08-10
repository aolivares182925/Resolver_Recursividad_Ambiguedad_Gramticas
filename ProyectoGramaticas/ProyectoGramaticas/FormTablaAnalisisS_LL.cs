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
    public partial class FormTablaAnalisisS_LL : Form
    {
        //Metodos necesarios 
        Metodos M = new Metodos();
    

        public FormTablaAnalisisS_LL()
        {
            InitializeComponent();
        }
               
       
        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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
                //resolver recursividad y ambigüedad
                //crear lista A
                DGV1.Rows.Clear();
                DGV1.Columns.Clear();
                txtRespuesta.Text = ""; 
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                string Rec = M.Recursividad(A);
                string Amb = M.Ambiguedad(A);

                //hallar siguientes
                //obtener simbolos completos
                List<List<string>> L = new List<List<string>>();
                M.ObtenerSimbolos(L, A);

                //filtrar lo simbolos no terminales
                List<string> NT = M.FiltrarNT(L);
                List<string> T = M.FiltrarT(L, NT);

                //llenar data grid view
                Dictionary<string, List<string>> P = M.ConjuntosPrimerosI(L);
                DGV1.Columns.Add("nada", "");

                
                for (int i = 0; i < T.Count; i++)
                {
                    DGV1.Columns.Add("columna1", T[i]);
                }
                DGV1.Columns.Add("columna1", "$");

                

                foreach (string k in NT)
                {
                    List<string> Lista = new List<string>();
                    Lista.Add(k);
                    for (int i = 0; i < DGV1.Columns.Count; i++)
                    {
                        Lista.Add("error");
                    }
                    DGV1.Rows.Add(Lista.ToArray());
                    //DGV.Rows[0].Cells[0].Value = "aea";

                }
                M.TablaSintactica(DGV1, L, P, T, NT);


                string prim_texto = M.Resultado_dicc("Primero", P);

                //hallar siguientes
                Dictionary<string, List<string>> Sig = new Dictionary<string, List<string>>();

                foreach (string elemento in NT)
                {
                    Dictionary<string, List<string>> S = new Dictionary<string, List<string>>();
                    List<string> Aux = M.Siguientes(elemento, L, NT, S, P);
                    Aux = new HashSet<string>(Aux).ToList();
                    Sig.Add(elemento, Aux);
                }

                string sig_texto = M.Resultado_dicc("Siguiente", Sig);


                string Respuesta_final = Rec + "\n" + Amb + "\n" + prim_texto + "\n" + sig_texto;

                txtRespuesta.Text = Respuesta_final;

              

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error);
            }

      
        }

        private void FormTablaAnalisisS_LL_Load(object sender, EventArgs e)
        {
            //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            //ToolTip1.SetToolTip(this.btnExpandirDGV, "Expandir tabla");
        }

        

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
