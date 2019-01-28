namespace PeluqueriaNacho
{
    partial class TurnoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFemeninoRapido = new System.Windows.Forms.Button();
            this.buttonMaculinoRapido = new System.Windows.Forms.Button();
            this.buttonIndefinido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonSI = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.comboBoxMinutos = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para el Día:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "a la Hora:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cliente rapido";
            // 
            // buttonFemeninoRapido
            // 
            this.buttonFemeninoRapido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFemeninoRapido.Location = new System.Drawing.Point(515, 151);
            this.buttonFemeninoRapido.Name = "buttonFemeninoRapido";
            this.buttonFemeninoRapido.Size = new System.Drawing.Size(104, 23);
            this.buttonFemeninoRapido.TabIndex = 33;
            this.buttonFemeninoRapido.Text = "Femenina";
            this.buttonFemeninoRapido.UseVisualStyleBackColor = true;
            this.buttonFemeninoRapido.Click += new System.EventHandler(this.buttonFemeninoRapido_Click);
            // 
            // buttonMaculinoRapido
            // 
            this.buttonMaculinoRapido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMaculinoRapido.Location = new System.Drawing.Point(405, 151);
            this.buttonMaculinoRapido.Name = "buttonMaculinoRapido";
            this.buttonMaculinoRapido.Size = new System.Drawing.Size(104, 23);
            this.buttonMaculinoRapido.TabIndex = 32;
            this.buttonMaculinoRapido.Text = "Masculino";
            this.buttonMaculinoRapido.UseVisualStyleBackColor = true;
            this.buttonMaculinoRapido.Click += new System.EventHandler(this.buttonMaculinoRapido_Click);
            // 
            // buttonIndefinido
            // 
            this.buttonIndefinido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndefinido.Location = new System.Drawing.Point(222, 290);
            this.buttonIndefinido.Name = "buttonIndefinido";
            this.buttonIndefinido.Size = new System.Drawing.Size(396, 22);
            this.buttonIndefinido.TabIndex = 27;
            this.buttonIndefinido.Text = "Indefinido";
            this.buttonIndefinido.UseVisualStyleBackColor = true;
            this.buttonIndefinido.Click += new System.EventHandler(this.buttonIndefinido_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Otros";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(401, 263);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(217, 21);
            this.comboBoxProductos.TabIndex = 30;
            this.comboBoxProductos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductos_SelectionChangeCommitted);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscar.Location = new System.Drawing.Point(222, 179);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(399, 31);
            this.buttonBuscar.TabIndex = 24;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Location = new System.Drawing.Point(222, 153);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(177, 20);
            this.textBoxCliente.TabIndex = 23;
            this.textBoxCliente.TextChanged += new System.EventHandler(this.textBoxCliente_TextChanged);
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxProducto.Enabled = false;
            this.textBoxProducto.Location = new System.Drawing.Point(222, 263);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(173, 20);
            this.textBoxProducto.TabIndex = 26;
            this.textBoxProducto.TextChanged += new System.EventHandler(this.textBoxProducto_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cliente:";
            // 
            // radioButtonSI
            // 
            this.radioButtonSI.AutoSize = true;
            this.radioButtonSI.Location = new System.Drawing.Point(222, 354);
            this.radioButtonSI.Name = "radioButtonSI";
            this.radioButtonSI.Size = new System.Drawing.Size(35, 17);
            this.radioButtonSI.TabIndex = 35;
            this.radioButtonSI.Text = "SI";
            this.radioButtonSI.UseVisualStyleBackColor = true;
            this.radioButtonSI.CheckedChanged += new System.EventHandler(this.radioButtonSI_CheckedChanged);
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Checked = true;
            this.radioButtonNO.Location = new System.Drawing.Point(281, 354);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNO.TabIndex = 36;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Señado:";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(437, 348);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 38;
            this.textBoxMonto.Visible = false;
            // 
            // labelMonto
            // 
            this.labelMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(346, 348);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(85, 23);
            this.labelMonto.TabIndex = 39;
            this.labelMonto.Text = "Monto:";
            this.labelMonto.Visible = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(97, 415);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(565, 41);
            this.buttonAceptar.TabIndex = 40;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBoxMinutos
            // 
            this.comboBoxMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutos.FormattingEnabled = true;
            this.comboBoxMinutos.Items.AddRange(new object[] {
            "00",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBoxMinutos.Location = new System.Drawing.Point(598, 69);
            this.comboBoxMinutos.Name = "comboBoxMinutos";
            this.comboBoxMinutos.Size = new System.Drawing.Size(42, 21);
            this.comboBoxMinutos.TabIndex = 41;
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxHora.Location = new System.Drawing.Point(530, 69);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(42, 21);
            this.comboBoxHora.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = ":";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.Location = new System.Drawing.Point(565, 12);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(146, 23);
            this.buttonCerrar.TabIndex = 44;
            this.buttonCerrar.Text = "Cancelar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // TurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 468);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.comboBoxMinutos);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonNO);
            this.Controls.Add(this.radioButtonSI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFemeninoRapido);
            this.Controls.Add(this.buttonMaculinoRapido);
            this.Controls.Add(this.buttonIndefinido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProductos);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.textBoxProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "TurnoForm";
            this.Text = "Peluqueria Jose Ignacio Nuñez - Turnos";
            this.Load += new System.EventHandler(this.TurnoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFemeninoRapido;
        private System.Windows.Forms.Button buttonMaculinoRapido;
        private System.Windows.Forms.Button buttonIndefinido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonSI;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxMinutos;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCerrar;
    }
}