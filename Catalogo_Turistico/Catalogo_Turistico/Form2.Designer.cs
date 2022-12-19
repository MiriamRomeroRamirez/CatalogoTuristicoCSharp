namespace Catalogo_Turistico
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreLugar = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.txtReseña = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFormularioFotos = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cmbNombresTuris = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModifiColec = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtResenaRecu = new System.Windows.Forms.TextBox();
            this.txtIndicacionesRecu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTiempoRecu = new System.Windows.Forms.TextBox();
            this.txtNombreRecu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo aproximado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indicaciones: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reseña: ";
            // 
            // txtNombreLugar
            // 
            this.txtNombreLugar.Location = new System.Drawing.Point(133, 32);
            this.txtNombreLugar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLugar.Name = "txtNombreLugar";
            this.txtNombreLugar.Size = new System.Drawing.Size(453, 24);
            this.txtNombreLugar.TabIndex = 4;
            this.txtNombreLugar.TextChanged += new System.EventHandler(this.txtNombreLugar_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(225, 83);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(63, 24);
            this.txtTiempo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "minutos.";
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Location = new System.Drawing.Point(189, 126);
            this.txtIndicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicaciones.Size = new System.Drawing.Size(397, 115);
            this.txtIndicaciones.TabIndex = 7;
            // 
            // txtReseña
            // 
            this.txtReseña.Location = new System.Drawing.Point(189, 250);
            this.txtReseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtReseña.Multiline = true;
            this.txtReseña.Name = "txtReseña";
            this.txtReseña.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReseña.Size = new System.Drawing.Size(397, 115);
            this.txtReseña.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnFormularioFotos);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.txtReseña);
            this.groupBox1.Controls.Add(this.txtIndicaciones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTiempo);
            this.groupBox1.Controls.Add(this.txtNombreLugar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(659, 462);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del lugar turístico: ";
            // 
            // btnFormularioFotos
            // 
            this.btnFormularioFotos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFormularioFotos.FlatAppearance.BorderSize = 0;
            this.btnFormularioFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormularioFotos.Location = new System.Drawing.Point(515, 390);
            this.btnFormularioFotos.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormularioFotos.Name = "btnFormularioFotos";
            this.btnFormularioFotos.Size = new System.Drawing.Size(136, 72);
            this.btnFormularioFotos.TabIndex = 12;
            this.btnFormularioFotos.Text = "Agregar \r\ncolección";
            this.btnFormularioFotos.UseVisualStyleBackColor = false;
            this.btnFormularioFotos.Click += new System.EventHandler(this.btnFormularioFotos_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Location = new System.Drawing.Point(267, 373);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(136, 48);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Dar de alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cmbNombresTuris
            // 
            this.cmbNombresTuris.FormattingEnabled = true;
            this.cmbNombresTuris.Location = new System.Drawing.Point(23, 20);
            this.cmbNombresTuris.Margin = new System.Windows.Forms.Padding(5);
            this.cmbNombresTuris.Name = "cmbNombresTuris";
            this.cmbNombresTuris.Size = new System.Drawing.Size(415, 25);
            this.cmbNombresTuris.TabIndex = 10;
            this.cmbNombresTuris.SelectedIndexChanged += new System.EventHandler(this.cmbNombresTuris_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(448, 8);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(136, 48);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar nombres lugares";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(567, 531);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(136, 72);
            this.btnInicio.TabIndex = 26;
            this.btnInicio.Text = "Mirar catálogo";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 511);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(679, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Lugares Turisticos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnModifiColec);
            this.tabPage2.Controls.Add(this.btnModificar);
            this.tabPage2.Controls.Add(this.txtResenaRecu);
            this.tabPage2.Controls.Add(this.txtIndicacionesRecu);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtTiempoRecu);
            this.tabPage2.Controls.Add(this.txtNombreRecu);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnMostrar);
            this.tabPage2.Controls.Add(this.cmbNombresTuris);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(679, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar o eliminar Lugares";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(342, 418);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 48);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar lugar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModifiColec
            // 
            this.btnModifiColec.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnModifiColec.FlatAppearance.BorderSize = 0;
            this.btnModifiColec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifiColec.Location = new System.Drawing.Point(568, 418);
            this.btnModifiColec.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifiColec.Name = "btnModifiColec";
            this.btnModifiColec.Size = new System.Drawing.Size(103, 54);
            this.btnModifiColec.TabIndex = 37;
            this.btnModifiColec.Text = "Modificar \r\ncolección";
            this.btnModifiColec.UseVisualStyleBackColor = false;
            this.btnModifiColec.Click += new System.EventHandler(this.btnModifiColec_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(183, 418);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 48);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Guardar cambios";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtResenaRecu
            // 
            this.txtResenaRecu.Location = new System.Drawing.Point(183, 297);
            this.txtResenaRecu.Margin = new System.Windows.Forms.Padding(4);
            this.txtResenaRecu.Multiline = true;
            this.txtResenaRecu.Name = "txtResenaRecu";
            this.txtResenaRecu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResenaRecu.Size = new System.Drawing.Size(397, 115);
            this.txtResenaRecu.TabIndex = 35;
            // 
            // txtIndicacionesRecu
            // 
            this.txtIndicacionesRecu.Location = new System.Drawing.Point(183, 173);
            this.txtIndicacionesRecu.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndicacionesRecu.Multiline = true;
            this.txtIndicacionesRecu.Name = "txtIndicacionesRecu";
            this.txtIndicacionesRecu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicacionesRecu.Size = new System.Drawing.Size(397, 115);
            this.txtIndicacionesRecu.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "minutos.";
            // 
            // txtTiempoRecu
            // 
            this.txtTiempoRecu.Location = new System.Drawing.Point(219, 129);
            this.txtTiempoRecu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoRecu.Name = "txtTiempoRecu";
            this.txtTiempoRecu.Size = new System.Drawing.Size(63, 24);
            this.txtTiempoRecu.TabIndex = 32;
            // 
            // txtNombreRecu
            // 
            this.txtNombreRecu.Location = new System.Drawing.Point(127, 78);
            this.txtNombreRecu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRecu.Name = "txtNombreRecu";
            this.txtNombreRecu.Size = new System.Drawing.Size(453, 24);
            this.txtNombreRecu.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 301);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Reseña: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Indicaciones: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tiempo aproximado: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nombre: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catalogo_Turistico.Properties.Resources.plantas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 607);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Registrar lugar turístico";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreLugar;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.TextBox txtReseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbNombresTuris;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnFormularioFotos;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnModifiColec;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtResenaRecu;
        private System.Windows.Forms.TextBox txtIndicacionesRecu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTiempoRecu;
        private System.Windows.Forms.TextBox txtNombreRecu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminar;
    }
}