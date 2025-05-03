namespace ProyectoBase
{
    partial class FrmFixture
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
            this.btnTodos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnularVisitante = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.GrillaVisitante = new System.Windows.Forms.DataGridView();
            this.GrillaLocal = new System.Windows.Forms.DataGridView();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.btnCargarEquipos = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbEquipo);
            this.groupBox1.Controls.Add(this.btnTodos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAnularVisitante);
            this.groupBox1.Controls.Add(this.btnAnular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGrabar);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.GrillaVisitante);
            this.groupBox1.Controls.Add(this.GrillaLocal);
            this.groupBox1.Controls.Add(this.Grilla);
            this.groupBox1.Controls.Add(this.btnCargarEquipos);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.cmbTorneo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fixture";
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(392, 21);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(72, 24);
            this.btnTodos.TabIndex = 65;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Fecha";
            // 
            // btnAnularVisitante
            // 
            this.btnAnularVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularVisitante.Location = new System.Drawing.Point(523, 471);
            this.btnAnularVisitante.Name = "btnAnularVisitante";
            this.btnAnularVisitante.Size = new System.Drawing.Size(75, 31);
            this.btnAnularVisitante.TabIndex = 63;
            this.btnAnularVisitante.Text = "Anular";
            this.btnAnularVisitante.UseVisualStyleBackColor = true;
            this.btnAnularVisitante.Click += new System.EventHandler(this.btnAnularVisitante_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(290, 471);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 31);
            this.btnAnular.TabIndex = 62;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Visitante";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Local";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Equipos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(650, 23);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 30);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(523, 21);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 29);
            this.txtFecha.TabIndex = 9;
            // 
            // GrillaVisitante
            // 
            this.GrillaVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaVisitante.Location = new System.Drawing.Point(523, 92);
            this.GrillaVisitante.Name = "GrillaVisitante";
            this.GrillaVisitante.Size = new System.Drawing.Size(202, 358);
            this.GrillaVisitante.TabIndex = 8;
            // 
            // GrillaLocal
            // 
            this.GrillaLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaLocal.Location = new System.Drawing.Point(290, 92);
            this.GrillaLocal.Name = "GrillaLocal";
            this.GrillaLocal.Size = new System.Drawing.Size(202, 358);
            this.GrillaLocal.TabIndex = 7;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(14, 92);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(202, 410);
            this.Grilla.TabIndex = 6;
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellClick);
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // btnCargarEquipos
            // 
            this.btnCargarEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarEquipos.Location = new System.Drawing.Point(300, 15);
            this.btnCargarEquipos.Name = "btnCargarEquipos";
            this.btnCargarEquipos.Size = new System.Drawing.Size(75, 24);
            this.btnCargarEquipos.TabIndex = 5;
            this.btnCargarEquipos.Text = "Cargar";
            this.btnCargarEquipos.UseVisualStyleBackColor = true;
            this.btnCargarEquipos.Click += new System.EventHandler(this.btnCargarEquipos_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Torneo";
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(79, 15);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(215, 24);
            this.cmbTorneo.TabIndex = 3;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(79, 37);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(215, 24);
            this.cmbEquipo.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(300, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 67;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 532);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFixture";
            this.Text = "FrmFixture";
            this.Load += new System.EventHandler(this.FrmFixture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbTorneo;
        internal System.Windows.Forms.Button btnCargarEquipos;
        internal System.Windows.Forms.DataGridView Grilla;
        internal System.Windows.Forms.DataGridView GrillaVisitante;
        internal System.Windows.Forms.DataGridView GrillaLocal;
        private System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnAnularVisitante;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnTodos;
        internal System.Windows.Forms.ComboBox cmbEquipo;
        internal System.Windows.Forms.Button button1;
    }
}