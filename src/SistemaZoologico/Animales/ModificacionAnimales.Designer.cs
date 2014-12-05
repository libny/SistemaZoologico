namespace SistemaZoologico.Animales
{
    partial class ModificacionAnimales
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioSalvaje = new System.Windows.Forms.RadioButton();
            this.radioCautiverio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFechaNa = new System.Windows.Forms.DateTimePicker();
            this.dateFechaIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combEspecie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 28;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioSalvaje
            // 
            this.radioSalvaje.AutoSize = true;
            this.radioSalvaje.Location = new System.Drawing.Point(183, 190);
            this.radioSalvaje.Name = "radioSalvaje";
            this.radioSalvaje.Size = new System.Drawing.Size(60, 17);
            this.radioSalvaje.TabIndex = 27;
            this.radioSalvaje.TabStop = true;
            this.radioSalvaje.Text = "Salvaje";
            this.radioSalvaje.UseVisualStyleBackColor = true;
            // 
            // radioCautiverio
            // 
            this.radioCautiverio.AutoSize = true;
            this.radioCautiverio.Location = new System.Drawing.Point(50, 190);
            this.radioCautiverio.Name = "radioCautiverio";
            this.radioCautiverio.Size = new System.Drawing.Size(72, 17);
            this.radioCautiverio.TabIndex = 26;
            this.radioCautiverio.TabStop = true;
            this.radioCautiverio.Text = "Cautiverio";
            this.radioCautiverio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Origen de Animal";
            // 
            // dateFechaNa
            // 
            this.dateFechaNa.Location = new System.Drawing.Point(130, 130);
            this.dateFechaNa.Name = "dateFechaNa";
            this.dateFechaNa.Size = new System.Drawing.Size(100, 20);
            this.dateFechaNa.TabIndex = 24;
            // 
            // dateFechaIn
            // 
            this.dateFechaIn.Location = new System.Drawing.Point(130, 98);
            this.dateFechaIn.Name = "dateFechaIn";
            this.dateFechaIn.Size = new System.Drawing.Size(103, 20);
            this.dateFechaIn.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // combEspecie
            // 
            this.combEspecie.DisplayMember = "Nombre";
            this.combEspecie.FormattingEnabled = true;
            this.combEspecie.Location = new System.Drawing.Point(77, 68);
            this.combEspecie.Name = "combEspecie";
            this.combEspecie.Size = new System.Drawing.Size(88, 21);
            this.combEspecie.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Especie";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(77, 42);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(58, 20);
            this.numEdad.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Edad";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(77, 13);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(191, 20);
            this.textNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // ModificacionAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioSalvaje);
            this.Controls.Add(this.radioCautiverio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateFechaNa);
            this.Controls.Add(this.dateFechaIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combEspecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionAnimales";
            this.Text = "ModificacionAnimales";
            this.Load += new System.EventHandler(this.ModificacionAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioSalvaje;
        private System.Windows.Forms.RadioButton radioCautiverio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFechaNa;
        private System.Windows.Forms.DateTimePicker dateFechaIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
    }
}