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
            this.tbpSearchConnection = new System.Windows.Forms.TabPage();
            this.grpConnections = new System.Windows.Forms.GroupBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.grpSearchConnection = new System.Windows.Forms.GroupBox();
            this.txtStartstation = new System.Windows.Forms.TextBox();
            this.cmbFinalstation = new System.Windows.Forms.ComboBox();
            this.lblFinalstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.tbcNagivation = new System.Windows.Forms.TabControl();
            this.tbpDeparture = new System.Windows.Forms.TabPage();
            this.grpDeparture = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.colStartstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpSearchConnection.SuspendLayout();
            this.grpConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.grpSearchConnection.SuspendLayout();
            this.tbcNagivation.SuspendLayout();
            this.tbpDeparture.SuspendLayout();
            this.grpDeparture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartstation,
            this.colTime,
            this.colFinalstation});
            this.dgvConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConnections.Location = new System.Drawing.Point(3, 16);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConnections.Size = new System.Drawing.Size(454, 230);
            this.dgvConnections.TabIndex = 0;
            // 
            // grpSearchConnection
            // 
            this.grpSearchConnection.Controls.Add(this.txtStartstation);
            this.grpSearchConnection.Controls.Add(this.cmbFinalstation);
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
            // txtStartstation
            // 
            this.txtStartstation.AllowDrop = true;
            this.txtStartstation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStartstation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStartstation.Location = new System.Drawing.Point(279, 24);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(164, 20);
            this.txtStartstation.TabIndex = 7;
            this.txtStartstation.TextChanged += new System.EventHandler(this.cmbStartstation_TextChanged);
            // 
            // cmbFinalstation
            // 
            this.cmbFinalstation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFinalstation.FormattingEnabled = true;
            this.cmbFinalstation.Location = new System.Drawing.Point(279, 85);
            this.cmbFinalstation.Name = "cmbFinalstation";
            this.cmbFinalstation.Size = new System.Drawing.Size(164, 21);
            this.cmbFinalstation.TabIndex = 6;
            // 
            // lblFinalstation
            // 
            this.lblFinalstation.AutoSize = true;
            this.lblFinalstation.Location = new System.Drawing.Point(38, 88);
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
            this.grpDeparture.Controls.Add(this.dataGridView1);
            this.grpDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDeparture.Location = new System.Drawing.Point(3, 184);
            this.grpDeparture.Name = "grpDeparture";
            this.grpDeparture.Size = new System.Drawing.Size(460, 249);
            this.grpDeparture.TabIndex = 3;
            this.grpDeparture.TabStop = false;
            this.grpDeparture.Text = "Abfahrten";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(454, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Linie/Gleis";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Startstation";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Reisezeit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ankunfrsstation";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.cmbStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(279, 24);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(164, 21);
            this.cmbStation.TabIndex = 5;
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
            // 
            // colStartstation
            // 
            this.colStartstation.HeaderText = "Startstation";
            this.colStartstation.MinimumWidth = 10;
            this.colStartstation.Name = "colStartstation";
            this.colStartstation.ReadOnly = true;
            this.colStartstation.Width = 150;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Reisezeit";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colFinalstation
            // 
            this.colFinalstation.HeaderText = "Ankunfrsstation";
            this.colFinalstation.Name = "colFinalstation";
            this.colFinalstation.ReadOnly = true;
            this.colFinalstation.Width = 150;
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 462);
            this.Controls.Add(this.tbcNagivation);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbFinalstation;
        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox grpDeparture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalstation;
    }
}

