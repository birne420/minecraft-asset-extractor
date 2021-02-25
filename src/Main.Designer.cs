namespace Minecraft_AssetExtraction {
    partial class Main {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.LabelTitle = new System.Windows.Forms.Label();
            this.GroupBoxJar = new System.Windows.Forms.GroupBox();
            this.ComboBoxJar = new System.Windows.Forms.ComboBox();
            this.GroupBoxJarFilter = new System.Windows.Forms.GroupBox();
            this.RadioButtonJarAssets = new System.Windows.Forms.RadioButton();
            this.RadioButtonJarFilter = new System.Windows.Forms.RadioButton();
            this.CheckBoxJarFilterPNG = new System.Windows.Forms.CheckBox();
            this.CheckBoxJarFilterJSON = new System.Windows.Forms.CheckBox();
            this.GroupBoxObjects = new System.Windows.Forms.GroupBox();
            this.CheckBoxJarFilterOGG = new System.Windows.Forms.CheckBox();
            this.CheckBoxJarFilterLANG = new System.Windows.Forms.CheckBox();
            this.CheckBoxJarFilterMCMETA = new System.Windows.Forms.CheckBox();
            this.ComboBoxHashMap = new System.Windows.Forms.ComboBox();
            this.RichTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.GroupBoxLog = new System.Windows.Forms.GroupBox();
            this.ButtonExtract = new System.Windows.Forms.Button();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.GroupBoxJar.SuspendLayout();
            this.GroupBoxJarFilter.SuspendLayout();
            this.GroupBoxObjects.SuspendLayout();
            this.GroupBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(752, 50);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Minecraft Asset Extractor";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxJar
            // 
            this.GroupBoxJar.Controls.Add(this.GroupBoxJarFilter);
            this.GroupBoxJar.Controls.Add(this.ComboBoxJar);
            this.GroupBoxJar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxJar.Location = new System.Drawing.Point(12, 62);
            this.GroupBoxJar.Name = "GroupBoxJar";
            this.GroupBoxJar.Size = new System.Drawing.Size(335, 243);
            this.GroupBoxJar.TabIndex = 0;
            this.GroupBoxJar.TabStop = false;
            this.GroupBoxJar.Text = "Jar extraction";
            // 
            // ComboBoxJar
            // 
            this.ComboBoxJar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxJar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxJar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxJar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxJar.FormattingEnabled = true;
            this.ComboBoxJar.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxJar.Name = "ComboBoxJar";
            this.ComboBoxJar.Size = new System.Drawing.Size(323, 24);
            this.ComboBoxJar.TabIndex = 0;
            this.ComboBoxJar.SelectedIndexChanged += new System.EventHandler(this.ComboBoxJar_SelectedIndexChanged);
            // 
            // GroupBoxJarFilter
            // 
            this.GroupBoxJarFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxJarFilter.Controls.Add(this.CheckBoxJarFilterMCMETA);
            this.GroupBoxJarFilter.Controls.Add(this.CheckBoxJarFilterLANG);
            this.GroupBoxJarFilter.Controls.Add(this.CheckBoxJarFilterOGG);
            this.GroupBoxJarFilter.Controls.Add(this.CheckBoxJarFilterJSON);
            this.GroupBoxJarFilter.Controls.Add(this.CheckBoxJarFilterPNG);
            this.GroupBoxJarFilter.Controls.Add(this.RadioButtonJarFilter);
            this.GroupBoxJarFilter.Controls.Add(this.RadioButtonJarAssets);
            this.GroupBoxJarFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBoxJarFilter.Location = new System.Drawing.Point(6, 49);
            this.GroupBoxJarFilter.Name = "GroupBoxJarFilter";
            this.GroupBoxJarFilter.Size = new System.Drawing.Size(323, 188);
            this.GroupBoxJarFilter.TabIndex = 1;
            this.GroupBoxJarFilter.TabStop = false;
            this.GroupBoxJarFilter.Text = "Target files";
            // 
            // RadioButtonJarAssets
            // 
            this.RadioButtonJarAssets.AutoSize = true;
            this.RadioButtonJarAssets.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonJarAssets.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonJarAssets.Name = "RadioButtonJarAssets";
            this.RadioButtonJarAssets.Size = new System.Drawing.Size(152, 18);
            this.RadioButtonJarAssets.TabIndex = 0;
            this.RadioButtonJarAssets.Text = "Asset directory (1.6+ only)";
            this.RadioButtonJarAssets.UseVisualStyleBackColor = true;
            this.RadioButtonJarAssets.CheckedChanged += new System.EventHandler(this.RadioButtonJarAssets_CheckedChanged);
            // 
            // RadioButtonJarFilter
            // 
            this.RadioButtonJarFilter.AutoSize = true;
            this.RadioButtonJarFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonJarFilter.Location = new System.Drawing.Point(6, 43);
            this.RadioButtonJarFilter.Name = "RadioButtonJarFilter";
            this.RadioButtonJarFilter.Size = new System.Drawing.Size(53, 18);
            this.RadioButtonJarFilter.TabIndex = 1;
            this.RadioButtonJarFilter.Text = "Filter";
            this.RadioButtonJarFilter.UseVisualStyleBackColor = true;
            // 
            // CheckBoxJarFilterPNG
            // 
            this.CheckBoxJarFilterPNG.AutoSize = true;
            this.CheckBoxJarFilterPNG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxJarFilterPNG.Location = new System.Drawing.Point(22, 67);
            this.CheckBoxJarFilterPNG.Name = "CheckBoxJarFilterPNG";
            this.CheckBoxJarFilterPNG.Size = new System.Drawing.Size(74, 18);
            this.CheckBoxJarFilterPNG.TabIndex = 2;
            this.CheckBoxJarFilterPNG.Text = ".png files";
            this.CheckBoxJarFilterPNG.UseVisualStyleBackColor = true;
            this.CheckBoxJarFilterPNG.CheckedChanged += new System.EventHandler(this.CheckBoxJarFilterPNG_CheckedChanged);
            // 
            // CheckBoxJarFilterJSON
            // 
            this.CheckBoxJarFilterJSON.AutoSize = true;
            this.CheckBoxJarFilterJSON.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxJarFilterJSON.Location = new System.Drawing.Point(22, 91);
            this.CheckBoxJarFilterJSON.Name = "CheckBoxJarFilterJSON";
            this.CheckBoxJarFilterJSON.Size = new System.Drawing.Size(75, 18);
            this.CheckBoxJarFilterJSON.TabIndex = 3;
            this.CheckBoxJarFilterJSON.Text = ".json files";
            this.CheckBoxJarFilterJSON.UseVisualStyleBackColor = true;
            this.CheckBoxJarFilterJSON.CheckedChanged += new System.EventHandler(this.CheckBoxJarFilterJSON_CheckedChanged);
            // 
            // GroupBoxObjects
            // 
            this.GroupBoxObjects.Controls.Add(this.ComboBoxHashMap);
            this.GroupBoxObjects.Location = new System.Drawing.Point(12, 311);
            this.GroupBoxObjects.Name = "GroupBoxObjects";
            this.GroupBoxObjects.Size = new System.Drawing.Size(335, 51);
            this.GroupBoxObjects.TabIndex = 1;
            this.GroupBoxObjects.TabStop = false;
            this.GroupBoxObjects.Text = "Object unmapping";
            // 
            // CheckBoxJarFilterOGG
            // 
            this.CheckBoxJarFilterOGG.AutoSize = true;
            this.CheckBoxJarFilterOGG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxJarFilterOGG.Location = new System.Drawing.Point(22, 115);
            this.CheckBoxJarFilterOGG.Name = "CheckBoxJarFilterOGG";
            this.CheckBoxJarFilterOGG.Size = new System.Drawing.Size(74, 18);
            this.CheckBoxJarFilterOGG.TabIndex = 4;
            this.CheckBoxJarFilterOGG.Text = ".ogg files";
            this.CheckBoxJarFilterOGG.UseVisualStyleBackColor = true;
            this.CheckBoxJarFilterOGG.CheckedChanged += new System.EventHandler(this.CheckBoxJarFilterOGG_CheckedChanged);
            // 
            // CheckBoxJarFilterLANG
            // 
            this.CheckBoxJarFilterLANG.AutoSize = true;
            this.CheckBoxJarFilterLANG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxJarFilterLANG.Location = new System.Drawing.Point(22, 139);
            this.CheckBoxJarFilterLANG.Name = "CheckBoxJarFilterLANG";
            this.CheckBoxJarFilterLANG.Size = new System.Drawing.Size(141, 18);
            this.CheckBoxJarFilterLANG.TabIndex = 5;
            this.CheckBoxJarFilterLANG.Text = ".lang files (old versions)";
            this.CheckBoxJarFilterLANG.UseVisualStyleBackColor = true;
            this.CheckBoxJarFilterLANG.CheckedChanged += new System.EventHandler(this.CheckBoxJarFilterLANG_CheckedChanged);
            // 
            // CheckBoxJarFilterMCMETA
            // 
            this.CheckBoxJarFilterMCMETA.AutoSize = true;
            this.CheckBoxJarFilterMCMETA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxJarFilterMCMETA.Location = new System.Drawing.Point(22, 163);
            this.CheckBoxJarFilterMCMETA.Name = "CheckBoxJarFilterMCMETA";
            this.CheckBoxJarFilterMCMETA.Size = new System.Drawing.Size(208, 18);
            this.CheckBoxJarFilterMCMETA.TabIndex = 6;
            this.CheckBoxJarFilterMCMETA.Text = ".mcmeta files (commonly old versions)";
            this.CheckBoxJarFilterMCMETA.UseVisualStyleBackColor = true;
            this.CheckBoxJarFilterMCMETA.CheckedChanged += new System.EventHandler(this.CheckBoxJarFilterMCMETA_CheckedChanged);
            // 
            // ComboBoxHashMap
            // 
            this.ComboBoxHashMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHashMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHashMap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxHashMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxHashMap.FormattingEnabled = true;
            this.ComboBoxHashMap.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxHashMap.Name = "ComboBoxHashMap";
            this.ComboBoxHashMap.Size = new System.Drawing.Size(323, 24);
            this.ComboBoxHashMap.TabIndex = 0;
            this.ComboBoxHashMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHashMap_SelectedIndexChanged);
            // 
            // RichTextBoxLog
            // 
            this.RichTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxLog.Location = new System.Drawing.Point(3, 16);
            this.RichTextBoxLog.Name = "RichTextBoxLog";
            this.RichTextBoxLog.ReadOnly = true;
            this.RichTextBoxLog.Size = new System.Drawing.Size(405, 344);
            this.RichTextBoxLog.TabIndex = 0;
            this.RichTextBoxLog.Text = "";
            // 
            // GroupBoxLog
            // 
            this.GroupBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxLog.Controls.Add(this.RichTextBoxLog);
            this.GroupBoxLog.Location = new System.Drawing.Point(353, 62);
            this.GroupBoxLog.Name = "GroupBoxLog";
            this.GroupBoxLog.Size = new System.Drawing.Size(411, 363);
            this.GroupBoxLog.TabIndex = 5;
            this.GroupBoxLog.TabStop = false;
            this.GroupBoxLog.Text = "Log";
            // 
            // ButtonExtract
            // 
            this.ButtonExtract.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonExtract.Location = new System.Drawing.Point(12, 400);
            this.ButtonExtract.Name = "ButtonExtract";
            this.ButtonExtract.Size = new System.Drawing.Size(335, 26);
            this.ButtonExtract.TabIndex = 4;
            this.ButtonExtract.Text = "Start asset extraction";
            this.ButtonExtract.UseVisualStyleBackColor = true;
            this.ButtonExtract.Click += new System.EventHandler(this.ButtonExtract_Click);
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOutput.Location = new System.Drawing.Point(12, 368);
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.Size = new System.Drawing.Size(303, 26);
            this.TextBoxOutput.TabIndex = 2;
            this.TextBoxOutput.TextChanged += new System.EventHandler(this.TextBoxOutput_TextChanged);
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse.Location = new System.Drawing.Point(321, 368);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(26, 26);
            this.ButtonBrowse.TabIndex = 3;
            this.ButtonBrowse.Text = "...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 438);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.ButtonExtract);
            this.Controls.Add(this.GroupBoxLog);
            this.Controls.Add(this.GroupBoxObjects);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.GroupBoxJar);
            this.MinimumSize = new System.Drawing.Size(792, 477);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Asset Extractor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GroupBoxJar.ResumeLayout(false);
            this.GroupBoxJarFilter.ResumeLayout(false);
            this.GroupBoxJarFilter.PerformLayout();
            this.GroupBoxObjects.ResumeLayout(false);
            this.GroupBoxLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.GroupBox GroupBoxJar;
        private System.Windows.Forms.ComboBox ComboBoxJar;
        private System.Windows.Forms.GroupBox GroupBoxJarFilter;
        private System.Windows.Forms.RadioButton RadioButtonJarAssets;
        private System.Windows.Forms.RadioButton RadioButtonJarFilter;
        private System.Windows.Forms.CheckBox CheckBoxJarFilterPNG;
        private System.Windows.Forms.CheckBox CheckBoxJarFilterJSON;
        private System.Windows.Forms.GroupBox GroupBoxObjects;
        private System.Windows.Forms.CheckBox CheckBoxJarFilterLANG;
        private System.Windows.Forms.CheckBox CheckBoxJarFilterOGG;
        private System.Windows.Forms.CheckBox CheckBoxJarFilterMCMETA;
        private System.Windows.Forms.ComboBox ComboBoxHashMap;
        private System.Windows.Forms.RichTextBox RichTextBoxLog;
        private System.Windows.Forms.GroupBox GroupBoxLog;
        private System.Windows.Forms.Button ButtonExtract;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private System.Windows.Forms.Button ButtonBrowse;
    }
}

