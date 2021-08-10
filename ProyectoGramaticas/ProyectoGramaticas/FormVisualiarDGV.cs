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
    public partial class FormVisualiarDGV : Form
    {
        Metodos M = new Metodos();
        public FormVisualiarDGV()
        {
            InitializeComponent();

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //{
            //    Application.OpenForms[i].Close();
            //}
        }

        private void FormVisualiarDGV_Load(object sender, EventArgs e)
        {

            

        }

        #region mover ventana
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion mover ventana

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
