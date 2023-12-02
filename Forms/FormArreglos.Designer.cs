namespace ProyectoSeries_DLL_JSVE.Forms
{
    partial class FormArreglos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.LabelTamaño = new System.Windows.Forms.Label();
            this.btnIngresarArreglos = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnOrdenarCapitulos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.GridArreglos = new System.Windows.Forms.DataGridView();
            this.IdSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCapitulosSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBotones.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArreglos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panelBotones.Controls.Add(this.txtTamaño);
            this.panelBotones.Controls.Add(this.LabelTamaño);
            this.panelBotones.Controls.Add(this.btnIngresarArreglos);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(259, 471);
            this.panelBotones.TabIndex = 17;
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(98, 105);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(131, 22);
            this.txtTamaño.TabIndex = 8;
            // 
            // LabelTamaño
            // 
            this.LabelTamaño.AutoSize = true;
            this.LabelTamaño.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTamaño.Location = new System.Drawing.Point(31, 111);
            this.LabelTamaño.Name = "LabelTamaño";
            this.LabelTamaño.Size = new System.Drawing.Size(61, 16);
            this.LabelTamaño.TabIndex = 4;
            this.LabelTamaño.Text = "Tamaño:";
            // 
            // btnIngresarArreglos
            // 
            this.btnIngresarArreglos.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIngresarArreglos.FlatAppearance.BorderSize = 0;
            this.btnIngresarArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarArreglos.ForeColor = System.Drawing.Color.White;
            this.btnIngresarArreglos.Location = new System.Drawing.Point(34, 133);
            this.btnIngresarArreglos.Name = "btnIngresarArreglos";
            this.btnIngresarArreglos.Size = new System.Drawing.Size(195, 35);
            this.btnIngresarArreglos.TabIndex = 2;
            this.btnIngresarArreglos.Text = "Agregar";
            this.btnIngresarArreglos.UseVisualStyleBackColor = false;
            this.btnIngresarArreglos.Click += new System.EventHandler(this.btnIngresarArreglos_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panelGrid.Controls.Add(this.label1);
            this.panelGrid.Controls.Add(this.btnEliminar);
            this.panelGrid.Controls.Add(this.btnOrdenarCapitulos);
            this.panelGrid.Controls.Add(this.btnCerrar);
            this.panelGrid.Controls.Add(this.btnEditar);
            this.panelGrid.Controls.Add(this.GridArreglos);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(259, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(709, 471);
            this.panelGrid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Arreglos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(409, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnOrdenarCapitulos
            // 
            this.btnOrdenarCapitulos.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrdenarCapitulos.FlatAppearance.BorderSize = 0;
            this.btnOrdenarCapitulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarCapitulos.ForeColor = System.Drawing.Color.White;
            this.btnOrdenarCapitulos.Location = new System.Drawing.Point(7, 345);
            this.btnOrdenarCapitulos.Name = "btnOrdenarCapitulos";
            this.btnOrdenarCapitulos.Size = new System.Drawing.Size(195, 35);
            this.btnOrdenarCapitulos.TabIndex = 12;
            this.btnOrdenarCapitulos.Text = "Ordenar";
            this.btnOrdenarCapitulos.UseVisualStyleBackColor = false;
            this.btnOrdenarCapitulos.Click += new System.EventHandler(this.btnOrdenarCapitulos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(948, 23);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "X";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(208, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(195, 35);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // GridArreglos
            // 
            this.GridArreglos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridArreglos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.GridArreglos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridArreglos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridArreglos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridArreglos.ColumnHeadersHeight = 20;
            this.GridArreglos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridArreglos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSerie,
            this.NombreSerie,
            this.DescripcionSerie,
            this.NroCapitulosSerie});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridArreglos.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridArreglos.EnableHeadersVisualStyles = false;
            this.GridArreglos.GridColor = System.Drawing.Color.SteelBlue;
            this.GridArreglos.Location = new System.Drawing.Point(6, 105);
            this.GridArreglos.Name = "GridArreglos";
            this.GridArreglos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridArreglos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridArreglos.RowHeadersWidth = 51;
            this.GridArreglos.RowTemplate.Height = 24;
            this.GridArreglos.Size = new System.Drawing.Size(691, 234);
            this.GridArreglos.TabIndex = 15;
            // 
            // IdSerie
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.IdSerie.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdSerie.HeaderText = "Id";
            this.IdSerie.MinimumWidth = 6;
            this.IdSerie.Name = "IdSerie";
            // 
            // NombreSerie
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.NombreSerie.DefaultCellStyle = dataGridViewCellStyle3;
            this.NombreSerie.HeaderText = "Nombre";
            this.NombreSerie.MinimumWidth = 6;
            this.NombreSerie.Name = "NombreSerie";
            // 
            // DescripcionSerie
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DescripcionSerie.DefaultCellStyle = dataGridViewCellStyle4;
            this.DescripcionSerie.HeaderText = "Descripcion";
            this.DescripcionSerie.MinimumWidth = 6;
            this.DescripcionSerie.Name = "DescripcionSerie";
            // 
            // NroCapitulosSerie
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.NroCapitulosSerie.DefaultCellStyle = dataGridViewCellStyle5;
            this.NroCapitulosSerie.HeaderText = "Nro.Capitulos";
            this.NroCapitulosSerie.MinimumWidth = 6;
            this.NroCapitulosSerie.Name = "NroCapitulosSerie";
            // 
            // FormArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArreglos";
            this.Text = "FormArreglos";
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridArreglos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label LabelTamaño;
        private System.Windows.Forms.Button btnIngresarArreglos;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnOrdenarCapitulos;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView GridArreglos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCapitulosSerie;
    }
}