namespace Catalogo_Turistico
{
    partial class Form3
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
            this.cmbNombresTuris = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImagenTuri = new System.Windows.Forms.PictureBox();
            this.oflCargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregarTuri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenTuri)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNombresTuris
            // 
            this.cmbNombresTuris.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbNombresTuris.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbNombresTuris.FormattingEnabled = true;
            this.cmbNombresTuris.Location = new System.Drawing.Point(149, 29);
            this.cmbNombresTuris.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombresTuris.Name = "cmbNombresTuris";
            this.cmbNombresTuris.Size = new System.Drawing.Size(273, 25);
            this.cmbNombresTuris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "LugarTurístico: ";
            // 
            // picImagenTuri
            // 
            this.picImagenTuri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagenTuri.Location = new System.Drawing.Point(15, 17);
            this.picImagenTuri.Name = "picImagenTuri";
            this.picImagenTuri.Size = new System.Drawing.Size(155, 148);
            this.picImagenTuri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenTuri.TabIndex = 2;
            this.picImagenTuri.TabStop = false;
            // 
            // oflCargarImagen
            // 
            this.oflCargarImagen.FileName = "Cargar imagen";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Location = new System.Drawing.Point(15, 171);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(155, 28);
            this.btnCargarImagen.TabIndex = 3;
            this.btnCargarImagen.Text = "Cargar Imagen...";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(209, 39);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(194, 126);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnAgregarTuri
            // 
            this.btnAgregarTuri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregarTuri.FlatAppearance.BorderSize = 0;
            this.btnAgregarTuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTuri.Location = new System.Drawing.Point(159, 223);
            this.btnAgregarTuri.Name = "btnAgregarTuri";
            this.btnAgregarTuri.Size = new System.Drawing.Size(99, 49);
            this.btnAgregarTuri.TabIndex = 6;
            this.btnAgregarTuri.Text = "Agregar referencias";
            this.btnAgregarTuri.UseVisualStyleBackColor = false;
            this.btnAgregarTuri.Click += new System.EventHandler(this.btnAgregarTuri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnAgregarTuri);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCargarImagen);
            this.panel1.Controls.Add(this.picImagenTuri);
            this.panel1.Location = new System.Drawing.Point(19, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 287);
            this.panel1.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catalogo_Turistico.Properties.Resources.plantas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNombresTuris);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Agregar imagenes a lugar turístico";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenTuri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNombresTuris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImagenTuri;
        private System.Windows.Forms.OpenFileDialog oflCargarImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregarTuri;
        private System.Windows.Forms.Panel panel1;
    }
}