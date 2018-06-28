namespace MainGUI
{
    partial class Main
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_OutputType = new System.Windows.Forms.ComboBox();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_SelectFolder = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Location = new System.Windows.Forms.ListBox();
            this.listBox_Type = new System.Windows.Forms.ListBox();
            this.listBox_Name = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button_OpenMacro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_CreateMacro = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 77;
            this.label5.Text = "Output Type";
            // 
            // comboBox_OutputType
            // 
            this.comboBox_OutputType.DisplayMember = "ta";
            this.comboBox_OutputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_OutputType.FormattingEnabled = true;
            this.comboBox_OutputType.Location = new System.Drawing.Point(578, 523);
            this.comboBox_OutputType.Name = "comboBox_OutputType";
            this.comboBox_OutputType.Size = new System.Drawing.Size(483, 34);
            this.comboBox_OutputType.TabIndex = 76;
            this.comboBox_OutputType.Text = "Please Select An Option";
            this.comboBox_OutputType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_OutputType_KeyPress);
            // 
            // textBoxProgress
            // 
            this.textBoxProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgress.Location = new System.Drawing.Point(522, 727);
            this.textBoxProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxProgress.Name = "textBoxProgress";
            this.textBoxProgress.Size = new System.Drawing.Size(158, 35);
            this.textBoxProgress.TabIndex = 75;
            this.textBoxProgress.Text = "Line x of y";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(522, 683);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 35);
            this.progressBar1.TabIndex = 74;
            // 
            // button_SelectFolder
            // 
            this.button_SelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectFolder.Location = new System.Drawing.Point(1115, 501);
            this.button_SelectFolder.Name = "button_SelectFolder";
            this.button_SelectFolder.Size = new System.Drawing.Size(128, 75);
            this.button_SelectFolder.TabIndex = 73;
            this.button_SelectFolder.Text = "Select Folder";
            this.button_SelectFolder.UseVisualStyleBackColor = true;
            this.button_SelectFolder.Click += new System.EventHandler(this.button_SelectFolder_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(539, 594);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(128, 75);
            this.buttonConvert.TabIndex = 72;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFile.Location = new System.Drawing.Point(12, 521);
            this.textBoxFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(530, 35);
            this.textBoxFile.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "File Name";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolderPath.Location = new System.Drawing.Point(12, 440);
            this.textBoxFolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(1231, 35);
            this.textBoxFolderPath.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "Save Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 66;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Name";
            // 
            // listBox_Location
            // 
            this.listBox_Location.FormattingEnabled = true;
            this.listBox_Location.ItemHeight = 20;
            this.listBox_Location.Location = new System.Drawing.Point(578, 167);
            this.listBox_Location.Name = "listBox_Location";
            this.listBox_Location.Size = new System.Drawing.Size(665, 224);
            this.listBox_Location.TabIndex = 64;
            // 
            // listBox_Type
            // 
            this.listBox_Type.FormattingEnabled = true;
            this.listBox_Type.ItemHeight = 20;
            this.listBox_Type.Location = new System.Drawing.Point(394, 167);
            this.listBox_Type.Name = "listBox_Type";
            this.listBox_Type.Size = new System.Drawing.Size(148, 224);
            this.listBox_Type.TabIndex = 63;
            // 
            // listBox_Name
            // 
            this.listBox_Name.FormattingEnabled = true;
            this.listBox_Name.ItemHeight = 20;
            this.listBox_Name.Location = new System.Drawing.Point(12, 167);
            this.listBox_Name.Name = "listBox_Name";
            this.listBox_Name.Size = new System.Drawing.Size(339, 224);
            this.listBox_Name.TabIndex = 62;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button_OpenMacro
            // 
            this.button_OpenMacro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenMacro.Location = new System.Drawing.Point(342, 35);
            this.button_OpenMacro.Name = "button_OpenMacro";
            this.button_OpenMacro.Size = new System.Drawing.Size(200, 75);
            this.button_OpenMacro.TabIndex = 78;
            this.button_OpenMacro.Text = "Open Macro";
            this.button_OpenMacro.UseVisualStyleBackColor = true;
            this.button_OpenMacro.Click += new System.EventHandler(this.button_OpenMacro_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(673, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 75);
            this.button2.TabIndex = 79;
            this.button2.Text = "Import Macro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_CreateMacro
            // 
            this.button_CreateMacro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateMacro.Location = new System.Drawing.Point(21, 35);
            this.button_CreateMacro.Name = "button_CreateMacro";
            this.button_CreateMacro.Size = new System.Drawing.Size(200, 75);
            this.button_CreateMacro.TabIndex = 80;
            this.button_CreateMacro.Text = "Create Macro";
            this.button_CreateMacro.UseVisualStyleBackColor = true;
            this.button_CreateMacro.Click += new System.EventHandler(this.button_CreateMacro_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(998, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 75);
            this.button4.TabIndex = 81;
            this.button4.Text = "Edit Selected Macro";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 815);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_CreateMacro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_OpenMacro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_OutputType);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_SelectFolder);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Location);
            this.Controls.Add(this.listBox_Type);
            this.Controls.Add(this.listBox_Name);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_OutputType;
        private System.Windows.Forms.TextBox textBoxProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_SelectFolder;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Location;
        private System.Windows.Forms.ListBox listBox_Type;
        private System.Windows.Forms.ListBox listBox_Name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button_OpenMacro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_CreateMacro;
        private System.Windows.Forms.Button button4;
    }
}

