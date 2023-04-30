namespace Take_Home_Ass_W8
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTeamatas = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayerbawah = new System.Windows.Forms.ComboBox();
            this.labelnational = new System.Windows.Forms.Label();
            this.labelsqnum = new System.Windows.Forms.Label();
            this.labelrcards = new System.Windows.Forms.Label();
            this.labelposisi = new System.Windows.Forms.Label();
            this.labelteam = new System.Windows.Forms.Label();
            this.labelgscored = new System.Windows.Forms.Label();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelpmissed = new System.Windows.Forms.Label();
            this.labelycards = new System.Windows.Forms.Label();
            this.labeljwbnama = new System.Windows.Forms.Label();
            this.labeljwbteam = new System.Windows.Forms.Label();
            this.labeljwbposisi = new System.Windows.Forms.Label();
            this.labeljwbnation = new System.Windows.Forms.Label();
            this.labeljwbpenalty = new System.Windows.Forms.Label();
            this.labeljwbycards = new System.Windows.Forms.Label();
            this.labeljwbrcards = new System.Windows.Forms.Label();
            this.labeljwbgscored = new System.Windows.Forms.Label();
            this.labeljwbnum = new System.Windows.Forms.Label();
            this.dataGridViewkiri = new System.Windows.Forms.DataGridView();
            this.dataGridViewkanan = new System.Windows.Forms.DataGridView();
            this.dataGridViewmatch = new System.Windows.Forms.DataGridView();
            this.comboBoxteammatch = new System.Windows.Forms.ComboBox();
            this.comboBoxtanggal = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkiri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmatch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1418, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailToolStripMenuItem
            // 
            this.showMatchDetailToolStripMenuItem.Name = "showMatchDetailToolStripMenuItem";
            this.showMatchDetailToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.showMatchDetailToolStripMenuItem.Text = "Show Match Detail";
            this.showMatchDetailToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailToolStripMenuItem_Click);
            // 
            // comboBoxTeamatas
            // 
            this.comboBoxTeamatas.FormattingEnabled = true;
            this.comboBoxTeamatas.Location = new System.Drawing.Point(12, 50);
            this.comboBoxTeamatas.Name = "comboBoxTeamatas";
            this.comboBoxTeamatas.Size = new System.Drawing.Size(161, 24);
            this.comboBoxTeamatas.TabIndex = 1;
            this.comboBoxTeamatas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamatas_SelectedIndexChanged);
            this.comboBoxTeamatas.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeamatas_SelectionChangeCommitted);
            // 
            // comboBoxPlayerbawah
            // 
            this.comboBoxPlayerbawah.FormattingEnabled = true;
            this.comboBoxPlayerbawah.Location = new System.Drawing.Point(12, 106);
            this.comboBoxPlayerbawah.Name = "comboBoxPlayerbawah";
            this.comboBoxPlayerbawah.Size = new System.Drawing.Size(161, 24);
            this.comboBoxPlayerbawah.TabIndex = 2;
            this.comboBoxPlayerbawah.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayerbawah_SelectedIndexChanged);
            this.comboBoxPlayerbawah.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPlayerbawah_SelectionChangeCommitted);
            // 
            // labelnational
            // 
            this.labelnational.AutoSize = true;
            this.labelnational.Location = new System.Drawing.Point(228, 168);
            this.labelnational.Name = "labelnational";
            this.labelnational.Size = new System.Drawing.Size(76, 16);
            this.labelnational.TabIndex = 8;
            this.labelnational.Text = "Nationality :";
            // 
            // labelsqnum
            // 
            this.labelsqnum.AutoSize = true;
            this.labelsqnum.Location = new System.Drawing.Point(541, 77);
            this.labelsqnum.Name = "labelsqnum";
            this.labelsqnum.Size = new System.Drawing.Size(104, 16);
            this.labelsqnum.TabIndex = 7;
            this.labelsqnum.Text = "Squad Number :";
            // 
            // labelrcards
            // 
            this.labelrcards.AutoSize = true;
            this.labelrcards.Location = new System.Drawing.Point(541, 141);
            this.labelrcards.Name = "labelrcards";
            this.labelrcards.Size = new System.Drawing.Size(78, 16);
            this.labelrcards.TabIndex = 9;
            this.labelrcards.Text = "Red Cards :";
            // 
            // labelposisi
            // 
            this.labelposisi.AutoSize = true;
            this.labelposisi.Location = new System.Drawing.Point(228, 141);
            this.labelposisi.Name = "labelposisi";
            this.labelposisi.Size = new System.Drawing.Size(60, 16);
            this.labelposisi.TabIndex = 5;
            this.labelposisi.Text = "Potition : ";
            // 
            // labelteam
            // 
            this.labelteam.AutoSize = true;
            this.labelteam.Location = new System.Drawing.Point(228, 106);
            this.labelteam.Name = "labelteam";
            this.labelteam.Size = new System.Drawing.Size(49, 16);
            this.labelteam.TabIndex = 4;
            this.labelteam.Text = "Team :";
            // 
            // labelgscored
            // 
            this.labelgscored.AutoSize = true;
            this.labelgscored.Location = new System.Drawing.Point(541, 168);
            this.labelgscored.Name = "labelgscored";
            this.labelgscored.Size = new System.Drawing.Size(89, 16);
            this.labelgscored.TabIndex = 11;
            this.labelgscored.Text = "Goal Scored :";
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(228, 76);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(50, 16);
            this.labelnama.TabIndex = 3;
            this.labelnama.Text = "Nama :";
            // 
            // labelpmissed
            // 
            this.labelpmissed.AutoSize = true;
            this.labelpmissed.Location = new System.Drawing.Point(228, 198);
            this.labelpmissed.Name = "labelpmissed";
            this.labelpmissed.Size = new System.Drawing.Size(105, 16);
            this.labelpmissed.TabIndex = 12;
            this.labelpmissed.Text = "Penalty Missed :";
            // 
            // labelycards
            // 
            this.labelycards.AutoSize = true;
            this.labelycards.Location = new System.Drawing.Point(541, 106);
            this.labelycards.Name = "labelycards";
            this.labelycards.Size = new System.Drawing.Size(92, 16);
            this.labelycards.TabIndex = 10;
            this.labelycards.Text = "Yellow Cards :";
            // 
            // labeljwbnama
            // 
            this.labeljwbnama.AutoSize = true;
            this.labeljwbnama.Location = new System.Drawing.Point(288, 76);
            this.labeljwbnama.Name = "labeljwbnama";
            this.labeljwbnama.Size = new System.Drawing.Size(0, 16);
            this.labeljwbnama.TabIndex = 13;
            // 
            // labeljwbteam
            // 
            this.labeljwbteam.AutoSize = true;
            this.labeljwbteam.Location = new System.Drawing.Point(288, 106);
            this.labeljwbteam.Name = "labeljwbteam";
            this.labeljwbteam.Size = new System.Drawing.Size(0, 16);
            this.labeljwbteam.TabIndex = 14;
            // 
            // labeljwbposisi
            // 
            this.labeljwbposisi.AutoSize = true;
            this.labeljwbposisi.Location = new System.Drawing.Point(294, 141);
            this.labeljwbposisi.Name = "labeljwbposisi";
            this.labeljwbposisi.Size = new System.Drawing.Size(0, 16);
            this.labeljwbposisi.TabIndex = 15;
            // 
            // labeljwbnation
            // 
            this.labeljwbnation.AutoSize = true;
            this.labeljwbnation.Location = new System.Drawing.Point(310, 168);
            this.labeljwbnation.Name = "labeljwbnation";
            this.labeljwbnation.Size = new System.Drawing.Size(0, 16);
            this.labeljwbnation.TabIndex = 16;
            // 
            // labeljwbpenalty
            // 
            this.labeljwbpenalty.AutoSize = true;
            this.labeljwbpenalty.Location = new System.Drawing.Point(339, 198);
            this.labeljwbpenalty.Name = "labeljwbpenalty";
            this.labeljwbpenalty.Size = new System.Drawing.Size(0, 16);
            this.labeljwbpenalty.TabIndex = 17;
            // 
            // labeljwbycards
            // 
            this.labeljwbycards.AutoSize = true;
            this.labeljwbycards.Location = new System.Drawing.Point(639, 106);
            this.labeljwbycards.Name = "labeljwbycards";
            this.labeljwbycards.Size = new System.Drawing.Size(0, 16);
            this.labeljwbycards.TabIndex = 18;
            // 
            // labeljwbrcards
            // 
            this.labeljwbrcards.AutoSize = true;
            this.labeljwbrcards.Location = new System.Drawing.Point(639, 141);
            this.labeljwbrcards.Name = "labeljwbrcards";
            this.labeljwbrcards.Size = new System.Drawing.Size(0, 16);
            this.labeljwbrcards.TabIndex = 19;
            // 
            // labeljwbgscored
            // 
            this.labeljwbgscored.AutoSize = true;
            this.labeljwbgscored.Location = new System.Drawing.Point(639, 168);
            this.labeljwbgscored.Name = "labeljwbgscored";
            this.labeljwbgscored.Size = new System.Drawing.Size(0, 16);
            this.labeljwbgscored.TabIndex = 20;
            // 
            // labeljwbnum
            // 
            this.labeljwbnum.AutoSize = true;
            this.labeljwbnum.Location = new System.Drawing.Point(651, 76);
            this.labeljwbnum.Name = "labeljwbnum";
            this.labeljwbnum.Size = new System.Drawing.Size(0, 16);
            this.labeljwbnum.TabIndex = 21;
            // 
            // dataGridViewkiri
            // 
            this.dataGridViewkiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkiri.Location = new System.Drawing.Point(231, 245);
            this.dataGridViewkiri.Name = "dataGridViewkiri";
            this.dataGridViewkiri.RowHeadersWidth = 51;
            this.dataGridViewkiri.RowTemplate.Height = 24;
            this.dataGridViewkiri.Size = new System.Drawing.Size(558, 268);
            this.dataGridViewkiri.TabIndex = 22;
            // 
            // dataGridViewkanan
            // 
            this.dataGridViewkanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkanan.Location = new System.Drawing.Point(873, 245);
            this.dataGridViewkanan.Name = "dataGridViewkanan";
            this.dataGridViewkanan.RowHeadersWidth = 51;
            this.dataGridViewkanan.RowTemplate.Height = 24;
            this.dataGridViewkanan.Size = new System.Drawing.Size(533, 268);
            this.dataGridViewkanan.TabIndex = 23;
            // 
            // dataGridViewmatch
            // 
            this.dataGridViewmatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmatch.Location = new System.Drawing.Point(873, 31);
            this.dataGridViewmatch.Name = "dataGridViewmatch";
            this.dataGridViewmatch.RowHeadersWidth = 51;
            this.dataGridViewmatch.RowTemplate.Height = 24;
            this.dataGridViewmatch.Size = new System.Drawing.Size(533, 153);
            this.dataGridViewmatch.TabIndex = 24;
            // 
            // comboBoxteammatch
            // 
            this.comboBoxteammatch.FormattingEnabled = true;
            this.comboBoxteammatch.Location = new System.Drawing.Point(12, 312);
            this.comboBoxteammatch.Name = "comboBoxteammatch";
            this.comboBoxteammatch.Size = new System.Drawing.Size(161, 24);
            this.comboBoxteammatch.TabIndex = 25;
            this.comboBoxteammatch.SelectionChangeCommitted += new System.EventHandler(this.comboBoxteammatch_SelectionChangeCommitted);
            // 
            // comboBoxtanggal
            // 
            this.comboBoxtanggal.FormattingEnabled = true;
            this.comboBoxtanggal.Location = new System.Drawing.Point(12, 398);
            this.comboBoxtanggal.Name = "comboBoxtanggal";
            this.comboBoxtanggal.Size = new System.Drawing.Size(161, 24);
            this.comboBoxtanggal.TabIndex = 26;
            this.comboBoxtanggal.SelectedIndexChanged += new System.EventHandler(this.comboBoxtanggal_SelectedIndexChanged);
            this.comboBoxtanggal.SelectionChangeCommitted += new System.EventHandler(this.comboBoxtanggal_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 578);
            this.Controls.Add(this.comboBoxtanggal);
            this.Controls.Add(this.comboBoxteammatch);
            this.Controls.Add(this.dataGridViewmatch);
            this.Controls.Add(this.dataGridViewkanan);
            this.Controls.Add(this.dataGridViewkiri);
            this.Controls.Add(this.labeljwbnum);
            this.Controls.Add(this.labeljwbgscored);
            this.Controls.Add(this.labeljwbrcards);
            this.Controls.Add(this.labeljwbycards);
            this.Controls.Add(this.labeljwbpenalty);
            this.Controls.Add(this.labeljwbnation);
            this.Controls.Add(this.labeljwbposisi);
            this.Controls.Add(this.labeljwbteam);
            this.Controls.Add(this.labeljwbnama);
            this.Controls.Add(this.labelycards);
            this.Controls.Add(this.labelpmissed);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.comboBoxPlayerbawah);
            this.Controls.Add(this.labelgscored);
            this.Controls.Add(this.comboBoxTeamatas);
            this.Controls.Add(this.labelteam);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelposisi);
            this.Controls.Add(this.labelnational);
            this.Controls.Add(this.labelrcards);
            this.Controls.Add(this.labelsqnum);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkiri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTeamatas;
        private System.Windows.Forms.ComboBox comboBoxPlayerbawah;
        private System.Windows.Forms.Label labelnational;
        private System.Windows.Forms.Label labelsqnum;
        private System.Windows.Forms.Label labelrcards;
        private System.Windows.Forms.Label labelposisi;
        private System.Windows.Forms.Label labelteam;
        private System.Windows.Forms.Label labelgscored;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelpmissed;
        private System.Windows.Forms.Label labelycards;
        private System.Windows.Forms.Label labeljwbnama;
        private System.Windows.Forms.Label labeljwbteam;
        private System.Windows.Forms.Label labeljwbposisi;
        private System.Windows.Forms.Label labeljwbnation;
        private System.Windows.Forms.Label labeljwbpenalty;
        private System.Windows.Forms.Label labeljwbycards;
        private System.Windows.Forms.Label labeljwbrcards;
        private System.Windows.Forms.Label labeljwbgscored;
        private System.Windows.Forms.Label labeljwbnum;
        private System.Windows.Forms.DataGridView dataGridViewkiri;
        private System.Windows.Forms.DataGridView dataGridViewkanan;
        private System.Windows.Forms.DataGridView dataGridViewmatch;
        private System.Windows.Forms.ComboBox comboBoxteammatch;
        private System.Windows.Forms.ComboBox comboBoxtanggal;
    }
}

