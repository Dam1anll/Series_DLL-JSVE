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
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnColas = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnArreglos = new System.Windows.Forms.Button();
            this.PanelEsquina = new System.Windows.Forms.Panel();
            this.LabelSeries = new System.Windows.Forms.Label();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelLateral.SuspendLayout();
            this.PanelEsquina.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.PanelLateral.Controls.Add(this.btnColas);
            this.PanelLateral.Controls.Add(this.btnPilas);
            this.PanelLateral.Controls.Add(this.btnListas);
            this.PanelLateral.Controls.Add(this.btnArreglos);
            this.PanelLateral.Controls.Add(this.PanelEsquina);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(179, 471);
            this.PanelLateral.TabIndex = 0;
            // 
            // btnColas
            // 
            this.btnColas.FlatAppearance.BorderSize = 0;
            this.btnColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColas.ForeColor = System.Drawing.Color.White;
            this.btnColas.Location = new System.Drawing.Point(0, 236);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(179, 52);
            this.btnColas.TabIndex = 5;
            this.btnColas.Text = "Colas";
            this.btnColas.UseVisualStyleBackColor = true;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // btnPilas
            // 
            this.btnPilas.FlatAppearance.BorderSize = 0;
            this.btnPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilas.ForeColor = System.Drawing.Color.White;
            this.btnPilas.Location = new System.Drawing.Point(0, 178);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(179, 52);
            this.btnPilas.TabIndex = 4;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.UseVisualStyleBackColor = true;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnListas
            // 
            this.btnListas.FlatAppearance.BorderSize = 0;
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListas.ForeColor = System.Drawing.Color.White;
            this.btnListas.Location = new System.Drawing.Point(0, 120);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(179, 52);
            this.btnListas.TabIndex = 3;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnArreglos
            // 
            this.btnArreglos.FlatAppearance.BorderSize = 0;
            this.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArreglos.ForeColor = System.Drawing.Color.White;
            this.btnArreglos.Location = new System.Drawing.Point(0, 62);
            this.btnArreglos.Name = "btnArreglos";
            this.btnArreglos.Size = new System.Drawing.Size(179, 52);
            this.btnArreglos.TabIndex = 2;
            this.btnArreglos.Text = "Arreglos";
            this.btnArreglos.UseVisualStyleBackColor = true;
            this.btnArreglos.Click += new System.EventHandler(this.btnArreglos_Click);
            // 
            // PanelEsquina
            // 
            this.PanelEsquina.Controls.Add(this.LabelSeries);
            this.PanelEsquina.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEsquina.Location = new System.Drawing.Point(0, 0);
            this.PanelEsquina.Name = "PanelEsquina";
            this.PanelEsquina.Size = new System.Drawing.Size(179, 62);
            this.PanelEsquina.TabIndex = 0;
            // 
            // LabelSeries
            // 
            this.LabelSeries.AutoSize = true;
            this.LabelSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeries.ForeColor = System.Drawing.Color.White;
            this.LabelSeries.Location = new System.Drawing.Point(40, 15);
            this.LabelSeries.Name = "LabelSeries";
            this.LabelSeries.Size = new System.Drawing.Size(101, 32);
            this.LabelSeries.TabIndex = 2;
            this.LabelSeries.Text = "Series";
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(179, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(789, 62);
            this.PanelSuperior.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(179, 62);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(789, 409);
            this.PanelContenedor.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainMenu";
            this.PanelLateral.ResumeLayout(false);
            this.PanelEsquina.ResumeLayout(false);
            this.PanelEsquina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelEsquina;
        private System.Windows.Forms.Label LabelSeries;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button btnArreglos;
        private System.Windows.Forms.Button btnColas;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}
