namespace Catalogo_Turistico
{
    partial class Form4
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
            this.cmbLugaresCatalogo = new System.Windows.Forms.ComboBox();
            this.txtReseña = new System.Windows.Forms.TextBox();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreLugar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listNombresReferentes = new System.Windows.Forms.ListBox();
            this.picFotoColeccion = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoColeccion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar lugar: ";
            // 
            // cmbLugaresCatalogo
            // 
            this.cmbLugaresCatalogo.FormattingEnabled = true;
            this.cmbLugaresCatalogo.Location = new System.Drawing.Point(199, 12);
            this.cmbLugaresCatalogo.Name = "cmbLugaresCatalogo";
            this.cmbLugaresCatalogo.Size = new System.Drawing.Size(321, 25);
            this.cmbLugaresCatalogo.TabIndex = 1;
            this.cmbLugaresCatalogo.SelectedIndexChanged += new System.EventHandler(this.cmbLugaresCatalogo_SelectedIndexChanged);
            // 
            // txtReseña
            // 
            this.txtReseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReseña.Location = new System.Drawing.Point(134, 260);
            this.txtReseña.Multiline = true;
            this.txtReseña.Name = "txtReseña";
            this.txtReseña.ReadOnly = true;
            this.txtReseña.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReseña.Size = new System.Drawing.Size(390, 148);
            this.txtReseña.TabIndex = 17;
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIndicaciones.Location = new System.Drawing.Point(134, 87);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.ReadOnly = true;
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicaciones.Size = new System.Drawing.Size(390, 152);
            this.txtIndicaciones.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "minutos.";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Location = new System.Drawing.Point(161, 58);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(48, 17);
            this.txtTiempo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Reseña: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Indicaciones: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiempo aproximado: ";
            // 
            // lblNombreLugar
            // 
            this.lblNombreLugar.AutoSize = true;
            this.lblNombreLugar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F);
            this.lblNombreLugar.Location = new System.Drawing.Point(169, 6);
            this.lblNombreLugar.Name = "lblNombreLugar";
            this.lblNombreLugar.Size = new System.Drawing.Size(156, 45);
            this.lblNombreLugar.TabIndex = 9;
            this.lblNombreLugar.Text = "Titulo...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtReseña);
            this.panel1.Controls.Add(this.txtIndicaciones);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTiempo);
            this.panel1.Controls.Add(this.lblNombreLugar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 422);
            this.panel1.TabIndex = 22;
            // 
            // listNombresReferentes
            // 
            this.listNombresReferentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listNombresReferentes.FormattingEnabled = true;
            this.listNombresReferentes.ItemHeight = 17;
            this.listNombresReferentes.Location = new System.Drawing.Point(583, 42);
            this.listNombresReferentes.Name = "listNombresReferentes";
            this.listNombresReferentes.ScrollAlwaysVisible = true;
            this.listNombresReferentes.Size = new System.Drawing.Size(263, 174);
            this.listNombresReferentes.TabIndex = 18;
            this.listNombresReferentes.SelectedIndexChanged += new System.EventHandler(this.listNombresReferentes_SelectedIndexChanged);
            // 
            // picFotoColeccion
            // 
            this.picFotoColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picFotoColeccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoColeccion.Location = new System.Drawing.Point(583, 218);
            this.picFotoColeccion.Name = "picFotoColeccion";
            this.picFotoColeccion.Size = new System.Drawing.Size(263, 234);
            this.picFotoColeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoColeccion.TabIndex = 23;
            this.picFotoColeccion.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.picFotoColeccion);
            this.panel2.Controls.Add(this.listNombresReferentes);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(4, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 462);
            this.panel2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sitios que puedes visitar";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catalogo_Turistico.Properties.Resources.plantas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbLugaresCatalogo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Mirar lugares disponibles";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoColeccion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLugaresCatalogo;
        private System.Windows.Forms.TextBox txtReseña;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreLugar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listNombresReferentes;
        private System.Windows.Forms.PictureBox picFotoColeccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}