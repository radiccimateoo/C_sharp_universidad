namespace TP_Radicci_Mateo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cmdLimpiar = new Button();
            cmdRegistrar = new Button();
            cboOrigen = new ComboBox();
            cboMarca = new ComboBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNroRepuesto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            cmdConsultar = new Button();
            lstDatos = new ListBox();
            radioImportado = new RadioButton();
            radioNacional = new RadioButton();
            cboMarcaConsulta = new ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmdLimpiar);
            groupBox1.Controls.Add(cmdRegistrar);
            groupBox1.Controls.Add(cboOrigen);
            groupBox1.Controls.Add(cboMarca);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtNroRepuesto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Repuestos";
            // 
            // cmdLimpiar
            // 
            cmdLimpiar.Location = new Point(468, 81);
            cmdLimpiar.Name = "cmdLimpiar";
            cmdLimpiar.Size = new Size(75, 38);
            cmdLimpiar.TabIndex = 11;
            cmdLimpiar.Text = "Limpiar";
            cmdLimpiar.UseVisualStyleBackColor = true;
            cmdLimpiar.Click += cmdLimpiar_Click;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(468, 32);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(75, 38);
            cmdRegistrar.TabIndex = 10;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // cboOrigen
            // 
            cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Items.AddRange(new object[] { "N", "I" });
            cboOrigen.Location = new Point(115, 109);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(48, 23);
            cboOrigen.TabIndex = 9;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarca.Location = new Point(115, 69);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(48, 23);
            cboMarca.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(115, 189);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(115, 149);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(289, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // txtNroRepuesto
            // 
            txtNroRepuesto.Location = new Point(115, 29);
            txtNroRepuesto.MaxLength = 6;
            txtNroRepuesto.Name = "txtNroRepuesto";
            txtNroRepuesto.Size = new Size(100, 23);
            txtNroRepuesto.TabIndex = 5;
            txtNroRepuesto.KeyPress += txtNroRepuesto_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 196);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 155);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 114);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Número Repuesto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmdConsultar);
            groupBox2.Controls.Add(lstDatos);
            groupBox2.Controls.Add(radioImportado);
            groupBox2.Controls.Add(radioNacional);
            groupBox2.Controls.Add(cboMarcaConsulta);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(29, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consulta de Repuestos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 64);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 7;
            label7.Text = "Origen";
            // 
            // cmdConsultar
            // 
            cmdConsultar.Location = new Point(468, 27);
            cmdConsultar.Name = "cmdConsultar";
            cmdConsultar.Size = new Size(75, 36);
            cmdConsultar.TabIndex = 6;
            cmdConsultar.Text = "Consultar";
            cmdConsultar.UseVisualStyleBackColor = true;
            cmdConsultar.Click += cmdConsultar_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(48, 94);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(495, 139);
            lstDatos.TabIndex = 5;
            // 
            // radioImportado
            // 
            radioImportado.AutoSize = true;
            radioImportado.Location = new Point(208, 62);
            radioImportado.Name = "radioImportado";
            radioImportado.Size = new Size(81, 19);
            radioImportado.TabIndex = 3;
            radioImportado.TabStop = true;
            radioImportado.Text = "Importado";
            radioImportado.UseVisualStyleBackColor = true;
            // 
            // radioNacional
            // 
            radioNacional.AutoSize = true;
            radioNacional.Location = new Point(115, 62);
            radioNacional.Name = "radioNacional";
            radioNacional.Size = new Size(72, 19);
            radioNacional.TabIndex = 2;
            radioNacional.TabStop = true;
            radioNacional.Text = "Nacional";
            radioNacional.UseVisualStyleBackColor = true;
            // 
            // cboMarcaConsulta
            // 
            cboMarcaConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarcaConsulta.FormattingEnabled = true;
            cboMarcaConsulta.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarcaConsulta.Location = new Point(115, 24);
            cboMarcaConsulta.Name = "cboMarcaConsulta";
            cboMarcaConsulta.Size = new Size(48, 23);
            cboMarcaConsulta.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 27);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 0;
            label6.Text = "Marca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 510);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Auto-Rep";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button cmdLimpiar;
        private Button cmdRegistrar;
        private ComboBox cboOrigen;
        private ComboBox cboMarca;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNroRepuesto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button cmdConsultar;
        private ListBox lstDatos;
        private RadioButton radioImportado;
        private RadioButton radioNacional;
        private ComboBox cboMarcaConsulta;
        private Label label6;
        private Label label7;
    }
}