namespace WebHRModuleWizard {
    partial class ModuleWizard {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.Enabled_CheckBoxes = new System.Collections.Generic.List<System.Windows.Forms.CheckBox>();
            this.Name_TextBoxes = new System.Collections.Generic.List<System.Windows.Forms.TextBox>();
            this.DBName_TextBoxes = new System.Collections.Generic.List<System.Windows.Forms.TextBox>();
            this.Type_ComboBoxes = new System.Collections.Generic.List<System.Windows.Forms.ComboBox>();
            this.ShowInEdit_CheckBoxes = new System.Collections.Generic.List<System.Windows.Forms.CheckBox>();

            this.BrowserDialog_ProjectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.Label_PathDescription = new System.Windows.Forms.Label();
            this.Buton_SelectPath = new System.Windows.Forms.Button();
            this.TextBox_ProjectPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_TabelName = new System.Windows.Forms.Label();
            this.TextBox_TabelName = new System.Windows.Forms.TextBox();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.FieldsGroup = new System.Windows.Forms.GroupBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VerticalScrollBar = new System.Windows.Forms.VScrollBar();
            this.Label_ShowInEdit = new System.Windows.Forms.Label();
            this.Label_Enabled = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_DBName = new System.Windows.Forms.Label();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Enabled_CheckBoxes.Add(new System.Windows.Forms.CheckBox());
            this.Name_TextBoxes.Add(new System.Windows.Forms.TextBox());
            this.DBName_TextBoxes.Add(new System.Windows.Forms.TextBox());
            this.ShowInEdit_CheckBoxes.Add(new System.Windows.Forms.CheckBox());
            this.Enabled_CheckBoxes.Add(new System.Windows.Forms.CheckBox());
            this.Name_TextBoxes.Add(new System.Windows.Forms.TextBox());
            this.DBName_TextBoxes.Add(new System.Windows.Forms.TextBox());
            this.Type_ComboBoxes.Add(new System.Windows.Forms.ComboBox());
            this.ShowInEdit_CheckBoxes.Add(new System.Windows.Forms.CheckBox());
            this.SettingsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FieldsGroup.SuspendLayout();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowserDialog_ProjectPath
            // 
            this.BrowserDialog_ProjectPath.HelpRequest += new System.EventHandler(this.ProjectPathBrowserDialog_HelpRequest);
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.Label_PathDescription);
            this.SettingsGroup.Controls.Add(this.Buton_SelectPath);
            this.SettingsGroup.Controls.Add(this.TextBox_ProjectPath);
            this.SettingsGroup.Location = new System.Drawing.Point(12, 12);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Size = new System.Drawing.Size(376, 71);
            this.SettingsGroup.TabIndex = 1;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // Label_PathDescription
            // 
            this.Label_PathDescription.AutoSize = true;
            this.Label_PathDescription.Location = new System.Drawing.Point(7, 19);
            this.Label_PathDescription.Name = "Label_PathDescription";
            this.Label_PathDescription.Size = new System.Drawing.Size(158, 13);
            this.Label_PathDescription.TabIndex = 3;
            this.Label_PathDescription.Text = "Seleziona Base URL di WebHR";
            // 
            // Buton_SelectPath
            // 
            this.Buton_SelectPath.Location = new System.Drawing.Point(185, 39);
            this.Buton_SelectPath.Name = "Buton_SelectPath";
            this.Buton_SelectPath.Size = new System.Drawing.Size(75, 19);
            this.Buton_SelectPath.TabIndex = 2;
            this.Buton_SelectPath.Text = "Browse";
            this.Buton_SelectPath.UseVisualStyleBackColor = true;
            this.Buton_SelectPath.Click += new System.EventHandler(this.ButtonSelectPath_Click);
            // 
            // TextBox_ProjectPath
            // 
            this.TextBox_ProjectPath.Location = new System.Drawing.Point(6, 38);
            this.TextBox_ProjectPath.Name = "TextBox_ProjectPath";
            this.TextBox_ProjectPath.Size = new System.Drawing.Size(173, 20);
            this.TextBox_ProjectPath.TabIndex = 1;
            this.TextBox_ProjectPath.TextChanged += new System.EventHandler(this.ProjectPath_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_TabelName);
            this.groupBox1.Controls.Add(this.TextBox_TabelName);
            this.groupBox1.Location = new System.Drawing.Point(394, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Configurations";
            // 
            // Label_TabelName
            // 
            this.Label_TabelName.AutoSize = true;
            this.Label_TabelName.Location = new System.Drawing.Point(7, 19);
            this.Label_TabelName.Name = "Label_TabelName";
            this.Label_TabelName.Size = new System.Drawing.Size(73, 13);
            this.Label_TabelName.TabIndex = 3;
            this.Label_TabelName.Text = "Nome Tabella";
            // 
            // TextBox_TabelName
            // 
            this.TextBox_TabelName.Location = new System.Drawing.Point(6, 38);
            this.TextBox_TabelName.Name = "TextBox_TabelName";
            this.TextBox_TabelName.Size = new System.Drawing.Size(382, 20);
            this.TextBox_TabelName.TabIndex = 1;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(713, 419);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(75, 19);
            this.Button_Confirm.TabIndex = 4;
            this.Button_Confirm.Text = "Generate";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            // 
            // FieldsGroup
            // 
            this.FieldsGroup.Controls.Add(this.Button_Add);
            this.FieldsGroup.Controls.Add(this.VerticalScrollBar);
            this.FieldsGroup.Controls.Add(this.TableLayout);
            this.FieldsGroup.Location = new System.Drawing.Point(12, 89);
            this.FieldsGroup.Name = "FieldsGroup";
            this.FieldsGroup.Size = new System.Drawing.Size(776, 324);
            this.FieldsGroup.TabIndex = 5;
            this.FieldsGroup.TabStop = false;
            this.FieldsGroup.Text = "Fields";
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(672, 299);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 19);
            this.Button_Add.TabIndex = 6;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // VerticalScrollBar
            // 
            this.VerticalScrollBar.Location = new System.Drawing.Point(753, 20);
            this.VerticalScrollBar.Name = "VerticalScrollBar";
            this.VerticalScrollBar.Size = new System.Drawing.Size(17, 298);
            this.VerticalScrollBar.TabIndex = 1;
            this.VerticalScrollBar.Visible = false;
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 5;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20f));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.TableLayout.Controls.Add(this.Label_Enabled, 0, 0);
            this.TableLayout.Controls.Add(this.Label_Name, 1, 0);
            this.TableLayout.Controls.Add(this.Label_DBName, 2, 0);
            this.TableLayout.Controls.Add(this.Label_Type, 3, 0);
            this.TableLayout.Controls.Add(this.Label_ShowInEdit, 4, 0);
            this.TableLayout.Controls.Add(this.Enabled_CheckBoxes[0], 0, 1);
            this.TableLayout.Controls.Add(this.Name_TextBoxes[0], 1, 1);
            this.TableLayout.Controls.Add(this.DBName_TextBoxes[0], 2, 1);
            this.TableLayout.Controls.Add(this.ShowInEdit_CheckBoxes[0], 4, 1);
            this.TableLayout.Controls.Add(this.Enabled_CheckBoxes[1], 0, 2);
            this.TableLayout.Controls.Add(this.Name_TextBoxes[1], 1, 2);
            this.TableLayout.Controls.Add(this.DBName_TextBoxes[1], 2, 2);
            this.TableLayout.Controls.Add(this.Type_ComboBoxes[0], 3, 2);
            this.TableLayout.Controls.Add(this.ShowInEdit_CheckBoxes[1], 4, 2);
            this.TableLayout.Location = new System.Drawing.Point(7, 20);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 3;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayout.Size = new System.Drawing.Size(743, 273);
            this.TableLayout.TabIndex = 0;
            // 
            // Label_Enabled
            // 
            this.Label_Enabled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Enabled.AutoSize = true;
            this.Label_Enabled.Location = new System.Drawing.Point(3, 0);
            this.Label_Enabled.Name = "Label_Enabled";
            this.Label_Enabled.Size = new System.Drawing.Size(68, 50);
            this.Label_Enabled.TabIndex = 0;
            this.Label_Enabled.Text = "Enabled";
            this.Label_Enabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Name
            // 
            this.Label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(77, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(161, 50);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "Name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_DBName
            // 
            this.Label_DBName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_DBName.AutoSize = true;
            this.Label_DBName.Location = new System.Drawing.Point(244, 0);
            this.Label_DBName.Name = "Label_DBName";
            this.Label_DBName.Size = new System.Drawing.Size(161, 50);
            this.Label_DBName.TabIndex = 2;
            this.Label_DBName.Text = "DB Name";
            this.Label_DBName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Type
            // 
            this.Label_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Type.AutoSize = true;
            this.Label_Type.Location = new System.Drawing.Point(411, 0);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(161, 50);
            this.Label_Type.TabIndex = 3;
            this.Label_Type.Text = "Type";
            this.Label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ShowInEdit
            // 
            this.Label_ShowInEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ShowInEdit.AutoSize = true;
            this.Label_ShowInEdit.Location = new System.Drawing.Point(578, 0);
            this.Label_ShowInEdit.Name = "Label_ShowInEdit";
            this.Label_ShowInEdit.Size = new System.Drawing.Size(162, 50);
            this.Label_ShowInEdit.TabIndex = 4;
            this.Label_ShowInEdit.Text = "Show In Edit";
            this.Label_ShowInEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBox_Enabled_1
            // 
            this.Enabled_CheckBoxes[0].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enabled_CheckBoxes[0].AutoSize = true;
            this.Enabled_CheckBoxes[0].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enabled_CheckBoxes[0].Checked = true;
            this.Enabled_CheckBoxes[0].CheckState = System.Windows.Forms.CheckState.Checked;
            this.Enabled_CheckBoxes[0].Enabled = false;
            this.Enabled_CheckBoxes[0].Location = new System.Drawing.Point(3, 53);
            this.Enabled_CheckBoxes[0].Name = "CheckBox_Enabled_1";
            this.Enabled_CheckBoxes[0].Size = new System.Drawing.Size(68, 44);
            this.Enabled_CheckBoxes[0].TabIndex = 5;
            this.Enabled_CheckBoxes[0].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enabled_CheckBoxes[0].UseVisualStyleBackColor = true;
            // 
            // TextBox_Name_1
            // 
            this.Name_TextBoxes[0].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_TextBoxes[0].Location = new System.Drawing.Point(77, 50);
            this.Name_TextBoxes[0].Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.Name_TextBoxes[0].Name = "Label_Name_1";
            this.Name_TextBoxes[0].Size = new System.Drawing.Size(161, 50);
            this.Name_TextBoxes[0].TabIndex = 6;
            this.Name_TextBoxes[0].Text = "ID";
            this.Name_TextBoxes[0].Enabled = false;
            // 
            // Label_DBName_1
            // 
            this.DBName_TextBoxes[0].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBName_TextBoxes[0].Location = new System.Drawing.Point(244, 50);
            this.DBName_TextBoxes[0].Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.DBName_TextBoxes[0].Name = "Label_DBName_1";
            this.DBName_TextBoxes[0].Size = new System.Drawing.Size(161, 50);
            this.DBName_TextBoxes[0].TabIndex = 7;
            this.DBName_TextBoxes[0].Text = "id";
            this.DBName_TextBoxes[0].Enabled = false;
            // 
            // CheckBox_ShowInEdit_1
            // 
            this.ShowInEdit_CheckBoxes[0].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowInEdit_CheckBoxes[0].AutoSize = true;
            this.ShowInEdit_CheckBoxes[0].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowInEdit_CheckBoxes[0].Enabled = false;
            this.ShowInEdit_CheckBoxes[0].Location = new System.Drawing.Point(578, 53);
            this.ShowInEdit_CheckBoxes[0].Name = "CheckBox_ShowInEdit_1";
            this.ShowInEdit_CheckBoxes[0].Size = new System.Drawing.Size(162, 44);
            this.ShowInEdit_CheckBoxes[0].TabIndex = 8;
            this.ShowInEdit_CheckBoxes[0].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowInEdit_CheckBoxes[0].UseVisualStyleBackColor = true;
            // 
            // CheckBox_Enabled_2
            // 
            this.Enabled_CheckBoxes[1].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enabled_CheckBoxes[1].AutoSize = true;
            this.Enabled_CheckBoxes[1].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enabled_CheckBoxes[1].Location = new System.Drawing.Point(3, 103);
            this.Enabled_CheckBoxes[1].Name = "CheckBox_Enabled_2";
            this.Enabled_CheckBoxes[1].Size = new System.Drawing.Size(68, 44);
            this.Enabled_CheckBoxes[1].TabIndex = 9;
            this.Enabled_CheckBoxes[1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enabled_CheckBoxes[1].UseVisualStyleBackColor = true;
            // 
            // TextBox_Name_2
            // 
            this.Name_TextBoxes[1].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_TextBoxes[1].Location = new System.Drawing.Point(244, 115);
            this.Name_TextBoxes[1].Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.Name_TextBoxes[1].Name = "TextBox_Name_2";
            this.Name_TextBoxes[1].Size = new System.Drawing.Size(161, 20);
            this.Name_TextBoxes[1].TabIndex = 10;
            // 
            // TextBox_DBName_2
            // 
            this.DBName_TextBoxes[1].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBName_TextBoxes[1].Location = new System.Drawing.Point(77, 115);
            this.DBName_TextBoxes[1].Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.DBName_TextBoxes[1].Name = "TextBox_DBName_2";
            this.DBName_TextBoxes[1].Size = new System.Drawing.Size(161, 20);
            this.DBName_TextBoxes[1].TabIndex = 11;
            // 
            // ComboBox_Type_2
            // 
            this.Type_ComboBoxes[0].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Type_ComboBoxes[0].FormattingEnabled = true;
            this.Type_ComboBoxes[0].Location = new System.Drawing.Point(411, 115);
            this.Type_ComboBoxes[0].Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.Type_ComboBoxes[0].Name = "ComboBox_Type_2";
            this.Type_ComboBoxes[0].Size = new System.Drawing.Size(161, 21);
            this.Type_ComboBoxes[0].TabIndex = 12;
            // 
            // CheckBox_ShowInEdit_2
            // 
            this.ShowInEdit_CheckBoxes[1].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowInEdit_CheckBoxes[1].AutoSize = true;
            this.ShowInEdit_CheckBoxes[1].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowInEdit_CheckBoxes[1].Location = new System.Drawing.Point(578, 103);
            this.ShowInEdit_CheckBoxes[1].Name = "CheckBox_ShowInEdit_2";
            this.ShowInEdit_CheckBoxes[1].Size = new System.Drawing.Size(162, 44);
            this.ShowInEdit_CheckBoxes[1].TabIndex = 13;
            this.ShowInEdit_CheckBoxes[1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowInEdit_CheckBoxes[1].UseVisualStyleBackColor = true;
            // 
            // ModuleWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FieldsGroup);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettingsGroup);
            this.Name = "ModuleWizard";
            this.Text = "Module Wizard";
            this.Load += new System.EventHandler(this.Form_Load);
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FieldsGroup.ResumeLayout(false);
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Collections.Generic.List<System.Windows.Forms.CheckBox> Enabled_CheckBoxes;
        private System.Collections.Generic.List<System.Windows.Forms.TextBox> Name_TextBoxes;
        private System.Collections.Generic.List<System.Windows.Forms.TextBox> DBName_TextBoxes;
        private System.Collections.Generic.List<System.Windows.Forms.ComboBox> Type_ComboBoxes;
        private System.Collections.Generic.List<System.Windows.Forms.CheckBox> ShowInEdit_CheckBoxes;

        private System.Windows.Forms.FolderBrowserDialog BrowserDialog_ProjectPath;
        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.TextBox TextBox_ProjectPath;
        private System.Windows.Forms.Label Label_PathDescription;
        private System.Windows.Forms.Button Buton_SelectPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_TabelName;
        private System.Windows.Forms.TextBox TextBox_TabelName;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.GroupBox FieldsGroup;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Label Label_Enabled;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_DBName;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.Label Label_ShowInEdit;
        //private System.Windows.Forms.Label Label_Name_1;
        //private System.Windows.Forms.Label Label_DBName_1;
        //private System.Windows.Forms.CheckBox CheckBox_Enabled_2;
        //private System.Windows.Forms.TextBox TextBox_Name_2;
        //private System.Windows.Forms.TextBox TextBox_DBName_2;
        //private System.Windows.Forms.ComboBox ComboBox_Type_2;
        //private System.Windows.Forms.CheckBox CheckBox_ShowInEdit_2;
        private System.Windows.Forms.VScrollBar VerticalScrollBar;
        private System.Windows.Forms.Button Button_Add;
    }
}

