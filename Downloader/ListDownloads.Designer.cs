namespace ZEMMOURI_Downloader
{
    /// <summary>
    /// ToDoc : ListDownloads
    /// </summary>
    partial class ListDownloads
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDownloads));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reDownloadSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tableModel = new XPTable.Models.TableModel();
            this.columnModel = new XPTable.Models.ColumnModel();
            this.ID_NumberColumn = new XPTable.Models.NumberColumn();
            this.State_ImageColumn = new XPTable.Models.ImageColumn();
            this.Name_TextColumn = new XPTable.Models.TextColumn();
            this.Source_TextColumn = new XPTable.Models.TextColumn();
            this.State_TextColumn = new XPTable.Models.TextColumn();
            this.Size_NumberColumn = new XPTable.Models.NumberColumn();
            this.RecievedData_NumberColumn = new XPTable.Models.NumberColumn();
            this.Progress_ProgressBarColumn = new XPTable.Models.ProgressBarColumn();
            this.StartTime_TextColumn = new XPTable.Models.TextColumn();
            this.ElapsedTime_TextColumn = new XPTable.Models.TextColumn();
            this.FinishTime_TextColumn = new XPTable.Models.TextColumn();
            this.NbTries_NumberColumn = new XPTable.Models.NumberColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStopAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSerialize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeSerialize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelNbThreads = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxNbThreads = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.tableDetail = new XPTable.Models.Table();
            this.fileStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelAllToolStripMenuItem,
            this.cancelSelectedToolStripMenuItem,
            this.toolStripSeparator1,
            this.reDownloadSelectedToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(190, 76);
            // 
            // cancelAllToolStripMenuItem
            // 
            this.cancelAllToolStripMenuItem.Name = "cancelAllToolStripMenuItem";
            this.cancelAllToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cancelAllToolStripMenuItem.Text = "Cancel All";
            // 
            // cancelSelectedToolStripMenuItem
            // 
            this.cancelSelectedToolStripMenuItem.Name = "cancelSelectedToolStripMenuItem";
            this.cancelSelectedToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cancelSelectedToolStripMenuItem.Text = "Cancel Selected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // reDownloadSelectedToolStripMenuItem
            // 
            this.reDownloadSelectedToolStripMenuItem.Name = "reDownloadSelectedToolStripMenuItem";
            this.reDownloadSelectedToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reDownloadSelectedToolStripMenuItem.Text = "ReDownload Selected";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ready.bmp");
            this.imageList.Images.SetKeyName(1, "downloading.bmp");
            this.imageList.Images.SetKeyName(2, "stoped.bmp");
            this.imageList.Images.SetKeyName(3, "error.bmp");
            this.imageList.Images.SetKeyName(4, "ok.bmp");
            // 
            // columnModel
            // 
            this.columnModel.Columns.AddRange(new XPTable.Models.Column[] {
            this.ID_NumberColumn,
            this.State_ImageColumn,
            this.Name_TextColumn,
            this.Source_TextColumn,
            this.State_TextColumn,
            this.Size_NumberColumn,
            this.RecievedData_NumberColumn,
            this.Progress_ProgressBarColumn,
            this.StartTime_TextColumn,
            this.ElapsedTime_TextColumn,
            this.FinishTime_TextColumn,
            this.NbTries_NumberColumn});
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReDownload,
            this.toolStripButtonStop,
            this.toolStripButtonStopAll,
            this.toolStripSeparator2,
            this.toolStripButtonSerialize,
            this.toolStripButtonDeSerialize,
            this.toolStripSeparator3,
            this.toolStripLabelNbThreads,
            this.toolStripComboBoxNbThreads,
            this.toolStripButtonClose});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(930, 25);
            this.toolStrip.TabIndex = 89;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonReDownload
            // 
            this.toolStripButtonReDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReDownload.Image")));
            this.toolStripButtonReDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReDownload.Name = "toolStripButtonReDownload";
            this.toolStripButtonReDownload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReDownload.Text = "toolStripButton1";
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "toolStripButton2";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonStopAll
            // 
            this.toolStripButtonStopAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStopAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStopAll.Image")));
            this.toolStripButtonStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStopAll.Name = "toolStripButtonStopAll";
            this.toolStripButtonStopAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStopAll.Text = "toolStripButton3";
            this.toolStripButtonStopAll.Click += new System.EventHandler(this.toolStripButtonStopAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSerialize
            // 
            this.toolStripButtonSerialize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSerialize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSerialize.Image")));
            this.toolStripButtonSerialize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSerialize.Name = "toolStripButtonSerialize";
            this.toolStripButtonSerialize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSerialize.Text = "toolStripButton4";
            this.toolStripButtonSerialize.Click += new System.EventHandler(this.toolStripButtonSerialize_Click);
            // 
            // toolStripButtonDeSerialize
            // 
            this.toolStripButtonDeSerialize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeSerialize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeSerialize.Image")));
            this.toolStripButtonDeSerialize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeSerialize.Name = "toolStripButtonDeSerialize";
            this.toolStripButtonDeSerialize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeSerialize.Text = "toolStripButton5";
            this.toolStripButtonDeSerialize.Click += new System.EventHandler(this.toolStripButtonDeSerialize_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelNbThreads
            // 
            this.toolStripLabelNbThreads.Name = "toolStripLabelNbThreads";
            this.toolStripLabelNbThreads.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabelNbThreads.Text = "Threads Number";
            // 
            // toolStripComboBoxNbThreads
            // 
            this.toolStripComboBoxNbThreads.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20"});
            this.toolStripComboBoxNbThreads.Name = "toolStripComboBoxNbThreads";
            this.toolStripComboBoxNbThreads.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxNbThreads.Text = "5";
            this.toolStripComboBoxNbThreads.Validating += new System.ComponentModel.CancelEventHandler(this.toolStripComboBoxNbThreads_Validating);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClose.Text = "Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // tableDetail
            // 
            this.tableDetail.ColumnModel = this.columnModel;
            this.tableDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDetail.Location = new System.Drawing.Point(0, 25);
            this.tableDetail.Name = "tableDetail";
            this.tableDetail.Size = new System.Drawing.Size(930, 223);
            this.tableDetail.TabIndex = 1;
            this.tableDetail.TableModel = this.tableModel;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save As";
            // 
            // ListDownloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableDetail);
            this.Controls.Add(this.toolStrip);
            this.Name = "ListDownloads";
            this.Size = new System.Drawing.Size(930, 248);
            this.contextMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileStateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reDownloadSelectedToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.BindingSource fileStateBindingSource;
        private XPTable.Models.TableModel tableModel;
        private XPTable.Models.ColumnModel columnModel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonReDownload;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonStopAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSerialize;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeSerialize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxNbThreads;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNbThreads;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private XPTable.Models.Table tableDetail;
        private XPTable.Models.ImageColumn State_ImageColumn;
        private XPTable.Models.TextColumn Name_TextColumn;
        private XPTable.Models.TextColumn Source_TextColumn;
        private XPTable.Models.TextColumn State_TextColumn;
        private XPTable.Models.NumberColumn Size_NumberColumn;
        private XPTable.Models.NumberColumn RecievedData_NumberColumn;
        private XPTable.Models.ProgressBarColumn Progress_ProgressBarColumn;
        private XPTable.Models.TextColumn StartTime_TextColumn;
        private XPTable.Models.TextColumn ElapsedTime_TextColumn;
        private XPTable.Models.TextColumn FinishTime_TextColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private XPTable.Models.NumberColumn ID_NumberColumn;
        private XPTable.Models.NumberColumn NbTries_NumberColumn;

    }
}
