namespace ProyectoSeries_DLL_JSVE
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnColas = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnArreglos = new System.Windows.Forms.Button();
            this.PanelEsquina = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPilas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelLateral.SuspendLayout();
            this.PanelEsquina.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(73)))));
            this.PanelLateral.Controls.Add(this.btnColas);
            this.PanelLateral.Controls.Add(this.btnPilas);
            this.PanelLateral.Controls.Add(this.btnListas);
            this.PanelLateral.Controls.Add(this.btnArreglos);
            this.PanelLateral.Controls.Add(this.PanelEsquina);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(213, 542);
            this.PanelLateral.TabIndex = 0;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // btnColas
            // 
            this.btnColas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(73)))));
            this.btnColas.FlatAppearance.BorderSize = 0;
            this.btnColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColas.ForeColor = System.Drawing.Color.White;
            this.btnColas.Image = ((System.Drawing.Image)(resources.GetObject("btnColas.Image")));
            this.btnColas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnColas.Location = new System.Drawing.Point(-3, 362);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(216, 74);
            this.btnColas.TabIndex = 5;
            this.btnColas.Text = "COLAS";
            this.btnColas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColas.UseVisualStyleBackColor = false;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // btnListas
            // 
            this.btnListas.FlatAppearance.BorderSize = 0;
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListas.ForeColor = System.Drawing.Color.White;
            this.btnListas.Image = ((System.Drawing.Image)(resources.GetObject("btnListas.Image")));
            this.btnListas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnListas.Location = new System.Drawing.Point(3, 183);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(210, 74);
            this.btnListas.TabIndex = 3;
            this.btnListas.Text = "LISTAS";
            this.btnListas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnArreglos
            // 
            this.btnArreglos.FlatAppearance.BorderSize = 0;
            this.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArreglos.ForeColor = System.Drawing.Color.White;
            this.btnArreglos.Image = ((System.Drawing.Image)(resources.GetObject("btnArreglos.Image")));
            this.btnArreglos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnArreglos.Location = new System.Drawing.Point(3, 91);
            this.btnArreglos.Name = "btnArreglos";
            this.btnArreglos.Size = new System.Drawing.Size(210, 74);
            this.btnArreglos.TabIndex = 2;
            this.btnArreglos.Text = "ARREGLOS";
            this.btnArreglos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArreglos.UseVisualStyleBackColor = true;
            this.btnArreglos.Click += new System.EventHandler(this.btnArreglos_Click);
            // 
            // PanelEsquina
            // 
            this.PanelEsquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(73)))));
            this.PanelEsquina.Controls.Add(this.pictureBox2);
            this.PanelEsquina.Controls.Add(this.label1);
            this.PanelEsquina.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEsquina.Location = new System.Drawing.Point(0, 0);
            this.PanelEsquina.Name = "PanelEsquina";
            this.PanelEsquina.Size = new System.Drawing.Size(213, 89);
            this.PanelEsquina.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(73)))));
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(213, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(914, 89);
            this.PanelSuperior.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(50)))));
            this.PanelContenedor.Controls.Add(this.pictureBox1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PanelContenedor.Location = new System.Drawing.Point(213, 89);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(914, 453);
            this.PanelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERIES";
            // 
            // btnPilas
            // 
            this.btnPilas.FlatAppearance.BorderSize = 0;
            this.btnPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilas.ForeColor = System.Drawing.Color.White;
            this.btnPilas.Image = ((System.Drawing.Image)(resources.GetObject("btnPilas.Image")));
            this.btnPilas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPilas.Location = new System.Drawing.Point(3, 273);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(210, 74);
            this.btnPilas.TabIndex = 4;
            this.btnPilas.Text = "PILAS";
            this.btnPilas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPilas.UseVisualStyleBackColor = true;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 58);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1127, 542);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainMenu";
            this.PanelLateral.ResumeLayout(false);
            this.PanelEsquina.ResumeLayout(false);
            this.PanelEsquina.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelEsquina;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button btnArreglos;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnColas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
