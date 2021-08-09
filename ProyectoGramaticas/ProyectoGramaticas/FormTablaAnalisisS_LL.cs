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
        private DataTable DatosTabla = new DataTable();

        public FormTablaAnalisisS_LL()
        {
            InitializeComponent();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnResolver_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");

            DataRow row = dt.NewRow();
            row["Codigo"] = "1";
            row["Nombre"] = "Aler";
            row["Descripcion"] = "Aler2";
            row["Cantidad"] = "lñkfkjsa";
            row["Precio"] = "15";
            dt.Rows.Add(row);

            DatosTabla = dt;
            DGV1.DataSource = dt;
            DGV1.Update();

            txtRespuesta.Text = "Hola";
        }

        private void FormTablaAnalisisS_LL_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnExpandirDGV, "Expandir tabla");
        }

        private void btnExpandirDGV_Click(object sender, EventArgs e)
        {
            FormVisualiarDGV ver = new FormVisualiarDGV();

            ver.DatosTabla = this.DatosTabla;

            ver.Show();

        }
    }
}
