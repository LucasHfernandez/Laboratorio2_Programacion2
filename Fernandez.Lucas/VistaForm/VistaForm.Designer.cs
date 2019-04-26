namespace VistaForm
{
    partial class VistaForm
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbExp = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.nUpDownDni = new System.Windows.Forms.NumericUpDown();
            this.nUpDownExp = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(36, 38);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(36, 84);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(36, 130);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(36, 180);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(26, 13);
            this.lbDni.TabIndex = 3;
            this.lbDni.Text = "DNI";
            // 
            // lbExp
            // 
            this.lbExp.AutoSize = true;
            this.lbExp.Location = new System.Drawing.Point(36, 230);
            this.lbExp.Name = "lbExp";
            this.lbExp.Size = new System.Drawing.Size(62, 13);
            this.lbExp.TabIndex = 4;
            this.lbExp.Text = "Experiencia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // nUpDownEdad
            // 
            this.nUpDownEdad.Location = new System.Drawing.Point(104, 130);
            this.nUpDownEdad.Name = "nUpDownEdad";
            this.nUpDownEdad.Size = new System.Drawing.Size(120, 20);
            this.nUpDownEdad.TabIndex = 7;
            // 
            // nUpDownDni
            // 
            this.nUpDownDni.Location = new System.Drawing.Point(104, 180);
            this.nUpDownDni.Name = "nUpDownDni";
            this.nUpDownDni.Size = new System.Drawing.Size(120, 20);
            this.nUpDownDni.TabIndex = 8;
            // 
            // nUpDownExp
            // 
            this.nUpDownExp.Location = new System.Drawing.Point(104, 230);
            this.nUpDownExp.Name = "nUpDownExp";
            this.nUpDownExp.Size = new System.Drawing.Size(120, 20);
            this.nUpDownExp.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(39, 287);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(175, 287);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // VistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 351);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.nUpDownExp);
            this.Controls.Add(this.nUpDownDni);
            this.Controls.Add(this.nUpDownEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbExp);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Name = "VistaForm";
            this.Text = "VistaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbExp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nUpDownEdad;
        private System.Windows.Forms.NumericUpDown nUpDownDni;
        private System.Windows.Forms.NumericUpDown nUpDownExp;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
    }
}