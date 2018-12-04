namespace SwissTransportUI
{
    partial class applicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(applicationForm));
            this.tbpSearchConnection = new System.Windows.Forms.TabPage();
            this.grpConnections = new System.Windows.Forms.GroupBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.colDeparutreTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearchConnection = new System.Windows.Forms.GroupBox();
            this.cmbFinalstation = new System.Windows.Forms.ComboBox();
            this.cmbStartstation = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinalstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.tbcNagivation = new System.Windows.Forms.TabControl();
            this.tbpDeparture = new System.Windows.Forms.TabPage();
            this.grpDeparture = new System.Windows.Forms.GroupBox();
            this.dgvDepartureTable = new System.Windows.Forms.DataGridView();
            this.colLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrivalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tbpSearchConnection.SuspendLayout();
            this.grpConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.grpSearchConnection.SuspendLayout();
            this.tbcNagivation.SuspendLayout();
            this.tbpDeparture.SuspendLayout();
            this.grpDeparture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartureTable)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpSearchConnection
            // 
            this.tbpSearchConnection.Controls.Add(this.grpConnections);
            this.tbpSearchConnection.Controls.Add(this.grpSearchConnection);
            this.tbpSearchConnection.Location = new System.Drawing.Point(4, 22);
            this.tbpSearchConnection.Name = "tbpSearchConnection";
            this.tbpSearchConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearchConnection.Size = new System.Drawing.Size(466, 436);
            this.tbpSearchConnection.TabIndex = 1;
            this.tbpSearchConnection.Text = "Verbindungen suchen";
            this.tbpSearchConnection.UseVisualStyleBackColor = true;
            // 
            // grpConnections
            // 
            this.grpConnections.Controls.Add(this.dgvConnections);
            this.grpConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConnections.Location = new System.Drawing.Point(3, 184);
            this.grpConnections.Name = "grpConnections";
            this.grpConnections.Size = new System.Drawing.Size(460, 249);
            this.grpConnections.TabIndex = 1;
            this.grpConnections.TabStop = false;
            this.grpConnections.Text = "Verbindungen";
            // 
            // dgvConnections
            // 
            this.dgvConnections.AllowUserToAddRows = false;
            this.dgvConnections.AllowUserToDeleteRows = false;
            this.dgvConnections.AllowUserToResizeColumns = false;
            this.dgvConnections.AllowUserToResizeRows = false;
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeparutreTime,
            this.colStartstation,
            this.colDuration,
            this.colFinalstation});
            this.dgvConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConnections.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvConnections.Location = new System.Drawing.Point(3, 16);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.ReadOnly = true;
            this.dgvConnections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConnections.Size = new System.Drawing.Size(454, 230);
            this.dgvConnections.TabIndex = 0;
            this.dgvConnections.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConnections_CellDoubleClick);
            // 
            // colDeparutreTime
            // 
            this.colDeparutreTime.HeaderText = "Abfahrtszeit";
            this.colDeparutreTime.Name = "colDeparutreTime";
            this.colDeparutreTime.ReadOnly = true;
            this.colDeparutreTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDeparutreTime.Width = 75;
            // 
            // colStartstation
            // 
            this.colStartstation.HeaderText = "Startstation";
            this.colStartstation.MinimumWidth = 10;
            this.colStartstation.Name = "colStartstation";
            this.colStartstation.ReadOnly = true;
            this.colStartstation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStartstation.Width = 125;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "Reisezeit";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Width = 75;
            // 
            // colFinalstation
            // 
            this.colFinalstation.HeaderText = "Ankunfrsstation";
            this.colFinalstation.Name = "colFinalstation";
            this.colFinalstation.ReadOnly = true;
            this.colFinalstation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFinalstation.Width = 125;
            // 
            // grpSearchConnection
            // 
            this.grpSearchConnection.Controls.Add(this.cmbFinalstation);
            this.grpSearchConnection.Controls.Add(this.cmbStartstation);
            this.grpSearchConnection.Controls.Add(this.dtpTime);
            this.grpSearchConnection.Controls.Add(this.lblDate);
            this.grpSearchConnection.Controls.Add(this.dtpDate);
            this.grpSearchConnection.Controls.Add(this.lblFinalstation);
            this.grpSearchConnection.Controls.Add(this.lblStartstation);
            this.grpSearchConnection.Controls.Add(this.btnSearchConnection);
            this.grpSearchConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchConnection.Location = new System.Drawing.Point(3, 3);
            this.grpSearchConnection.Name = "grpSearchConnection";
            this.grpSearchConnection.Size = new System.Drawing.Size(460, 181);
            this.grpSearchConnection.TabIndex = 0;
            this.grpSearchConnection.TabStop = false;
            this.grpSearchConnection.Text = "Verbindungen suchen";
            // 
            // cmbFinalstation
            // 
            this.cmbFinalstation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFinalstation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFinalstation.FormattingEnabled = true;
            this.cmbFinalstation.Location = new System.Drawing.Point(279, 62);
            this.cmbFinalstation.MaximumSize = new System.Drawing.Size(164, 0);
            this.cmbFinalstation.MinimumSize = new System.Drawing.Size(164, 0);
            this.cmbFinalstation.Name = "cmbFinalstation";
            this.cmbFinalstation.Size = new System.Drawing.Size(164, 21);
            this.cmbFinalstation.TabIndex = 16;
            this.cmbFinalstation.TextChanged += new System.EventHandler(this.autoComplete);
            // 
            // cmbStartstation
            // 
            this.cmbStartstation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStartstation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStartstation.FormattingEnabled = true;
            this.cmbStartstation.Location = new System.Drawing.Point(279, 24);
            this.cmbStartstation.MaximumSize = new System.Drawing.Size(164, 0);
            this.cmbStartstation.MinimumSize = new System.Drawing.Size(164, 0);
            this.cmbStartstation.Name = "cmbStartstation";
            this.cmbStartstation.Size = new System.Drawing.Size(164, 21);
            this.cmbStartstation.TabIndex = 15;
            this.cmbStartstation.TextChanged += new System.EventHandler(this.autoComplete);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText;
            this.dtpTime.Checked = false;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(154, 98);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(86, 20);
            this.dtpTime.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(38, 104);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Zeit: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(260, 98);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(183, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // lblFinalstation
            // 
            this.lblFinalstation.AutoSize = true;
            this.lblFinalstation.Location = new System.Drawing.Point(38, 65);
            this.lblFinalstation.Name = "lblFinalstation";
            this.lblFinalstation.Size = new System.Drawing.Size(63, 13);
            this.lblFinalstation.TabIndex = 2;
            this.lblFinalstation.Text = "Endstation: ";
            // 
            // lblStartstation
            // 
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Location = new System.Drawing.Point(38, 27);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(66, 13);
            this.lblStartstation.TabIndex = 1;
            this.lblStartstation.Text = "Startstation: ";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchConnection.Location = new System.Drawing.Point(313, 133);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(130, 23);
            this.btnSearchConnection.TabIndex = 0;
            this.btnSearchConnection.Text = "Verbindungen suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // tbcNagivation
            // 
            this.tbcNagivation.Controls.Add(this.tbpSearchConnection);
            this.tbcNagivation.Controls.Add(this.tbpDeparture);
            this.tbcNagivation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcNagivation.Location = new System.Drawing.Point(0, 0);
            this.tbcNagivation.Name = "tbcNagivation";
            this.tbcNagivation.SelectedIndex = 0;
            this.tbcNagivation.Size = new System.Drawing.Size(474, 462);
            this.tbcNagivation.TabIndex = 0;
            // 
            // tbpDeparture
            // 
            this.tbpDeparture.Controls.Add(this.grpDeparture);
            this.tbpDeparture.Controls.Add(this.grpInfo);
            this.tbpDeparture.Location = new System.Drawing.Point(4, 22);
            this.tbpDeparture.Name = "tbpDeparture";
            this.tbpDeparture.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeparture.Size = new System.Drawing.Size(466, 436);
            this.tbpDeparture.TabIndex = 2;
            this.tbpDeparture.Text = "Abfahrtsplan";
            this.tbpDeparture.UseVisualStyleBackColor = true;
            // 
            // grpDeparture
            // 
            this.grpDeparture.Controls.Add(this.dgvDepartureTable);
            this.grpDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDeparture.Location = new System.Drawing.Point(3, 184);
            this.grpDeparture.Name = "grpDeparture";
            this.grpDeparture.Size = new System.Drawing.Size(460, 249);
            this.grpDeparture.TabIndex = 3;
            this.grpDeparture.TabStop = false;
            this.grpDeparture.Text = "Abfahrten";
            // 
            // dgvDepartureTable
            // 
            this.dgvDepartureTable.AllowUserToAddRows = false;
            this.dgvDepartureTable.AllowUserToDeleteRows = false;
            this.dgvDepartureTable.AllowUserToResizeColumns = false;
            this.dgvDepartureTable.AllowUserToResizeRows = false;
            this.dgvDepartureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLine,
            this.colDepartureTime,
            this.colArrivalStation});
            this.dgvDepartureTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartureTable.Location = new System.Drawing.Point(3, 16);
            this.dgvDepartureTable.Name = "dgvDepartureTable";
            this.dgvDepartureTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDepartureTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartureTable.Size = new System.Drawing.Size(454, 230);
            this.dgvDepartureTable.TabIndex = 0;
            this.dgvDepartureTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartureTable_CellContentDoubleClick);
            // 
            // colLine
            // 
            this.colLine.HeaderText = "Linie";
            this.colLine.Name = "colLine";
            this.colLine.ReadOnly = true;
            // 
            // colDepartureTime
            // 
            this.colDepartureTime.HeaderText = "Abfahrtszeit";
            this.colDepartureTime.Name = "colDepartureTime";
            this.colDepartureTime.ReadOnly = true;
            this.colDepartureTime.Width = 125;
            // 
            // colArrivalStation
            // 
            this.colArrivalStation.HeaderText = "Ankunftsstation";
            this.colArrivalStation.Name = "colArrivalStation";
            this.colArrivalStation.ReadOnly = true;
            this.colArrivalStation.Width = 175;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.cmbStation);
            this.grpInfo.Controls.Add(this.lblStation);
            this.grpInfo.Controls.Add(this.btnInfo);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Location = new System.Drawing.Point(3, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(460, 181);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Infomationen";
            // 
            // cmbStation
            // 
            this.cmbStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(279, 24);
            this.cmbStation.MaximumSize = new System.Drawing.Size(164, 0);
            this.cmbStation.MinimumSize = new System.Drawing.Size(164, 0);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(164, 21);
            this.cmbStation.TabIndex = 16;
            this.cmbStation.TextChanged += new System.EventHandler(this.autoComplete);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(38, 27);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(46, 13);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station: ";
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Location = new System.Drawing.Point(313, 85);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(130, 23);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info suchen";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 462);
            this.Controls.Add(this.tbcNagivation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(490, 501);
            this.MinimumSize = new System.Drawing.Size(490, 501);
            this.Name = "applicationForm";
            this.Text = "ÖV-App";
            this.tbpSearchConnection.ResumeLayout(false);
            this.grpConnections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.grpSearchConnection.ResumeLayout(false);
            this.grpSearchConnection.PerformLayout();
            this.tbcNagivation.ResumeLayout(false);
            this.tbpDeparture.ResumeLayout(false);
            this.grpDeparture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartureTable)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpSearchConnection;
        private System.Windows.Forms.GroupBox grpConnections;
        private System.Windows.Forms.GroupBox grpSearchConnection;
        private System.Windows.Forms.TabControl tbcNagivation;
        private System.Windows.Forms.TabPage tbpDeparture;
        private System.Windows.Forms.DataGridView dgvConnections;
        private System.Windows.Forms.Label lblFinalstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox grpDeparture;
        private System.Windows.Forms.DataGridView dgvDepartureTable;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparutreTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalstation;
        private System.Windows.Forms.ComboBox cmbStartstation;
        private System.Windows.Forms.ComboBox cmbFinalstation;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrivalStation;
    }
}

