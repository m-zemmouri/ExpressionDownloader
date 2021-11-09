namespace ZEMMOURI_Downloader
{
    partial class FormFileExists
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonOverwrite = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxDefaultResponse = new System.Windows.Forms.CheckBox();
            this.buttonAutoRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The file :";
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Location = new System.Drawing.Point(57, 32);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(48, 13);
            this.LabelFileName.TabIndex = 0;
            this.LabelFileName.Text = "fileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "is already exists, what do you prefer";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(14, 113);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(90, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open Existing";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonOverwrite
            // 
            this.buttonOverwrite.Location = new System.Drawing.Point(110, 113);
            this.buttonOverwrite.Name = "buttonOverwrite";
            this.buttonOverwrite.Size = new System.Drawing.Size(90, 23);
            this.buttonOverwrite.TabIndex = 2;
            this.buttonOverwrite.Text = "Overwrite";
            this.buttonOverwrite.UseVisualStyleBackColor = true;
            this.buttonOverwrite.Click += new System.EventHandler(this.buttonOverwrite_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(206, 113);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(90, 23);
            this.buttonSaveAs.TabIndex = 3;
            this.buttonSaveAs.Text = "Save As ...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(400, 113);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxDefaultResponse
            // 
            this.checkBoxDefaultResponse.AutoSize = true;
            this.checkBoxDefaultResponse.Location = new System.Drawing.Point(12, 85);
            this.checkBoxDefaultResponse.Name = "checkBoxDefaultResponse";
            this.checkBoxDefaultResponse.Size = new System.Drawing.Size(144, 17);
            this.checkBoxDefaultResponse.TabIndex = 5;
            this.checkBoxDefaultResponse.Text = "Always use this response";
            this.checkBoxDefaultResponse.UseVisualStyleBackColor = true;
            // 
            // buttonAutoRename
            // 
            this.buttonAutoRename.Location = new System.Drawing.Point(302, 113);
            this.buttonAutoRename.Name = "buttonAutoRename";
            this.buttonAutoRename.Size = new System.Drawing.Size(90, 23);
            this.buttonAutoRename.TabIndex = 3;
            this.buttonAutoRename.Text = "Auto Rename";
            this.buttonAutoRename.UseVisualStyleBackColor = true;
            this.buttonAutoRename.Click += new System.EventHandler(this.buttonAutoRename_Click);
            // 
            // FormFileExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(520, 150);
            this.Controls.Add(this.checkBoxDefaultResponse);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAutoRename);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonOverwrite);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFileExists";
            this.Text = "File Alredy Exists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonOverwrite;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonCancel;
        internal System.Windows.Forms.CheckBox checkBoxDefaultResponse;
        private System.Windows.Forms.Button buttonAutoRename;
    }
}