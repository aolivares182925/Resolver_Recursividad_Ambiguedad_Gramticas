using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaFunciones
{
    public class Metodos
    {
        //----------------Ambiguedad y recursividad------------------
        #region Ambigüedad
        // --------------------AMBIGÜEDAD------------------------------------
        //funcion de existe ambiguedad
        public List<Dictionary<object, object>> ExisteAmbiguedad(List<List<string>> A)
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
        public void SolveAmbiguedad(List<List<string>> A, Dictionary<object, object> Amb, Dictionary<object, object> NotAmb)
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
        public List<Dictionary<string, List<int>>> ExisteRecursion(List<List<string>> A)
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
        public void SolRecursion(List<List<string>> A, Dictionary<string, List<int>> Re, Dictionary<string, List<int>> NotRe)
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
                for (int j = 0; j < val.Value.Count; j++)
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

        // ---------------Funcion para mostrar el resultado -----------
        public string MostrarResultado(List<List<string>> A)
        {
            //variables
            string Respuesta = "";
            for (int i = 0; i < A.Count; i++)
            {
                Respuesta += "R" + i.ToString() + ": \t" + A[i][0].ToString() + " -> " + A[i][1] + " " + A[i][2] + "\n";
                //if (A[i][1] != "")
                //{
                //    Respuesta += "R" + i.ToString() + ": \t" + A[i][0].ToString() + " -> " + A[i][1] + " " + A[i][2] + "\n";
                //}

            }

            return Respuesta;
        }

        #region funciones_resumidas
        public string Ambiguedad(List<List<string>> A)
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
                R += "[ " + llave + " ]" + " : " + x_aux + " ;";
            }
            R += "}";

            string Respuesta = "Existe ambiguedad en: \n" + R + "\n" +
                "-----------------------------\n";
            SolveAmbiguedad(A, Y[0], Y[1]);
            Respuesta += MostrarResultado(A);
            return Respuesta;
        }
        //-------------------------RECURSIVIDAD------------------------------------------
        public string Recursividad(List<List<string>> A)
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

        //----------------PRIMEROS Y SIGUIENTES------------
        #region Primeros
        public void Completar(Dictionary<string, List<string>> CP, List<string> Lista1, List<string> Lista2, string elem)
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

        public Dictionary<string, List<string>> ConjuntosPrimerosI(List<List<string>> A)
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


        public void ObtenerSimbolos(List<List<string>> L, List<List<string>> R)
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
                        if (j != "")
                        {
                            La.Add(j);
                        }
                    }
                }
                L.Add(La);
            }
        }

        //Siguientes
        public List<string> Siguientes(string C, List<List<string>> L, List<string> N, Dictionary<string, List<string>> S, Dictionary<string, List<string>> P)
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
                    for (int i = 1; i <= k.Count()-1; i++)
                    {
                        if (k[i] == C)
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
            }
            return S[C];
        }


        #endregion Siguientes


        //Modulo que obtiene en una lista los simbolos no terminales
        public List<string> FiltrarNT(List<List<string>> L)
        {
            List<string> Lista = new List<string>();
            foreach (List<string> k in L)
            {
                if (!(Lista.Contains(k[0])))
                {
                    Lista.Add(k[0]);
                }
            }
            Lista = new HashSet<string>(Lista).ToList();
            return Lista;
        }

        //Modulo que obtiene en una lista los simbolo terminales
        public List<string> FiltrarT(List<List<string>> L, List<string> NT)
        {
            List<string> T = new List<string>();
            foreach (List<string> k in L)
            {
                foreach (string s in k)
                {
                    if ((!NT.Contains(s)) && (s != "vacio"))
                    {
                        T.Add(s);
                    }
                }
            }
            T = new HashSet<string>(T).ToList();
            return T;
        }

        //tipo puede ser primero o siguiente
        public string Resultado_dicc(string Tipo, Dictionary<string, List<string>> D)
        {
            string R = "";

            foreach (var fila in D)
            {
                R += Tipo + "(" + fila.Key.ToString() + ") = { ";
                string aux = "";
                foreach (string elemento in (List<string>)new HashSet<string>(fila.Value).ToList())
                {
                    aux += elemento + ", ";
                }
                aux = aux.Substring(0, aux.Length - 2);
                R += aux + " " + "}\n";
            }
            return R;
        }

        //Modulo para recuperar la regla necesaria en la tabla
        public static List<string> ReglaGeneradora(List<List<string>> A, Dictionary<string,
            List<string>> ConjPrimeros, List<string> ListNT, string NT, string Simb)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (NT == A[i][0])
                {
                    if (ListNT.Contains(A[i][1]))
                    {
                        if (ConjPrimeros[A[i][1]].Contains(Simb))
                        {
                            return A[i];
                        }

                    }
                    else
                    {
                        if (A[i][1] == Simb)
                        {
                            return A[i];
                        }

                    }
                }

            }
            return new List<string> { };
        }

        //Modulo para llenar la tabla sintactica con los valores necesarios
        public void TablaSintactica(DataGridView DGV, List<List<string>> L,
            Dictionary<string, List<string>> P, List<string> T, List<string> NT)
        {

            int cont = 0;
            string elem;
            while (cont <= NT.Count() - 1)
            {
                string NoTer = DGV.Rows[cont].Cells[0].Value.ToString();
                for (int i = 1; i <= T.Count; i++)
                {
                    string Ter = DGV.Columns[i].HeaderText;

                    if (!P[NoTer].Contains(Ter) && Ter != "$")
                    {
                        continue;
                    }
                    else
                    {
                        List<string> fila = ReglaGeneradora(L, P, NT, NoTer, Ter);
                        elem = ConvertLtoS(fila);
                        DGV.Rows[cont].Cells[i].Value = elem;
                    }
                }
                if (P[NoTer].Contains("vacio"))
                {
                    Dictionary<string, List<string>> S = new Dictionary<string, List<string>>();
                    List<string> Sig = Siguientes(NoTer, L, NT, S, P);
                    for (int i = 0; i < Sig.Count; i++)
                    {
                        string valor = Sig[i];
                        int index = SearchIndex(DGV, valor);
                        if (DGV.Rows[cont].Cells[index].Value.ToString() == "error" || valor == "$")
                        {
                            elem = NoTer + " -> vacio";
                            DGV.Rows[cont].Cells[index].Value = elem;
                        }
                    }
                }
                cont++;
            }
        }

        //Modulo para convertir una lista a string(regla)
        public static string ConvertLtoS(List<string> L)
        {
            string r = "";
            bool F = true;
            if (L.Count > 0)
            {
                foreach (string k in L)
                {
                    if (F)
                    {
                        r += k + " -> ";
                        F = false;
                    }
                    else
                    {
                        r += k + " ";
                    }
                }
                return r;
            }
            else
            {
                return "error";
            }
        }

        static string ConvertLtoS2(List<string> L)
        {
            string r = "";
            if (L.Count > 0)
            {
                foreach (string k in L)
                {
                    r += k + " ";

                }
                return r;
            }
            else
            {
                return "error";
            }
        }

        //Modulo para recuperar el indice de una columna
        static int SearchIndex(DataGridView DGV, string elem)
        {
            int ind = -1;
            for (int i = 0; i < DGV.Columns.Count; i++)
            {
                if (DGV.Columns[i].HeaderText == elem)
                {
                    ind = i;
                    break;
                }
            }
            return ind;
        }

        static int IndexFila(DataGridView DGV, string elem)
        {
            int ind = -1;
            for (int i = 0; i < DGV.Rows.Count - 1; i++)
            {
                if (DGV.Rows[i].Cells[0].Value.ToString() == elem)
                {
                    ind = i;
                    break;
                }
            }
            return ind;
        }
        

        static string getAction(string P, string C, DataGridView DGV)
        {
            int i = IndexFila(DGV, P);
            int j = SearchIndex(DGV, C);
            try
            {
                string temp = DGV.Rows[i].Cells[j].Value.ToString();
                return temp;
            }
            catch (Exception E)
            {
                return "error2";
            }

        }

        public string TablaVerificar(DataGridView DGV, DataGridView DGV2, Stack Cadena,
            Stack Pila)
        {
            string Respuesta = "";
            Pila.Push("$");
            Pila.Push(DGV.Rows[0].Cells[0].Value.ToString());

            List<string> ac = new List<string> { "aa" };
            while (ac[0] != "error" || ac[0] != "exito")
            {
                string p = Pila.Peek().ToString();
                string c = Cadena.Peek().ToString();

                if (p == "$" && c == "$")
                {
                    ac[0] = "exito mi rey";
                    string pila = String.Join("", Pila.ToArray());
                    string cadena = String.Join("", Cadena.ToArray());
                    DGV2.Rows.Add(pila, cadena, ac[0]);
                    Respuesta= "Gramatica sin errores";                    
                    break;
                }
                string accion = getAction(p, c, DGV);
                //MessageBox.Show(accion + " ||| " +"p="+p+"  c="+c);
                string[] Campos = null;
                Campos = accion.Split(new char[] { ' ' });
                ac = Campos.ToList();
                if (ac[0] == "error")
                {
                    string pila = String.Join("", Pila.ToArray());
                    string cadena = String.Join("", Cadena.ToArray());
                    List<string> L = new List<string>();
                    DGV2.Rows.Add(pila, cadena, ConvertLtoS2(ac));
                    //label1.Text = "error mi kong";
                    Respuesta = "Error en la gramatica";
                    break;
                }
                else
                {
                    if (p == c && ac[0] == "error2")
                    {

                        ac[0] = "coincide";
                        string pila = String.Join("", Pila.ToArray());
                        string cadena = String.Join("", Cadena.ToArray());
                        List<string> L = new List<string>();
                        DGV2.Rows.Add(pila, cadena, ConvertLtoS2(ac));
                        Cadena.Pop();
                        Pila.Pop();

                    }
                    else
                    {

                        string v = ac[2];
                        if (v == "vacio")
                        {
                            string pila = String.Join("", Pila.ToArray());
                            string cadena = String.Join("", Cadena.ToArray());
                            DGV2.Rows.Add(pila, cadena, ConvertLtoS2(ac));
                            Pila.Pop();
                        }
                        else
                        {
                            string pila = String.Join("", Pila.ToArray());
                            string cadena = String.Join("", Cadena.ToArray());
                            DGV2.Rows.Add(pila, cadena, ConvertLtoS2(ac));
                            Pila.Pop();
                            List<string> Ge = ac.GetRange(2, ac.Count - 2);
                            Ge.Reverse();
                            foreach (string k in Ge)
                            {
                                if (k != "")
                                {
                                    Pila.Push(k);
                                }
                            }
                        }


                    }
                }
            }
            return Respuesta;
        }
    }
}
