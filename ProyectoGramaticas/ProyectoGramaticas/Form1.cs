using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGramaticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
        // --------------------AMBIGÜEDAD------------------------------------
        //funcion de existe ambiguedad
        private List<Dictionary<object, object>> ExisteAmbiguedad(List<List<string>> A)
        {
            List<string> B = new List<string>();
            for (int i = 0; i < A.Count; i++)
            {
                string s = A[i][0] + " " + A[i][1];
                B.Add(s);
            }
            var b = new HashSet<string>(B).ToList();
            Dictionary<object, object> amb = new Dictionary<object, object>
            {
            };
            Dictionary<object, object> notamb = new Dictionary<object, object>
            {
            };
            for (int i = 0; i < b.Count; i++)
            {
                List<object> e = new List<object>();
                for (int j = 0; j < B.Count; j++)
                {
                    if (b[i] == B[j])
                    {
                        e.Add(j);
                    }
                }
                if (e.Count > 1)
                {
                    amb[b[i]] = e;
                }
                else
                {
                    object[] Aa = b[i].Split();
                    notamb[Aa[0]] = Aa[1];
                }
            }
            var aux = new List<Dictionary<object, object>>();
            aux.Add(amb);
            aux.Add(notamb);
            return aux;
        }
        //Funcion resolver ambiguedad
        private void SolveAmbiguedad(List<List<string>> A, Dictionary<object, object> Amb, Dictionary<object, object> NotAmb)
        {
            string[] Aa;
            foreach (KeyValuePair<object, object> i in Amb)
            {
                Aa = i.Key.ToString().Split();
                List<string> S = new List<string> { Aa[0], Aa[1], Aa[0] + "a" };
                A.Add(S);
                if (!(NotAmb.ContainsKey(Aa[0])))
                {
                    List<string> vacio = new List<string> { Aa[0], "vacio", "" };
                    //List<string> vacio = new List<string> { Aa[0], "", "" };
                    A.Add(vacio);
                }
                foreach (int k in (List<object>)i.Value)
                {
                    List<string> Sol = new List<string> { Aa[0] + "a", A[k][2], "" };
                    A[k] = Sol;
                }
            }
        }

        //------------------------------RECURSION--------------------------------------
        // Funcion de existe recursion
        private List<Dictionary<string, List<int>>> ExisteRecursion(List<List<string>> A)
        {
            List<Dictionary<string, List<int>>> aux = new List<Dictionary<string, List<int>>>();
            Dictionary<string, List<int>> re = new Dictionary<string, List<int>>();
            Dictionary<string, List<int>> notre = new Dictionary<string, List<int>>();
            //Dictionary<string, int> notre = new Dictionary<string, int>();

            for (int i = 0; i < A.Count; i++)
            {
                //si la  regla es recursiva
                if (A[i][0] == A[i][1])
                {
                    if (re.ContainsKey(A[i][0]))
                    {
                        re[A[i][0]].Add(i);
                    }
                    else
                    {
                        List<int> list = new List<int>() { i };
                        re.Add(A[i][0], list);
                    }
                }
                //si la regla no es recursiva
                else
                {
                    if (A[i][2] == "")
                    {
                        if (notre.ContainsKey(A[i][0]))
                        {
                            //notre[A[i][0]][0] = i;
                            notre[A[i][0]].Add(i);
                        }
                        else
                        {
                            List<int> Elem = new List<int>() { i };
                            notre.Add(A[i][0], Elem);
                        }

                    }
                }

            }
            Dictionary<string, List<int>> aux2 = new Dictionary<string, List<int>>(notre);
            //Dictionary<string, int> aux2 = new Dictionary<string, int>(notre);
            //eliminar de aux2 aquellos simbolos de la izquierda que no tienen reglas recursivas 
            foreach (var Comp in notre)
            {
                if (!re.ContainsKey(Comp.Key))
                {
                    aux2.Remove(Comp.Key);
                }
            }
            aux.Add(re);
            aux.Add(aux2);

            return aux;
        }
        //Funcion solucion de recursion
        private void SolRecursion(List<List<string>> A, Dictionary<string, List<int>> Re, Dictionary<string, List<int>> NotRe)
        {
            foreach (var elem in Re)
            {
                for (int j = 0; j < elem.Value.Count; j++)
                {
                    List<string> R = new List<string>()
                    {
                        elem.Key + "r", A[elem.Value[j]][2],elem.Key + "r"
                    };
                    A[elem.Value[j]] = R;
                }

            }
            foreach (var val in NotRe)
            {
                for (int j =0; j < val.Value.Count;j++)
                {
                    List<string> S = new List<string>()
                        {
                            val.Key, A[val.Value[j]][1],val.Key + "r"
                        };
                    A[val.Value[j]] = S;
                    //List<string> V = new List<string>()
                    //    {
                    //        val.Key + "r","vacio",""
                    //    };
                    //A.Add(V);
                }
                List<string> V = new List<string>()
                    {
                        val.Key + "r","vacio",""
                    };
                A.Add(V);
            }
        }

        // ------------------Funcion para mostrar el resultado ---------------------------------
        private string MostrarResultado(List<List<string>> A)
        {
            //variables
            string Respuesta = "";
            for (int i=0;i < A.Count;i++ )
            {
                if (A[i][1] != "")
                {
                    Respuesta += "R" + i.ToString() + ": \t" + A[i][0].ToString() + " -> " + A[i][1] + " " + A[i][2] + "\n";
                }
                
            }

            return Respuesta;
        }
        //--------------------------AMBIGÜEDAD----------------------------------------------
        private string Ambiguedad(List<List<string>> A)
        {
            
            //resolviendo la recursion
            List<Dictionary<object, object>> Y = ExisteAmbiguedad(A);
            //ExisteRecursion recursion en:

            //obtener datos de llaves
            Dictionary<object, object>.KeyCollection keys = Y[0].Keys;
            Dictionary<object, object>.ValueCollection values = Y[0].Values;
            Dictionary<object, object> Dict_aux = Y[0];


            string R = "{ ";
            foreach (string llave in keys)
            {
                string x_aux = "[ ";
                foreach (int x in (List<object>)Dict_aux[llave])
                {
                    x_aux += x.ToString() + " ";
                }
                x_aux += "]";
                R += "[ "+ llave + " ]" + " : " + x_aux + " ;";
            }
            R += "}";
            
            string Respuesta = "Existe ambiguedad en: \n" + R + "\n" +
                "-----------------------------\n";
            SolveAmbiguedad(A, Y[0], Y[1]);
            Respuesta += MostrarResultado(A);
            return Respuesta;
        }
        //-------------------------RECURSIVIDAD------------------------------------------
        private string Recursividad(List<List<string>> A)
        {
            //resolviendo la recursion
            List<Dictionary<string, List<int>>> X = ExisteRecursion(A);
            //ExisteRecursion recursion en:
            Dictionary<string, List<int>>.KeyCollection keys = X[0].Keys;
            Dictionary<string, List<int>>.ValueCollection values = X[0].Values;
            Dictionary<string, List<int>> Dict_aux = X[0];


            string R = "{ ";
            foreach (string llave in keys)
            {
                string x_aux = "[ ";
                foreach (int x in Dict_aux[llave])
                {
                    x_aux += x.ToString() + " ";
                }
                x_aux += "]";
                R += "[ " + llave + " ]" + " : " + x_aux + " ;";
            }
            R += "}";
            
            string Respuesta = "Existe recursión en: \n" + R + "\n" +
            "-----------------------------\n";
            SolRecursion(A, X[0], X[1]);

            Respuesta += MostrarResultado(A);
            return Respuesta;
        }
        //BOTONES
        private void btnArreglarAmbiguedad_Click(object sender, EventArgs e)
        {
            //crear lista A
            try
            {
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                txtRespuesta.Text = Ambiguedad(A);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error);
            }
            

        }

        private void btnArreglarRecursividad_Click(object sender, EventArgs e)
        {
            try
            {
                //crear lista A
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                txtRespuesta.Text = Recursividad(A);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error );
            }
            
        }

        private void btnAyR_Click(object sender, EventArgs e)
        {
            try
            {
                //crear lista A
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                string Amb = Ambiguedad(A);
                string Rec = Recursividad(A);
                txtRespuesta.Text = Amb + "\n" + Rec;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error);
            }
        }

        private void btnRyA_Click(object sender, EventArgs e)
        {
            try
            {
                //crear lista A
                List<List<string>> A = new List<List<string>>();
                obtener(A);
                string Rec = Recursividad(A);
                string Amb = Ambiguedad(A);
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
