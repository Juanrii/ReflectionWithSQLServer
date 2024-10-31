namespace UI
{
    partial class FormClases
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
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.materialListBox2 = new MaterialSkin.Controls.MaterialListBox();
            this.btnDetectarPropiedades = new MaterialSkin.Controls.MaterialButton();
            this.btnListarClases = new MaterialSkin.Controls.MaterialButton();
            this.inputInsert = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.inputUpdate = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.inputLeer = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.inputDelete = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.generarSQL = new MaterialSkin.Controls.MaterialButton();
            this.inputCreateDB = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnCopyInsert = new MaterialSkin.Controls.MaterialButton();
            this.btnCopyUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCopyLeer = new MaterialSkin.Controls.MaterialButton();
            this.btnCopyDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnCopyCreateDB = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox1.Location = new System.Drawing.Point(20, 120);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(744, 944);
            this.materialListBox1.TabIndex = 1;
            this.materialListBox1.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox1_SelectedIndexChanged);
            // 
            // materialListBox2
            // 
            this.materialListBox2.BackColor = System.Drawing.Color.White;
            this.materialListBox2.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox2.Depth = 0;
            this.materialListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox2.Location = new System.Drawing.Point(852, 120);
            this.materialListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox2.Name = "materialListBox2";
            this.materialListBox2.SelectedIndex = -1;
            this.materialListBox2.SelectedItem = null;
            this.materialListBox2.Size = new System.Drawing.Size(397, 944);
            this.materialListBox2.TabIndex = 4;
            // 
            // btnDetectarPropiedades
            // 
            this.btnDetectarPropiedades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectarPropiedades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetectarPropiedades.Depth = 0;
            this.btnDetectarPropiedades.HighEmphasis = true;
            this.btnDetectarPropiedades.Icon = global::UI.Properties.Resources.properties;
            this.btnDetectarPropiedades.Location = new System.Drawing.Point(366, 1073);
            this.btnDetectarPropiedades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetectarPropiedades.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetectarPropiedades.Name = "btnDetectarPropiedades";
            this.btnDetectarPropiedades.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetectarPropiedades.Size = new System.Drawing.Size(223, 36);
            this.btnDetectarPropiedades.TabIndex = 3;
            this.btnDetectarPropiedades.Text = "Detectar Propiedades";
            this.btnDetectarPropiedades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetectarPropiedades.UseAccentColor = false;
            this.btnDetectarPropiedades.UseVisualStyleBackColor = true;
            this.btnDetectarPropiedades.Click += new System.EventHandler(this.btnDetectarPropiedades_Click);
            // 
            // btnListarClases
            // 
            this.btnListarClases.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarClases.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListarClases.Depth = 0;
            this.btnListarClases.HighEmphasis = true;
            this.btnListarClases.Icon = global::UI.Properties.Resources.document;
            this.btnListarClases.Location = new System.Drawing.Point(20, 1073);
            this.btnListarClases.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListarClases.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarClases.Name = "btnListarClases";
            this.btnListarClases.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListarClases.Size = new System.Drawing.Size(155, 36);
            this.btnListarClases.TabIndex = 2;
            this.btnListarClases.Text = "Listar Clases";
            this.btnListarClases.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListarClases.UseAccentColor = false;
            this.btnListarClases.UseVisualStyleBackColor = true;
            this.btnListarClases.Click += new System.EventHandler(this.btnListarClases_Click);
            // 
            // inputInsert
            // 
            this.inputInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inputInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputInsert.Depth = 0;
            this.inputInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputInsert.Location = new System.Drawing.Point(23, 30);
            this.inputInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputInsert.Name = "inputInsert";
            this.inputInsert.Size = new System.Drawing.Size(674, 149);
            this.inputInsert.TabIndex = 5;
            this.inputInsert.Text = "";
            // 
            // inputUpdate
            // 
            this.inputUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inputUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUpdate.Depth = 0;
            this.inputUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputUpdate.Location = new System.Drawing.Point(23, 30);
            this.inputUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputUpdate.Name = "inputUpdate";
            this.inputUpdate.Size = new System.Drawing.Size(674, 149);
            this.inputUpdate.TabIndex = 6;
            this.inputUpdate.Text = "";
            // 
            // inputLeer
            // 
            this.inputLeer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLeer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inputLeer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLeer.Depth = 0;
            this.inputLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputLeer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputLeer.Location = new System.Drawing.Point(36, 30);
            this.inputLeer.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputLeer.Name = "inputLeer";
            this.inputLeer.Size = new System.Drawing.Size(674, 149);
            this.inputLeer.TabIndex = 7;
            this.inputLeer.Text = "";
            // 
            // inputDelete
            // 
            this.inputDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inputDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDelete.Depth = 0;
            this.inputDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputDelete.Location = new System.Drawing.Point(23, 29);
            this.inputDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputDelete.Name = "inputDelete";
            this.inputDelete.Size = new System.Drawing.Size(674, 149);
            this.inputDelete.TabIndex = 8;
            this.inputDelete.Text = "";
            // 
            // generarSQL
            // 
            this.generarSQL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generarSQL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.generarSQL.Depth = 0;
            this.generarSQL.HighEmphasis = true;
            this.generarSQL.Icon = global::UI.Properties.Resources.db;
            this.generarSQL.Location = new System.Drawing.Point(841, 1073);
            this.generarSQL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generarSQL.MouseState = MaterialSkin.MouseState.HOVER;
            this.generarSQL.Name = "generarSQL";
            this.generarSQL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.generarSQL.Size = new System.Drawing.Size(145, 36);
            this.generarSQL.TabIndex = 9;
            this.generarSQL.Text = "Generar SQL";
            this.generarSQL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generarSQL.UseAccentColor = false;
            this.generarSQL.UseVisualStyleBackColor = true;
            this.generarSQL.Click += new System.EventHandler(this.generarSQL_Click);
            // 
            // inputCreateDB
            // 
            this.inputCreateDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCreateDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inputCreateDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputCreateDB.Depth = 0;
            this.inputCreateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputCreateDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputCreateDB.Location = new System.Drawing.Point(21, 81);
            this.inputCreateDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputCreateDB.Name = "inputCreateDB";
            this.inputCreateDB.Size = new System.Drawing.Size(616, 857);
            this.inputCreateDB.TabIndex = 10;
            this.inputCreateDB.Text = "";
            // 
            // btnCopyInsert
            // 
            this.btnCopyInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyInsert.Depth = 0;
            this.btnCopyInsert.HighEmphasis = true;
            this.btnCopyInsert.Icon = global::UI.Properties.Resources.copy;
            this.btnCopyInsert.Location = new System.Drawing.Point(729, 30);
            this.btnCopyInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyInsert.Name = "btnCopyInsert";
            this.btnCopyInsert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyInsert.Size = new System.Drawing.Size(64, 36);
            this.btnCopyInsert.TabIndex = 11;
            this.btnCopyInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyInsert.UseAccentColor = false;
            this.btnCopyInsert.UseVisualStyleBackColor = true;
            this.btnCopyInsert.Click += new System.EventHandler(this.btnCopyInsert_Click);
            // 
            // btnCopyUpdate
            // 
            this.btnCopyUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyUpdate.Depth = 0;
            this.btnCopyUpdate.HighEmphasis = true;
            this.btnCopyUpdate.Icon = global::UI.Properties.Resources.copy;
            this.btnCopyUpdate.Location = new System.Drawing.Point(729, 30);
            this.btnCopyUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyUpdate.Name = "btnCopyUpdate";
            this.btnCopyUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyUpdate.Size = new System.Drawing.Size(64, 36);
            this.btnCopyUpdate.TabIndex = 12;
            this.btnCopyUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyUpdate.UseAccentColor = false;
            this.btnCopyUpdate.UseVisualStyleBackColor = true;
            this.btnCopyUpdate.Click += new System.EventHandler(this.btnCopyUpdate_Click);
            // 
            // btnCopyLeer
            // 
            this.btnCopyLeer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyLeer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyLeer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyLeer.Depth = 0;
            this.btnCopyLeer.HighEmphasis = true;
            this.btnCopyLeer.Icon = global::UI.Properties.Resources.copy;
            this.btnCopyLeer.Location = new System.Drawing.Point(729, 30);
            this.btnCopyLeer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyLeer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyLeer.Name = "btnCopyLeer";
            this.btnCopyLeer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyLeer.Size = new System.Drawing.Size(64, 36);
            this.btnCopyLeer.TabIndex = 13;
            this.btnCopyLeer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyLeer.UseAccentColor = false;
            this.btnCopyLeer.UseVisualStyleBackColor = true;
            this.btnCopyLeer.Click += new System.EventHandler(this.btnCopyLeer_Click);
            // 
            // btnCopyDelete
            // 
            this.btnCopyDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyDelete.Depth = 0;
            this.btnCopyDelete.HighEmphasis = true;
            this.btnCopyDelete.Icon = global::UI.Properties.Resources.copy;
            this.btnCopyDelete.Location = new System.Drawing.Point(729, 29);
            this.btnCopyDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyDelete.Name = "btnCopyDelete";
            this.btnCopyDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyDelete.Size = new System.Drawing.Size(64, 36);
            this.btnCopyDelete.TabIndex = 14;
            this.btnCopyDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyDelete.UseAccentColor = false;
            this.btnCopyDelete.UseVisualStyleBackColor = true;
            this.btnCopyDelete.Click += new System.EventHandler(this.btnCopyDelete_Click);
            // 
            // btnCopyCreateDB
            // 
            this.btnCopyCreateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyCreateDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyCreateDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyCreateDB.Depth = 0;
            this.btnCopyCreateDB.HighEmphasis = true;
            this.btnCopyCreateDB.Icon = global::UI.Properties.Resources.copy;
            this.btnCopyCreateDB.Location = new System.Drawing.Point(572, 30);
            this.btnCopyCreateDB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyCreateDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyCreateDB.Name = "btnCopyCreateDB";
            this.btnCopyCreateDB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyCreateDB.Size = new System.Drawing.Size(64, 36);
            this.btnCopyCreateDB.TabIndex = 15;
            this.btnCopyCreateDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyCreateDB.UseAccentColor = false;
            this.btnCopyCreateDB.UseVisualStyleBackColor = true;
            this.btnCopyCreateDB.Click += new System.EventHandler(this.btnCopyCreateDB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputInsert);
            this.groupBox1.Controls.Add(this.btnCopyInsert);
            this.groupBox1.Location = new System.Drawing.Point(1269, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comando Insert";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputUpdate);
            this.groupBox2.Controls.Add(this.btnCopyUpdate);
            this.groupBox2.Location = new System.Drawing.Point(1269, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 188);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comando Update";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputLeer);
            this.groupBox3.Controls.Add(this.btnCopyLeer);
            this.groupBox3.Location = new System.Drawing.Point(1269, 624);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 188);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comando Select";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inputDelete);
            this.groupBox4.Controls.Add(this.btnCopyDelete);
            this.groupBox4.Location = new System.Drawing.Point(1269, 876);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 188);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comando Delete";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCopyCreateDB);
            this.groupBox5.Controls.Add(this.inputCreateDB);
            this.groupBox5.Location = new System.Drawing.Point(2122, 120);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(643, 944);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Comando Create Table";
            // 
            // FormClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2788, 1225);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generarSQL);
            this.Controls.Add(this.materialListBox2);
            this.Controls.Add(this.btnDetectarPropiedades);
            this.Controls.Add(this.btnListarClases);
            this.Controls.Add(this.materialListBox1);
            this.Name = "FormClases";
            this.Padding = new System.Windows.Forms.Padding(20, 120, 20, 120);
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialButton btnListarClases;
        private MaterialSkin.Controls.MaterialButton btnDetectarPropiedades;
        private MaterialSkin.Controls.MaterialListBox materialListBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox inputInsert;
        private MaterialSkin.Controls.MaterialMultiLineTextBox inputUpdate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox inputLeer;
        private MaterialSkin.Controls.MaterialMultiLineTextBox inputDelete;
        private MaterialSkin.Controls.MaterialButton generarSQL;
        private MaterialSkin.Controls.MaterialMultiLineTextBox inputCreateDB;
        private MaterialSkin.Controls.MaterialButton btnCopyInsert;
        private MaterialSkin.Controls.MaterialButton btnCopyUpdate;
        private MaterialSkin.Controls.MaterialButton btnCopyLeer;
        private MaterialSkin.Controls.MaterialButton btnCopyDelete;
        private MaterialSkin.Controls.MaterialButton btnCopyCreateDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}