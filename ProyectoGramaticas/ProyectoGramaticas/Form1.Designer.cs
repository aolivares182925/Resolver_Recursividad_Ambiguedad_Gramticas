
namespace ProyectoGramaticas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelprograma1 = new System.Windows.Forms.Panel();
            this.panelPrograma = new System.Windows.Forms.Panel();
            this.txtRespuesta = new System.Windows.Forms.RichTextBox();
            this.txtReglas = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotones1 = new System.Windows.Forms.Panel();
            this.btnPrimySig = new System.Windows.Forms.Button();
            this.btnRRecyAmb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelprograma1.SuspendLayout();
            this.panelPrograma.SuspendLayout();
            this.panelBotones1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelprograma1
            // 
            this.panelprograma1.Controls.Add(this.panelPrograma);
            this.panelprograma1.Controls.Add(this.label5);
            this.panelprograma1.Controls.Add(this.label2);
            this.panelprograma1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelprograma1.Location = new System.Drawing.Point(200, 84);
            this.panelprograma1.Name = "panelprograma1";
            this.panelprograma1.Size = new System.Drawing.Size(1000, 616);
            this.panelprograma1.TabIndex = 1;
            // 
            // panelPrograma
            // 
            this.panelPrograma.Controls.Add(this.txtRespuesta);
            this.panelPrograma.Controls.Add(this.txtReglas);
            this.panelPrograma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrograma.Location = new System.Drawing.Point(0, 160);
            this.panelPrograma.Name = "panelPrograma";
            this.panelPrograma.Size = new System.Drawing.Size(1000, 456);
            this.panelPrograma.TabIndex = 1;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtRespuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRespuesta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRespuesta.Location = new System.Drawing.Point(478, 0);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(522, 456);
            this.txtRespuesta.TabIndex = 9;
            this.txtRespuesta.Text = "";
            // 
            // txtReglas
            // 
            this.txtReglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtReglas.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtReglas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReglas.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtReglas.Location = new System.Drawing.Point(0, 0);
            this.txtReglas.Name = "txtReglas";
            this.txtReglas.Size = new System.Drawing.Size(478, 456);
            this.txtReglas.TabIndex = 0;
            this.txtReglas.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reglas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solo se ingresa una regla por linea\r\nDebe de tener el sgt. formato: A -> b * i";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arreglar ambiguedad y recursividad";
            // 
            // panelBotones1
            // 
            this.panelBotones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelBotones1.Controls.Add(this.btnPrimySig);
            this.panelBotones1.Controls.Add(this.btnRRecyAmb);
            this.panelBotones1.Controls.Add(this.panel1);
            this.panelBotones1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones1.Location = new System.Drawing.Point(0, 0);
            this.panelBotones1.Name = "panelBotones1";
            this.panelBotones1.Size = new System.Drawing.Size(200, 700);
            this.panelBotones1.TabIndex = 0;
            // 
            // btnPrimySig
            // 
            this.btnPrimySig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrimySig.FlatAppearance.BorderSize = 0;
            this.btnPrimySig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimySig.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimySig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrimySig.Location = new System.Drawing.Point(0, 207);
            this.btnPrimySig.Name = "btnPrimySig";
            this.btnPrimySig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrimySig.Size = new System.Drawing.Size(200, 65);
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
            this.btnRRecyAmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRRecyAmb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRecyAmb.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRRecyAmb.Location = new System.Drawing.Point(0, 142);
            this.btnRRecyAmb.Name = "btnRRecyAmb";
            this.btnRRecyAmb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRRecyAmb.Size = new System.Drawing.Size(200, 65);
            this.btnRRecyAmb.TabIndex = 4;
            this.btnRRecyAmb.Text = "Recursividad y Ambigüedad";
            this.btnRRecyAmb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRRecyAmb.UseVisualStyleBackColor = true;
            this.btnRRecyAmb.Click += new System.EventHandler(this.btnRRecyAmb_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 142);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1148, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(1102, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelprograma1);
            this.Controls.Add(this.panelBotones1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.panelprograma1.ResumeLayout(false);
            this.panelprograma1.PerformLayout();
            this.panelPrograma.ResumeLayout(false);
            this.panelBotones1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelprograma1;
        private System.Windows.Forms.Panel panelPrograma;
        private System.Windows.Forms.RichTextBox txtReglas;
        private System.Windows.Forms.Panel panelBotones1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtRespuesta;
        private System.Windows.Forms.Button btnPrimySig;
        private System.Windows.Forms.Button btnRRecyAmb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

