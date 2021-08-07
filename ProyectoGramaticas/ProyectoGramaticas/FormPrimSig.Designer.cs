
namespace ProyectoGramaticas
{
    partial class FormPrimSig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnResolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrograma = new System.Windows.Forms.Panel();
            this.txtRespuesta = new System.Windows.Forms.RichTextBox();
            this.txtReglas = new System.Windows.Forms.RichTextBox();
            this.panelTitulo.SuspendLayout();
            this.panelPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelTitulo.Controls.Add(this.btnResolver);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.label5);
            this.panelTitulo.Controls.Add(this.label2);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 172);
            this.panelTitulo.TabIndex = 0;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnResolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.btnResolver.Location = new System.Drawing.Point(953, 81);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(262, 62);
            this.btnResolver.TabIndex = 12;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Primeros y Siguientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reglas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Solo se ingresa una regla por linea\r\nDebe de tener el sgt. formato: A -> b * i";
            // 
            // panelPrograma
            // 
            this.panelPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelPrograma.Controls.Add(this.txtRespuesta);
            this.panelPrograma.Controls.Add(this.txtReglas);
            this.panelPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrograma.Location = new System.Drawing.Point(0, 172);
            this.panelPrograma.Name = "panelPrograma";
            this.panelPrograma.Size = new System.Drawing.Size(1300, 628);
            this.panelPrograma.TabIndex = 1;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtRespuesta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRespuesta.Location = new System.Drawing.Point(658, 6);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.Size = new System.Drawing.Size(630, 610);
            this.txtRespuesta.TabIndex = 11;
            this.txtRespuesta.Text = "El resultado se mostrara aqui";
            // 
            // txtReglas
            // 
            this.txtReglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtReglas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReglas.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtReglas.Location = new System.Drawing.Point(12, 6);
            this.txtReglas.Name = "txtReglas";
            this.txtReglas.Size = new System.Drawing.Size(630, 610);
            this.txtReglas.TabIndex = 10;
            this.txtReglas.Text = "";
            // 
            // FormPrimSig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panelPrograma);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimSig";
            this.Text = "FormPrimSig";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelPrograma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelPrograma;
        private System.Windows.Forms.RichTextBox txtRespuesta;
        private System.Windows.Forms.RichTextBox txtReglas;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}