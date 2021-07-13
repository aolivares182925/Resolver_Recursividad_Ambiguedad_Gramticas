
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
            this.panelprograma1 = new System.Windows.Forms.Panel();
            this.panelPrograma = new System.Windows.Forms.Panel();
            this.txtRespuesta = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReglas = new System.Windows.Forms.RichTextBox();
            this.panelBotones1 = new System.Windows.Forms.Panel();
            this.btnRyA = new System.Windows.Forms.Button();
            this.btnAyR = new System.Windows.Forms.Button();
            this.btnArreglarRecursividad = new System.Windows.Forms.Button();
            this.btnArreglarAmbiguedad = new System.Windows.Forms.Button();
            this.panelprograma1.SuspendLayout();
            this.panelPrograma.SuspendLayout();
            this.panelBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelprograma1
            // 
            this.panelprograma1.Controls.Add(this.panelPrograma);
            this.panelprograma1.Controls.Add(this.panelBotones1);
            this.panelprograma1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprograma1.Location = new System.Drawing.Point(0, 0);
            this.panelprograma1.Name = "panelprograma1";
            this.panelprograma1.Size = new System.Drawing.Size(1181, 548);
            this.panelprograma1.TabIndex = 1;
            // 
            // panelPrograma
            // 
            this.panelPrograma.Controls.Add(this.txtRespuesta);
            this.panelPrograma.Controls.Add(this.label6);
            this.panelPrograma.Controls.Add(this.label5);
            this.panelPrograma.Controls.Add(this.label2);
            this.panelPrograma.Controls.Add(this.label1);
            this.panelPrograma.Controls.Add(this.txtReglas);
            this.panelPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrograma.Location = new System.Drawing.Point(200, 0);
            this.panelPrograma.Name = "panelPrograma";
            this.panelPrograma.Size = new System.Drawing.Size(981, 548);
            this.panelPrograma.TabIndex = 1;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(422, 157);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(521, 366);
            this.txtRespuesta.TabIndex = 9;
            this.txtRespuesta.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Debe de tener el sgu. formato: A -> b * i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reglas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solo se ingresa una regla por linea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arreglar ambiguedad y recursividad";
            // 
            // txtReglas
            // 
            this.txtReglas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReglas.Location = new System.Drawing.Point(6, 157);
            this.txtReglas.Name = "txtReglas";
            this.txtReglas.Size = new System.Drawing.Size(389, 366);
            this.txtReglas.TabIndex = 0;
            this.txtReglas.Text = "";
            // 
            // panelBotones1
            // 
            this.panelBotones1.Controls.Add(this.btnRyA);
            this.panelBotones1.Controls.Add(this.btnAyR);
            this.panelBotones1.Controls.Add(this.btnArreglarRecursividad);
            this.panelBotones1.Controls.Add(this.btnArreglarAmbiguedad);
            this.panelBotones1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones1.Location = new System.Drawing.Point(0, 0);
            this.panelBotones1.Name = "panelBotones1";
            this.panelBotones1.Size = new System.Drawing.Size(200, 548);
            this.panelBotones1.TabIndex = 0;
            // 
            // btnRyA
            // 
            this.btnRyA.Location = new System.Drawing.Point(12, 256);
            this.btnRyA.Name = "btnRyA";
            this.btnRyA.Size = new System.Drawing.Size(182, 55);
            this.btnRyA.TabIndex = 3;
            this.btnRyA.Text = "Recursividad y Ambigüedad";
            this.btnRyA.UseVisualStyleBackColor = true;
            this.btnRyA.Click += new System.EventHandler(this.btnRyA_Click);
            // 
            // btnAyR
            // 
            this.btnAyR.Location = new System.Drawing.Point(12, 191);
            this.btnAyR.Name = "btnAyR";
            this.btnAyR.Size = new System.Drawing.Size(182, 59);
            this.btnAyR.TabIndex = 2;
            this.btnAyR.Text = "Ambigüedad y  Recursividad";
            this.btnAyR.UseVisualStyleBackColor = true;
            this.btnAyR.Click += new System.EventHandler(this.btnAyR_Click);
            // 
            // btnArreglarRecursividad
            // 
            this.btnArreglarRecursividad.Location = new System.Drawing.Point(12, 130);
            this.btnArreglarRecursividad.Name = "btnArreglarRecursividad";
            this.btnArreglarRecursividad.Size = new System.Drawing.Size(182, 55);
            this.btnArreglarRecursividad.TabIndex = 1;
            this.btnArreglarRecursividad.Text = "Recursividad";
            this.btnArreglarRecursividad.UseVisualStyleBackColor = true;
            this.btnArreglarRecursividad.Click += new System.EventHandler(this.btnArreglarRecursividad_Click);
            // 
            // btnArreglarAmbiguedad
            // 
            this.btnArreglarAmbiguedad.Location = new System.Drawing.Point(12, 65);
            this.btnArreglarAmbiguedad.Name = "btnArreglarAmbiguedad";
            this.btnArreglarAmbiguedad.Size = new System.Drawing.Size(182, 59);
            this.btnArreglarAmbiguedad.TabIndex = 0;
            this.btnArreglarAmbiguedad.Text = "Ambigüedad";
            this.btnArreglarAmbiguedad.UseVisualStyleBackColor = true;
            this.btnArreglarAmbiguedad.Click += new System.EventHandler(this.btnArreglarAmbiguedad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 548);
            this.Controls.Add(this.panelprograma1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelprograma1.ResumeLayout(false);
            this.panelPrograma.ResumeLayout(false);
            this.panelPrograma.PerformLayout();
            this.panelBotones1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelprograma1;
        private System.Windows.Forms.Panel panelPrograma;
        private System.Windows.Forms.RichTextBox txtReglas;
        private System.Windows.Forms.Panel panelBotones1;
        private System.Windows.Forms.Button btnArreglarRecursividad;
        private System.Windows.Forms.Button btnArreglarAmbiguedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtRespuesta;
        private System.Windows.Forms.Button btnRyA;
        private System.Windows.Forms.Button btnAyR;
    }
}

