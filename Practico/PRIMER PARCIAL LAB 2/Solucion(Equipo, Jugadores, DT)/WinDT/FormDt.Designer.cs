namespace WinDT
{
    partial class FormDt
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
            this.lblNombreDT = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellidoDT = new System.Windows.Forms.Label();
            this.lblEdadDT = new System.Windows.Forms.Label();
            this.lblDniDT = new System.Windows.Forms.Label();
            this.lblExperienciaDT = new System.Windows.Forms.Label();
            this.numUDDni = new System.Windows.Forms.NumericUpDown();
            this.numUDExpericencia = new System.Windows.Forms.NumericUpDown();
            this.numUDEdad = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblAltaDni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDExpericencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreDT
            // 
            this.lblNombreDT.AutoSize = true;
            this.lblNombreDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDT.Location = new System.Drawing.Point(23, 39);
            this.lblNombreDT.Name = "lblNombreDT";
            this.lblNombreDT.Size = new System.Drawing.Size(57, 16);
            this.lblNombreDT.TabIndex = 0;
            this.lblNombreDT.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Roberto";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(210, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.Text = "Gonzales";
            // 
            // lblApellidoDT
            // 
            this.lblApellidoDT.AutoSize = true;
            this.lblApellidoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoDT.Location = new System.Drawing.Point(23, 65);
            this.lblApellidoDT.Name = "lblApellidoDT";
            this.lblApellidoDT.Size = new System.Drawing.Size(58, 16);
            this.lblApellidoDT.TabIndex = 6;
            this.lblApellidoDT.Text = "Apellido";
            // 
            // lblEdadDT
            // 
            this.lblEdadDT.AutoSize = true;
            this.lblEdadDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadDT.Location = new System.Drawing.Point(23, 91);
            this.lblEdadDT.Name = "lblEdadDT";
            this.lblEdadDT.Size = new System.Drawing.Size(41, 16);
            this.lblEdadDT.TabIndex = 8;
            this.lblEdadDT.Text = "Edad";
            // 
            // lblDniDT
            // 
            this.lblDniDT.AutoSize = true;
            this.lblDniDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniDT.Location = new System.Drawing.Point(23, 117);
            this.lblDniDT.Name = "lblDniDT";
            this.lblDniDT.Size = new System.Drawing.Size(28, 16);
            this.lblDniDT.TabIndex = 10;
            this.lblDniDT.Text = "Dni";
            // 
            // lblExperienciaDT
            // 
            this.lblExperienciaDT.AutoSize = true;
            this.lblExperienciaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienciaDT.Location = new System.Drawing.Point(23, 143);
            this.lblExperienciaDT.Name = "lblExperienciaDT";
            this.lblExperienciaDT.Size = new System.Drawing.Size(79, 16);
            this.lblExperienciaDT.TabIndex = 12;
            this.lblExperienciaDT.Text = "Experiencia";
            // 
            // numUDDni
            // 
            this.numUDDni.Location = new System.Drawing.Point(103, 117);
            this.numUDDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUDDni.Name = "numUDDni";
            this.numUDDni.Size = new System.Drawing.Size(210, 20);
            this.numUDDni.TabIndex = 13;
            this.numUDDni.Value = new decimal(new int[] {
            8332112,
            0,
            0,
            0});
            // 
            // numUDExpericencia
            // 
            this.numUDExpericencia.Location = new System.Drawing.Point(103, 143);
            this.numUDExpericencia.Name = "numUDExpericencia";
            this.numUDExpericencia.Size = new System.Drawing.Size(210, 20);
            this.numUDExpericencia.TabIndex = 14;
            this.numUDExpericencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numUDEdad
            // 
            this.numUDEdad.Location = new System.Drawing.Point(103, 91);
            this.numUDEdad.Name = "numUDEdad";
            this.numUDEdad.Size = new System.Drawing.Size(210, 20);
            this.numUDEdad.TabIndex = 15;
            this.numUDEdad.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(13, 187);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(155, 56);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(169, 187);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(155, 56);
            this.btnValidar.TabIndex = 17;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblAltaDni
            // 
            this.lblAltaDni.AutoSize = true;
            this.lblAltaDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDni.Location = new System.Drawing.Point(130, 9);
            this.lblAltaDni.Name = "lblAltaDni";
            this.lblAltaDni.Size = new System.Drawing.Size(74, 18);
            this.lblAltaDni.TabIndex = 18;
            this.lblAltaDni.Text = "ALTA DT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 259);
            this.Controls.Add(this.lblAltaDni);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.numUDEdad);
            this.Controls.Add(this.numUDExpericencia);
            this.Controls.Add(this.numUDDni);
            this.Controls.Add(this.lblExperienciaDT);
            this.Controls.Add(this.lblDniDT);
            this.Controls.Add(this.lblEdadDT);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellidoDT);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.numUDDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDExpericencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDT;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellidoDT;
        private System.Windows.Forms.Label lblEdadDT;
        private System.Windows.Forms.Label lblDniDT;
        private System.Windows.Forms.Label lblExperienciaDT;
        private System.Windows.Forms.NumericUpDown numUDDni;
        private System.Windows.Forms.NumericUpDown numUDExpericencia;
        private System.Windows.Forms.NumericUpDown numUDEdad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblAltaDni;
    }
}

