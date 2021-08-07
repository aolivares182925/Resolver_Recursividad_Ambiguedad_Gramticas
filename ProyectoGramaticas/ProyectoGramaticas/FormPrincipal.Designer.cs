
namespace ProyectoGramaticas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotones1 = new System.Windows.Forms.Panel();
            this.btnTablaAnalisis = new System.Windows.Forms.Button();
            this.btnPrimySig = new System.Windows.Forms.Button();
            this.btnRRecyAmb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelBotones1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox3);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContenedor.Location = new System.Drawing.Point(211, 100);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1289, 800);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprograma1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(559, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones con gramaticas";
            // 
            // panelBotones1
            // 
            this.panelBotones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelBotones1.Controls.Add(this.btnTablaAnalisis);
            this.panelBotones1.Controls.Add(this.btnPrimySig);
            this.panelBotones1.Controls.Add(this.btnRRecyAmb);
            this.panelBotones1.Controls.Add(this.panel1);
            this.panelBotones1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones1.Location = new System.Drawing.Point(0, 0);
            this.panelBotones1.Name = "panelBotones1";
            this.panelBotones1.Size = new System.Drawing.Size(211, 900);
            this.panelBotones1.TabIndex = 0;
            // 
            // btnTablaAnalisis
            // 
            this.btnTablaAnalisis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablaAnalisis.FlatAppearance.BorderSize = 0;
            this.btnTablaAnalisis.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnTablaAnalisis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnTablaAnalisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.btnTablaAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablaAnalisis.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablaAnalisis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTablaAnalisis.Location = new System.Drawing.Point(0, 330);
            this.btnTablaAnalisis.Name = "btnTablaAnalisis";
            this.btnTablaAnalisis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTablaAnalisis.Size = new System.Drawing.Size(211, 65);
            this.btnTablaAnalisis.TabIndex = 6;
            this.btnTablaAnalisis.Text = "Tabla de Analisis";
            this.btnTablaAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablaAnalisis.UseVisualStyleBackColor = true;
            this.btnTablaAnalisis.Click += new System.EventHandler(this.btnTablaAnalisis_Click);
            // 
            // btnPrimySig
            // 
            this.btnPrimySig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrimySig.FlatAppearance.BorderSize = 0;
            this.btnPrimySig.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPrimySig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnPrimySig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.btnPrimySig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimySig.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimySig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrimySig.Location = new System.Drawing.Point(0, 265);
            this.btnPrimySig.Name = "btnPrimySig";
            this.btnPrimySig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrimySig.Size = new System.Drawing.Size(211, 65);
            this.btnPrimySig.TabIndex = 5;
            this.btnPrimySig.Text = "Primeros y Siguientes";
            this.btnPrimySig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimySig.UseVisualStyleBackColor = true;
            this.btnPrimySig.Click += new System.EventHandler(this.btnPrimySig_Click);
            // 
            // btnRRecyAmb
            // 
            this.btnRRecyAmb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRRecyAmb.FlatAppearance.BorderSize = 0;
            this.btnRRecyAmb.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnRRecyAmb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRRecyAmb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.btnRRecyAmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRRecyAmb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRecyAmb.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRRecyAmb.Location = new System.Drawing.Point(0, 200);
            this.btnRRecyAmb.Name = "btnRRecyAmb";
            this.btnRRecyAmb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRRecyAmb.Size = new System.Drawing.Size(211, 65);
            this.btnRRecyAmb.TabIndex = 4;
            this.btnRRecyAmb.Text = "Recursividad y Ambigüedad";
            this.btnRRecyAmb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRRecyAmb.UseVisualStyleBackColor = true;
            this.btnRRecyAmb.Click += new System.EventHandler(this.btnRRecyAmb_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 200);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1402, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(475, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(172, 156);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBotones1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBotones1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBotones1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrimySig;
        private System.Windows.Forms.Button btnRRecyAmb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTablaAnalisis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

