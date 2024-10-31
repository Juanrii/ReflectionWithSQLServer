using MaterialSkin.Controls;
using MetroFramework;
using ReflectSQL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormClases : MetroFramework.Forms.MetroForm
    {
        public FormClases()
        {
            InitializeComponent();
        }

        private void FormClases_Load(object sender, EventArgs e)
        {
            try
            {
                VerBotonesCopy(false);
                VerGroupBoxes(false);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error al listar clases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void VerBotonesCopy(bool visible = true)
        {
            try
            {
                btnCopyCreateDB.Visible = visible;
                btnCopyDelete.Visible = visible;
                btnCopyInsert.Visible = visible;
                btnCopyLeer.Visible = visible;
                btnCopyUpdate.Visible = visible;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void VerGroupBoxes(bool visible = true)
        {
            try
            {
                groupBox1.Visible = visible;
                groupBox2.Visible = visible;
                groupBox3.Visible = visible;
                groupBox4.Visible = visible;
                groupBox5.Visible = visible;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnListarClases_Click(object sender, EventArgs e)
        {
            try
            {
                materialListBox1.Clear();

                List<string> clases = ReflectionService.ListarClases();

                foreach (string clase in clases)
                    materialListBox1.Items.Add(new MaterialSkin.MaterialListBoxItem(clase));
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error al detectar clases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDetectarPropiedades_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialListBox1.SelectedItem == null)
                {
                    MetroMessageBox.Show(this, "Seleccione una clase para detectar sus propiedades.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                materialListBox2.Clear();
                
                List<string> propiedades = ReflectionService.ListarPropiedades(materialListBox1.SelectedItem.Text);

                foreach (string propiedad in propiedades)
                    materialListBox2.Items.Add(new MaterialSkin.MaterialListBoxItem(propiedad));
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error al detectar propiedades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void generarSQL_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialListBox1.SelectedItem == null)
                {
                    MetroMessageBox.Show(this, "Seleccione una clase para generar el código SQL.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string className = materialListBox1.SelectedItem.Text;
                Dictionary<string, string> sqlCommands = ReflectionService.GenerarSQL(className);

                Dictionary<string, MaterialMultiLineTextBox> textos = new Dictionary<string, MaterialMultiLineTextBox>
                {
                    {"Insert", inputInsert },
                    {"Update", inputUpdate },
                    {"Select", inputLeer },
                    {"Delete", inputDelete },
                    {"CreateTable", inputCreateDB }
                };

                foreach (var command in sqlCommands)
                {
                    if (textos.ContainsKey(command.Key))
                        textos[command.Key].Text = command.Value;
                }

                VerBotones();
                VerGroupBoxes();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error al generar el código SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyInsert_Click(object sender, EventArgs e)
        {
            try
            {
                CopiarComando(inputInsert.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error copiar la sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CopiarComando(string text)
        {
            string s = text.Replace("\n", " ");
            Clipboard.SetText(s);
        }

        private void btnCopyUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CopiarComando(inputUpdate.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error copiar la sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCopyLeer_Click(object sender, EventArgs e)
        {
            try
            {
                CopiarComando(inputLeer.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error copiar la sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCopyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CopiarComando(inputDelete.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error copiar la sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCopyCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                CopiarComando(inputCreateDB.Text);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error copiar la sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            try
            {
                VerBotones(false);
                VerGroupBoxes(false);

                materialListBox2.Clear();

                inputCreateDB.Text = "";
                inputDelete.Text = "";
                inputInsert.Text = "";
                inputLeer.Text = "";
                inputUpdate.Text = "";
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void VerBotones(bool visible = true)
        {
            try
            {
                btnCopyCreateDB.Visible = visible;
                btnCopyDelete.Visible = visible;
                btnCopyInsert.Visible = visible;
                btnCopyLeer.Visible = visible;
                btnCopyUpdate.Visible = visible;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
