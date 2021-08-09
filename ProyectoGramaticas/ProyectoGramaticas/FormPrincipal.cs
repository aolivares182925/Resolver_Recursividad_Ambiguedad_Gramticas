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

        private Form activeForm = null;
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

        //Funciones extra
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = ChildForm;

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(ChildForm);
            panelContenedor.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void resetColors()
        {

        }
        private void btnRRecyAmb_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAmbRec());
            btnRRecyAmb.BackColor = Color.FromArgb(32, 30, 45);
            btnPrimySig.BackColor = Color.FromArgb(11, 7, 17);
            btnTablaAnalisis.BackColor = Color.FromArgb(11, 7, 17);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //{
            //    Application.OpenForms[i].Close();
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPrimySig_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrimSig());
            btnPrimySig.BackColor = Color.FromArgb(32, 30, 45);
            btnRRecyAmb.BackColor = Color.FromArgb(11, 7, 17);
            btnTablaAnalisis.BackColor = Color.FromArgb(11, 7, 17);


        }

        private void panelprograma1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTablaAnalisis_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTablaAnalisisS_LL());
            btnTablaAnalisis.BackColor = Color.FromArgb(32, 30, 45);
            btnPrimySig.BackColor = Color.FromArgb(11, 7, 17);
            btnRRecyAmb.BackColor = Color.FromArgb(11, 7, 17);
        }
    }
}
