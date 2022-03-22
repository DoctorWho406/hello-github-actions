using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WebHRModuleWizard {
    public partial class ModuleWizard : Form {
        enum FileType {
            Controller,
            Model,
            Count
        }

        enum FieldType {
            text,
            number,
            date,
            datetime
        }

        private List<List<String>> filesLines;
        private FileStream fileStream;

        private string[] fieldTypes;

        public ModuleWizard() {
            InitializeComponent();
            BrowserDialog_ProjectPath.ShowNewFolderButton = false;

            //LOAD TEMPLATE
            filesLines = new List<List<string>>();
            for (int i = 0; i < (int)FileType.Count; i++) {
                filesLines.Add(new List<string>());
            }

            //CONTROLLER
            fileStream = new FileStream(Directory.GetCurrentDirectory() + "/Assets/CONTROLLER.php", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) {
                    filesLines[(int)FileType.Controller].Add(line);
                }
            }

            //MODEL
            fileStream = new FileStream(Directory.GetCurrentDirectory() + "/Assets/MODEL.php", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8)) {
                string line;
                while ((line = streamReader.ReadLine()) != null) {
                    filesLines[(int)FileType.Model].Add(line);
                }
            }

            fieldTypes = Enum.GetValues(typeof(FieldType)) as string[];
            Type_ComboBoxes[0].Items.AddRange(fieldTypes ?? new string[0]);
        }

        private void Form_Load(object sender, EventArgs e) {

        }

        private void ProjectPathBrowserDialog_HelpRequest(object sender, EventArgs e) {
        }

        private void ProjectPath_TextChanged(object sender, EventArgs e) {

        }

        private void ButtonSelectPath_Click(object sender, EventArgs e) {
            if (Directory.Exists(TextBox_ProjectPath.Text)) {
                BrowserDialog_ProjectPath.SelectedPath = TextBox_ProjectPath.Text;
            } else {
                BrowserDialog_ProjectPath.SelectedPath = "";
            }
            DialogResult resul = BrowserDialog_ProjectPath.ShowDialog();
            if (resul == DialogResult.OK) {
                TextBox_ProjectPath.Text = BrowserDialog_ProjectPath.SelectedPath;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e) {
            TableLayout.RowCount++;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));

            CreateRow();

            TableLayout.Controls.Add(Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1], 0, TableLayout.RowCount - 1);
            TableLayout.Controls.Add(Name_TextBoxes[Name_TextBoxes.Count - 1], 1, TableLayout.RowCount - 1);
            TableLayout.Controls.Add(DBName_TextBoxes[DBName_TextBoxes.Count - 1], 2, TableLayout.RowCount - 1);
            TableLayout.Controls.Add(Type_ComboBoxes[Type_ComboBoxes.Count - 1], 3, TableLayout.RowCount - 1);
            TableLayout.Controls.Add(ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1], 4, TableLayout.RowCount - 1);
        }

        private void CreateRow() {
            int lastTabIndex = ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].TabIndex + 1;
            // 
            // CheckBox_Enabled_
            //
            Enabled_CheckBoxes.Add(new CheckBox());
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].AutoSize = true;
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].Location = new System.Drawing.Point(3, 103);
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].Name = "CheckBox_Enabled_" + Enabled_CheckBoxes.Count;
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].Size = new System.Drawing.Size(68, 44);
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].TabIndex = ++lastTabIndex;
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Enabled_CheckBoxes[Enabled_CheckBoxes.Count - 1].UseVisualStyleBackColor = true;

            // 
            // TextBox_Name_
            //
            Name_TextBoxes.Add(new TextBox());
            Name_TextBoxes[Name_TextBoxes.Count - 1].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Name_TextBoxes[Name_TextBoxes.Count - 1].Location = new System.Drawing.Point(244, 115);
            Name_TextBoxes[Name_TextBoxes.Count - 1].Margin = new Padding(3, 15, 3, 15);
            Name_TextBoxes[Name_TextBoxes.Count - 1].Name = "TextBox_Name_" + Name_TextBoxes.Count;
            Name_TextBoxes[Name_TextBoxes.Count - 1].Size = new System.Drawing.Size(161, 20);
            Name_TextBoxes[Name_TextBoxes.Count - 1].TabIndex = ++lastTabIndex;

            // 
            // TextBox_DBName_2
            // 
            DBName_TextBoxes.Add(new TextBox());
            DBName_TextBoxes[DBName_TextBoxes.Count - 1].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DBName_TextBoxes[DBName_TextBoxes.Count - 1].Location = new System.Drawing.Point(77, 115);
            DBName_TextBoxes[DBName_TextBoxes.Count - 1].Margin = new Padding(3, 15, 3, 15);
            DBName_TextBoxes[DBName_TextBoxes.Count - 1].Name = "TextBox_DBName_" + DBName_TextBoxes.Count;
            DBName_TextBoxes[DBName_TextBoxes.Count - 1].Size = new System.Drawing.Size(161, 20);
            DBName_TextBoxes[DBName_TextBoxes.Count - 1].TabIndex = ++lastTabIndex;

            // 
            // ComboBox_Type_2
            // 
            Type_ComboBoxes.Add(new ComboBox());
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].FormattingEnabled = true;
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].Location = new System.Drawing.Point(411, 115);
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].Margin = new Padding(3, 15, 3, 15);
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].Name = "ComboBox_Type_" + Type_ComboBoxes.Count + 1;
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].Size = new System.Drawing.Size(161, 21);
            Type_ComboBoxes[Type_ComboBoxes.Count - 1].TabIndex = ++lastTabIndex;

            // 
            // CheckBox_ShowInEdit_2
            // 
            ShowInEdit_CheckBoxes.Add(new CheckBox());
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].AutoSize = true;
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].Location = new System.Drawing.Point(578, 103);
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].Name = "CheckBox_ShowInEdit_" + ShowInEdit_CheckBoxes.Count;
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].Size = new System.Drawing.Size(162, 44);
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].TabIndex = ++lastTabIndex;
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ShowInEdit_CheckBoxes[ShowInEdit_CheckBoxes.Count - 1].UseVisualStyleBackColor = true;
        }
    }
}