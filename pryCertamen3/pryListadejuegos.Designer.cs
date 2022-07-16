namespace pryCertamen3
{
    partial class pryListadejuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pryListadejuegos));
            this.label2 = new System.Windows.Forms.Label();
            this.txbCantidad2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.ltbOrdenar = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.dgvMostrar1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.Nombre_de_Juego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_jugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(183, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista de juegos";
            // 
            // txbCantidad2
            // 
            this.txbCantidad2.BackColor = System.Drawing.Color.PapayaWhip;
            this.txbCantidad2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCantidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad2.Location = new System.Drawing.Point(197, 631);
            this.txbCantidad2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCantidad2.Multiline = true;
            this.txbCantidad2.Name = "txbCantidad2";
            this.txbCantidad2.Size = new System.Drawing.Size(61, 48);
            this.txbCantidad2.TabIndex = 15;
            this.txbCantidad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCantidad2.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(697, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(1221, 700);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 52);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(725, 477);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 52);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbActualizar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(64, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(599, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txbActualizar
            // 
            this.txbActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbActualizar.Location = new System.Drawing.Point(23, 23);
            this.txbActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbActualizar.Multiline = true;
            this.txbActualizar.Name = "txbActualizar";
            this.txbActualizar.Size = new System.Drawing.Size(359, 43);
            this.txbActualizar.TabIndex = 2;
            this.txbActualizar.TextChanged += new System.EventHandler(this.txbActualizar_TextChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(425, 23);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(165, 62);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar N° de jugadores";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(64, 270);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.Size = new System.Drawing.Size(599, 334);
            this.dgvMostrar.TabIndex = 10;
            // 
            // ltbOrdenar
            // 
            this.ltbOrdenar.BackColor = System.Drawing.Color.Bisque;
            this.ltbOrdenar.FormattingEnabled = true;
            this.ltbOrdenar.ItemHeight = 16;
            this.ltbOrdenar.Location = new System.Drawing.Point(899, 262);
            this.ltbOrdenar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltbOrdenar.Name = "ltbOrdenar";
            this.ltbOrdenar.Size = new System.Drawing.Size(307, 340);
            this.ltbOrdenar.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(899, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVerLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerLista.Location = new System.Drawing.Point(725, 356);
            this.btnVerLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(125, 52);
            this.btnVerLista.TabIndex = 22;
            this.btnVerLista.Text = "Ver Lista";
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // dgvMostrar1
            // 
            this.dgvMostrar1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_de_Juego,
            this.Cantidad_jugadores});
            this.dgvMostrar1.Location = new System.Drawing.Point(87, 293);
            this.dgvMostrar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrar1.Name = "dgvMostrar1";
            this.dgvMostrar1.RowHeadersWidth = 51;
            this.dgvMostrar1.Size = new System.Drawing.Size(544, 283);
            this.dgvMostrar1.TabIndex = 23;
            this.dgvMostrar1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar1_CellContentClick);
            this.dgvMostrar1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar1_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(860, 610);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Podio de los juegos más y menos jugados";
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.LightBlue;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(1069, 652);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(125, 41);
            this.btnMenos.TabIndex = 46;
            this.btnMenos.Text = "↓";
            this.btnMenos.UseVisualStyleBackColor = false;
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.LightBlue;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(899, 652);
            this.btnMas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(125, 41);
            this.btnMas.TabIndex = 47;
            this.btnMas.Text = "↑";
            this.btnMas.UseVisualStyleBackColor = false;
            // 
            // Nombre_de_Juego
            // 
            this.Nombre_de_Juego.HeaderText = "Nombre de juego";
            this.Nombre_de_Juego.MinimumWidth = 6;
            this.Nombre_de_Juego.Name = "Nombre_de_Juego";
            this.Nombre_de_Juego.ReadOnly = true;
            this.Nombre_de_Juego.Width = 300;
            // 
            // Cantidad_jugadores
            // 
            this.Cantidad_jugadores.HeaderText = "Cantidad de jugadores";
            this.Cantidad_jugadores.MinimumWidth = 6;
            this.Cantidad_jugadores.Name = "Cantidad_jugadores";
            this.Cantidad_jugadores.ReadOnly = true;
            this.Cantidad_jugadores.Width = 190;
            // 
            // pryListadejuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1363, 767);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.dgvMostrar1);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ltbOrdenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCantidad2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMostrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "pryListadejuegos";
            this.Text = "Lista de Juegos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCantidad2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.ListBox ltbOrdenar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.DataGridView dgvMostrar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_de_Juego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_jugadores;
    }
}