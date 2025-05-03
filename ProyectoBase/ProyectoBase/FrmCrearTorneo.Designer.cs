namespace ProyectoBase
{
    partial class FrmCrearTorneo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Cargar = new System.Windows.Forms.Button();
            this.btnparche = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttorneo = new System.Windows.Forms.TextBox();
            this.txttemporada = new System.Windows.Forms.TextBox();
            this.Grilla1 = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbZona);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.Cargar);
            this.groupBox1.Controls.Add(this.btnparche);
            this.groupBox1.Controls.Add(this.btnTodos);
            this.groupBox1.Controls.Add(this.Grilla2);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttorneo);
            this.groupBox1.Controls.Add(this.txttemporada);
            this.groupBox1.Controls.Add(this.Grilla1);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.cmbcategoria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del torneo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Zona";
            // 
            // cmbZona
            // 
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(444, 34);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(99, 24);
            this.cmbZona.TabIndex = 26;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(297, 242);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 47);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(545, 482);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(443, 75);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 23);
            this.txtcantidad.TabIndex = 22;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(284, 31);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(75, 31);
            this.Cargar.TabIndex = 21;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // btnparche
            // 
            this.btnparche.Location = new System.Drawing.Point(301, 306);
            this.btnparche.Name = "btnparche";
            this.btnparche.Size = new System.Drawing.Size(57, 52);
            this.btnparche.TabIndex = 20;
            this.btnparche.Text = "Parche promedios";
            this.btnparche.UseVisualStyleBackColor = true;
            this.btnparche.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(301, 180);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(58, 47);
            this.btnTodos.TabIndex = 19;
            this.btnTodos.Text = ">>";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // Grilla2
            // 
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEquipo,
            this.Column1,
            this.Column2});
            this.Grilla2.Location = new System.Drawing.Point(383, 123);
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.Size = new System.Drawing.Size(344, 353);
            this.Grilla2.TabIndex = 18;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(81, 17);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Temporada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // txttorneo
            // 
            this.txttorneo.Location = new System.Drawing.Point(98, 65);
            this.txttorneo.Name = "txttorneo";
            this.txttorneo.Size = new System.Drawing.Size(180, 23);
            this.txttorneo.TabIndex = 15;
            // 
            // txttemporada
            // 
            this.txttemporada.Location = new System.Drawing.Point(98, 94);
            this.txttemporada.Name = "txttemporada";
            this.txttemporada.Size = new System.Drawing.Size(180, 23);
            this.txttemporada.TabIndex = 14;
            // 
            // Grilla1
            // 
            this.Grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla1.Location = new System.Drawing.Point(14, 123);
            this.Grilla1.Name = "Grilla1";
            this.Grilla1.Size = new System.Drawing.Size(264, 353);
            this.Grilla1.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Categoria";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(98, 35);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(180, 24);
            this.cmbcategoria.TabIndex = 1;
            // 
            // IdEquipo
            // 
            this.IdEquipo.HeaderText = "Column1";
            this.IdEquipo.Name = "IdEquipo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // FrmCrearTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 554);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCrearTorneo";
            this.Text = "Formulario para crear Torneo";
            this.Load += new System.EventHandler(this.FrmCrearTorneo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox cmbcategoria;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtcantidad;
        internal System.Windows.Forms.Button Cargar;
        internal System.Windows.Forms.Button btnparche;
        internal System.Windows.Forms.Button btnTodos;
        internal System.Windows.Forms.DataGridView Grilla2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txttorneo;
        internal System.Windows.Forms.TextBox txttemporada;
        internal System.Windows.Forms.DataGridView Grilla1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}