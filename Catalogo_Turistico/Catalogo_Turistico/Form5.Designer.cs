namespace Catalogo_Turistico
{
    partial class Form5
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
            this.btnCambiarFoto = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnModificar1 = new System.Windows.Forms.Button();
            this.txtNombreRef = new System.Windows.Forms.TextBox();
            this.listLugaresReferencia = new System.Windows.Forms.ListBox();
            this.picFotoColeccionRef = new System.Windows.Forms.PictureBox();
            this.listNombresTuri = new System.Windows.Forms.ListBox();
            this.oflNuevaFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoColeccionRef)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCambiarFoto.FlatAppearance.BorderSize = 0;
            this.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFoto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiarFoto.Location = new System.Drawing.Point(408, 390);
            this.btnCambiarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.Size = new System.Drawing.Size(351, 38);
            this.btnCambiarFoto.TabIndex = 49;
            this.btnCambiarFoto.Text = "Agregar foto nueva...";
            this.btnCambiarFoto.UseVisualStyleBackColor = false;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEliminar1.FlatAppearance.BorderSize = 0;
            this.btnEliminar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar1.Location = new System.Drawing.Point(585, 436);
            this.btnEliminar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(145, 67);
            this.btnEliminar1.TabIndex = 48;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = false;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(473, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 18);
            this.label13.TabIndex = 47;
            this.label13.Text = "Nombre del lugar de referencia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(84, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 18);
            this.label12.TabIndex = 46;
            this.label12.Text = "Lugares que puedes visitar: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(84, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 18);
            this.label11.TabIndex = 45;
            this.label11.Text = "Lugares turísticos disponibles: ";
            // 
            // btnModificar1
            // 
            this.btnModificar1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnModificar1.FlatAppearance.BorderSize = 0;
            this.btnModificar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar1.Location = new System.Drawing.Point(432, 436);
            this.btnModificar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(145, 67);
            this.btnModificar1.TabIndex = 44;
            this.btnModificar1.Text = "Guardar cambios";
            this.btnModificar1.UseVisualStyleBackColor = false;
            this.btnModificar1.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // txtNombreRef
            // 
            this.txtNombreRef.Location = new System.Drawing.Point(405, 41);
            this.txtNombreRef.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreRef.Name = "txtNombreRef";
            this.txtNombreRef.Size = new System.Drawing.Size(354, 24);
            this.txtNombreRef.TabIndex = 43;
            // 
            // listLugaresReferencia
            // 
            this.listLugaresReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listLugaresReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLugaresReferencia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.listLugaresReferencia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listLugaresReferencia.FormattingEnabled = true;
            this.listLugaresReferencia.ItemHeight = 17;
            this.listLugaresReferencia.Location = new System.Drawing.Point(16, 312);
            this.listLugaresReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.listLugaresReferencia.Name = "listLugaresReferencia";
            this.listLugaresReferencia.ScrollAlwaysVisible = true;
            this.listLugaresReferencia.Size = new System.Drawing.Size(349, 221);
            this.listLugaresReferencia.TabIndex = 42;
            this.listLugaresReferencia.SelectedIndexChanged += new System.EventHandler(this.listLugaresReferencia_SelectedIndexChanged);
            // 
            // picFotoColeccionRef
            // 
            this.picFotoColeccionRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoColeccionRef.Location = new System.Drawing.Point(408, 76);
            this.picFotoColeccionRef.Margin = new System.Windows.Forms.Padding(4);
            this.picFotoColeccionRef.Name = "picFotoColeccionRef";
            this.picFotoColeccionRef.Size = new System.Drawing.Size(351, 306);
            this.picFotoColeccionRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoColeccionRef.TabIndex = 41;
            this.picFotoColeccionRef.TabStop = false;
            // 
            // listNombresTuri
            // 
            this.listNombresTuri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listNombresTuri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listNombresTuri.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.listNombresTuri.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listNombresTuri.FormattingEnabled = true;
            this.listNombresTuri.ItemHeight = 17;
            this.listNombresTuri.Location = new System.Drawing.Point(16, 39);
            this.listNombresTuri.Margin = new System.Windows.Forms.Padding(4);
            this.listNombresTuri.Name = "listNombresTuri";
            this.listNombresTuri.ScrollAlwaysVisible = true;
            this.listNombresTuri.Size = new System.Drawing.Size(349, 221);
            this.listNombresTuri.TabIndex = 40;
            this.listNombresTuri.SelectedIndexChanged += new System.EventHandler(this.listNombresTuri_SelectedIndexChanged);
            // 
            // oflNuevaFoto
            // 
            this.oflNuevaFoto.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Catalogo_Turistico.Properties.Resources.plantas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 550);
            this.Controls.Add(this.btnCambiarFoto);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnModificar1);
            this.Controls.Add(this.txtNombreRef);
            this.Controls.Add(this.listLugaresReferencia);
            this.Controls.Add(this.picFotoColeccionRef);
            this.Controls.Add(this.listNombresTuri);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoColeccionRef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarFoto;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnModificar1;
        private System.Windows.Forms.TextBox txtNombreRef;
        private System.Windows.Forms.ListBox listLugaresReferencia;
        private System.Windows.Forms.PictureBox picFotoColeccionRef;
        private System.Windows.Forms.ListBox listNombresTuri;
        private System.Windows.Forms.OpenFileDialog oflNuevaFoto;
    }
}