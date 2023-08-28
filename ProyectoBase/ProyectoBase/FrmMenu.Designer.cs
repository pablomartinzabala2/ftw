namespace ProyectoBase
{
    partial class FrmMenu
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.cmbtorneo = new System.Windows.Forms.ComboBox();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.grilla1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(85, 214);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(4, 214);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 8;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // cmbtorneo
            // 
            this.cmbtorneo.FormattingEnabled = true;
            this.cmbtorneo.Location = new System.Drawing.Point(5, 21);
            this.cmbtorneo.Name = "cmbtorneo";
            this.cmbtorneo.Size = new System.Drawing.Size(239, 21);
            this.cmbtorneo.TabIndex = 7;
            // 
            // Grilla2
            // 
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Location = new System.Drawing.Point(5, 243);
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.Size = new System.Drawing.Size(608, 150);
            this.Grilla2.TabIndex = 6;
            // 
            // grilla1
            // 
            this.grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla1.Location = new System.Drawing.Point(4, 58);
            this.grilla1.Name = "grilla1";
            this.grilla1.Size = new System.Drawing.Size(609, 150);
            this.grilla1.TabIndex = 5;
            this.grilla1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla1_CellClick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 415);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.cmbtorneo);
            this.Controls.Add(this.Grilla2);
            this.Controls.Add(this.grilla1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btngrabar;
        internal System.Windows.Forms.ComboBox cmbtorneo;
        internal System.Windows.Forms.DataGridView Grilla2;
        internal System.Windows.Forms.DataGridView grilla1;
    }
}