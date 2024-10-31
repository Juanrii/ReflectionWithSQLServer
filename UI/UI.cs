using MetroFramework;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class UI : MetroFramework.Forms.MetroForm
    {
        public UI()
        {
            InitializeComponent();
        }

        private void listarClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormClases fc = new FormClases();
                fc.MdiParent = this;
                fc.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error al listar clases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opc = MetroMessageBox.Show(this, "¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.No)
                    return;

                foreach (Form form in this.MdiChildren)
                    form.Close();

                Application.Exit();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error al salir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
