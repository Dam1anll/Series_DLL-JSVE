using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Forms;

namespace ProyectoSeries_DLL_JSVE
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu() 
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnArreglos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormArreglos());
        }
        private void btnListas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormListas());
        }
        private void btnPilas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormPilas());
        }
        private void btnColas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormColas());
        }
    }
}
