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

        //obtener todos los simbolos
        //private void ObtenerSimbolos(List<List<string>> L, List<List<string>> R)
        //{
        //    string[] Simbolos = null;
        //    foreach (List<string> k in R)
        //    {
        //        List<string> La = new List<string>();
        //        foreach (string i in k)
        //        {
        //            Simbolos = i.Split(new char[] { ' ' });
        //            foreach (string j in Simbolos)
        //            {
        //                La.Add(j);
        //            }
        //        }
        //        L.Add(La);
        //    }
        //}
        #region Ambigüedad
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
                //if (!(NotAmb.ContainsKey(Aa[0])))
                //{
                //    List<string> vacio = new List<string> { Aa[0], "vacio", "" };
                //    //List<string> vacio = new List<string> { Aa[0], "", "" };
                //    A.Add(vacio);
                //}
                foreach (int k in (List<object>)i.Value)
                {
                    List<string> Sol;
                    if (A[k][2] == "")
                    {
                        Sol = new List<string> { Aa[0] + "a", "vacio", "" };
                    }
                    else
                    {
                        Sol = new List<string> { Aa[0] + "a", A[k][2], "" };
                    }
                    
                    A[k] = Sol;
                }
            }
        }
        #endregion Ambigüedad

        #region Recursion
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
        #endregion Recursion
        // ------------------Funcion para mostrar el resultado ---------------------------------
        private string MostrarResultado(List<List<string>> A)
        {
            //variables
            string Respuesta = "";
            for (int i=0;i < A.Count;i++ )
            {
                Respuesta += "R" + i.ToString() + ": \t" + A[i][0].ToString() + " -> " + A[i][1] + " " + A[i][2] + "\n";
                //if (A[i][1] != "")
                //{
                //    Respuesta += "R" + i.ToString() + ": \t" + A[i][0].ToString() + " -> " + A[i][1] + " " + A[i][2] + "\n";
                //}

            }

            return Respuesta;
        }
        //--------------------------AMBIGÜEDAD----------------------------------------------
        #region funciones_resumidas
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
        #endregion funciones_resumidas
        
        //-----------------------PRIMEROS Y SIGUIENTES----------------------------------    
        #region Primeros
        private void Completar(Dictionary<string, List<string>> CP, List<string> Lista1, List<string> Lista2, string elem)
        {
            if (Lista1.Contains(elem))
            {
                int ind1 = Lista1.IndexOf(elem);
                Completar(CP, Lista1, Lista2, Lista2[ind1]);

                if (Lista2.Contains(elem))
                {
                    int ind2 = Lista2.IndexOf(elem);
                    for (int i = 0; i < CP[elem].Count; i++)
                    {
                        if (CP.ContainsKey(Lista1[ind2]))
                        {
                            if (!CP[Lista1[ind2]].Contains(CP[elem][i]))
                            {
                                CP[Lista1[ind2]].Add(CP[elem][i]);
                            }
                        }
                        else
                        {
                            List<string> Elem = new List<string>() { CP[elem][i] };
                            CP.Add(Lista1[ind2], Elem);
                        }
                    }
                }
            }
            else
            {
                int ind3 = Lista2.IndexOf(elem);
                for (int i = 0; i < CP[elem].Count; i++)
                {
                    if (CP.ContainsKey(Lista1[ind3]))
                    {
                        if (!CP[Lista1[ind3]].Contains(CP[elem][i]))
                        {
                            CP[Lista1[ind3]].Add(CP[elem][i]);
                        }
                    }
                    else
                    {
                        List<string> Elem = new List<string>() { CP[elem][i] };
                        CP.Add(Lista1[ind3], Elem);
                    }
                }
            }
        }

        private Dictionary<string, List<string>> ConjuntosPrimerosI(List<List<string>> A)
        {
            Dictionary<string, List<string>> ConjPrimeros = new Dictionary<string, List<string>>();
            //generar lista de no terminales
            List<string> NT = new List<string>();
            for (int i = 0; i < A.Count; i++)
            {
                NT.Add(A[i][0]);
            }
            //recorrer la lista de listas A para: generar las listas paralelas para cuando primero(X)= primero(Y), generar los conjuntos
            //primeros de todos los terminales Y generar completa y/o parcialmente los conjuntos primeros de algunos NT

            //Listas paralelas con los caminos a seguir
            List<string> Lista1 = new List<string>();
            List<string> Lista2 = new List<string>();

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 1; j < A[i].Count; j++)
                {
                    if (A[i][j] != "")
                    {
                        //si es el primer elemento
                        if (j == 1)
                        {
                            //si el primer elemento es un no terminal
                            if (NT.Contains(A[i][j]))
                            {
                                Lista1.Add(A[i][0]);
                                Lista2.Add(A[i][j]);

                            }
                            //si el primer elemento es un terminal
                            else
                            {
                                //Añadir el elem terminal al conjunto de primeros del simb izquierdo que toca
                                if (ConjPrimeros.ContainsKey(A[i][0]))
                                {
                                    ConjPrimeros[A[i][0]].Add(A[i][1]);
                                }
                                else
                                {
                                    List<string> Elem = new List<string>() { A[i][j] };
                                    ConjPrimeros.Add(A[i][0], Elem);
                                }
                                //Añadir el conjunto primero del terminal, si este no es clave en el diccionario resultado
                                if ((!ConjPrimeros.ContainsKey(A[i][j])) && (A[i][j] != "vacio"))
                                {
                                    List<string> Elem = new List<string>() { A[i][j] };
                                    ConjPrimeros.Add(A[i][j], Elem);
                                }
                            }
                        }
                        else  //si es desde el segundo elemento en adelante
                        {
                            //si es terminal, no es clave en el diccionario resultado y es diferente de vacio
                            if ((!NT.Contains(A[i][j])) && (!ConjPrimeros.ContainsKey(A[i][j])) && (A[i][j] != "vacio"))
                            {
                                List<string> Elem = new List<string>() { A[i][j] };
                                ConjPrimeros.Add(A[i][j], Elem);
                            }

                        }
                    }
                }
            }
            //completar conjuntos primeros de los NT que cuenten con caminos

            for (int i = 0; i < Lista1.Count; i++)
            {
                Completar(ConjPrimeros, Lista1, Lista2, Lista1[i]);
            }
            return ConjPrimeros;

        }
        #endregion Primeros

        #region Siguientes
        //Parametro 1 L es una lista de listas donde se almacenaran los simbolo
        //Parametro 2 R es una lista de listas donde esta el resultado de resolver ambiguedad y recursividad
        private void ObtenerSimbolos(List<List<string>> L, List<List<string>> R)
        {
            string[] Simbolos = null;
            foreach (List<string> k in R)
            {
                List<string> La = new List<string>();
                foreach (string i in k)
                {
                    Simbolos = i.Split(new char[] { ' ' });
                    foreach (string j in Simbolos)
                    {
                        La.Add(j);
                    }
                }
                L.Add(La);
            }
        }

        //Siguientes
        private List<string> Siguientes(string C, List<List<string>> L, List<string> N, Dictionary<string, List<string>> S, Dictionary<string, List<string>> P)
        {
            if (S.Keys.Contains(C))
            {
                return S[C];
            }
            else
            {
                S.Add(C, new List<string>());
                if (C == L[0][0])
                {
                    S[C].Add("$");
                }
                foreach (List<string> k in L)
                {
                    int i = k.IndexOf(C);
                    if (i > 0)
                    {
                        if (i == k.Count - 1)
                        {
                            if (k[0] == k[i])
                            {
                                continue;
                            }
                            else
                            {
                                S[C].AddRange(Siguientes(k[0], L, N, S, P));
                            }
                        }
                        else
                        {
                            if (!(N.Contains(k[i + 1])))
                            {
                                S[C].Add(k[i + 1]);
                            }
                            else
                            {
                                if (P[k[i + 1]].Contains("vacio"))
                                {
                                    S[C].AddRange(Siguientes(k[0], L, N, S, P));
                                }
                                S[C].AddRange(P[k[i + 1]]);
                                S[C].Remove("vacio");
                            }
                        }
                    }
                }
            }
            return S[C];
        }

        //Modulo que obtiene en una lista los simbolos no terminales
        private List<string> FiltrarNT(List<List<string>> L)
        {
            List<string> Lista = new List<string>();
            foreach (List<string> k in L)
            {
                foreach (string s in k)
                {
                    if (char.IsUpper(s[0]))
                    {
                        Lista.Add(s);
                    }
                }
            }
            return Lista;
        }
        #endregion Siguientes

        //tipo puede ser primero o siguiente
        private string Resultado_dicc (string Tipo,Dictionary<string,List<string>> D)
        {
            string R = "";

            foreach (var fila in D)
            {
                R += Tipo + "(" + fila.Key.ToString() + ") = { ";
                string aux = ""; 
                foreach (string elemento in (List<string>)fila.Value)
                {
                    aux += elemento + ", ";
                }
                R += "}\n";
            }
            return R;
        }

        //BOTONES


        private void btnRRecyAmb_Click(object sender, EventArgs e)
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
            //resolver recursividad y ambigüedad
            //crear lista A
            List<List<string>> A = new List<List<string>>();
            obtener(A);
            string Rec = Recursividad(A);
            string Amb = Ambiguedad(A);

            //hallar siguientes
            //obtener simbolos completos
            List<List<string>> L = new List<List<string>>();
            ObtenerSimbolos(L, A);

            //filtrar lo simbolos no terminales
            List<string> N = FiltrarNT(L);
            Dictionary<string, List<string>> S = new Dictionary<string, List<string>>();
            //hallar primeros

            Dictionary<string, List<string>> Primeros = ConjuntosPrimerosI(L);
            string prim_texto = Resultado_dicc("Primero", Primeros);


            foreach (string elemento in N)
            {
                List<string> Aux = new List<string>();
                Aux = Siguientes(elemento, L, N, S, Primeros);
            }
            string sig_texto = Resultado_dicc("Siguiente", S);

            string Respuesta_final = Rec + "\n" + Amb + "\n" + prim_texto + "\n" + sig_texto;

            txtRespuesta.Text = Respuesta_final;

            //try
            //{
            //    //resolver recursividad y ambigüedad
            //    //crear lista A
            //    List<List<string>> A = new List<List<string>>();
            //    obtener(A);
            //    string Rec = Recursividad(A);
            //    string Amb = Ambiguedad(A);

            //    //hallar siguientes
            //    //obtener simbolos completos
            //    List<List<string>> L = new List<List<string>>();
            //    ObtenerSimbolos(L, A);

            //    //filtrar lo simbolos no terminales
            //    List<string> N = FiltrarNT(L);
            //    Dictionary<string, List<string>> S = new Dictionary<string, List<string>>();
            //    //hallar primeros
                
            //    Dictionary<string, List<string>> Primeros = ConjuntosPrimerosI(L);
            //    string prim_texto = Resultado_dicc("Primero", Primeros);


            //    foreach (string elemento in N)
            //    {
            //        List<string> Aux = new List<string>();
            //        Aux = Siguientes(elemento, L, N, S, Primeros);
            //    }
            //    string sig_texto = Resultado_dicc("Siguiente", S);

            //    string Respuesta_final = Rec + "\n" + Amb + "\n" + prim_texto + "\n" + sig_texto;

            //    txtRespuesta.Text = Respuesta_final;


            //}
            //catch(Exception ex)
            //{
            //    string error = ex.Message;
            //    DialogResult result = MessageBox.Show("ERROR AL INGRESAR LAS REGLAS \n " + error);
            //}
        }
    }
}
