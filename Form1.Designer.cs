namespace PoeDG
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AffixList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AffixListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mustHaveCheck = new System.Windows.Forms.CheckBox();
            this.AffixListView = new System.Windows.Forms.ListView();
            this.newOrClearBtn = new System.Windows.Forms.Button();
            this.newToListViewBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AffixNum = new System.Windows.Forms.NumericUpDown();
            this.workCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeMs = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StartWork = new System.Windows.Forms.Button();
            this.WorkLog = new System.Windows.Forms.TextBox();
            this.WindowTop = new System.Windows.Forms.CheckBox();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.augCheck = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.PreOrSuf = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chaos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AffixNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // AffixList
            // 
            this.AffixList.Location = new System.Drawing.Point(12, 24);
            this.AffixList.Name = "AffixList";
            this.AffixList.Size = new System.Drawing.Size(245, 22);
            this.AffixList.TabIndex = 0;
            this.AffixList.Click += new System.EventHandler(this.AffixList_Click);
            this.AffixList.TextChanged += new System.EventHandler(this.AffixList_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "設定要保留的詞綴";
            // 
            // AffixListBox
            // 
            this.AffixListBox.FormattingEnabled = true;
            this.AffixListBox.ItemHeight = 12;
            this.AffixListBox.Location = new System.Drawing.Point(10, 52);
            this.AffixListBox.Name = "AffixListBox";
            this.AffixListBox.Size = new System.Drawing.Size(311, 136);
            this.AffixListBox.TabIndex = 2;
            this.AffixListBox.Visible = false;
            this.AffixListBox.Click += new System.EventHandler(this.AffixListBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "最小值";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "最大值";
            this.label3.Visible = false;
            // 
            // mustHaveCheck
            // 
            this.mustHaveCheck.AutoSize = true;
            this.mustHaveCheck.Location = new System.Drawing.Point(204, 54);
            this.mustHaveCheck.Name = "mustHaveCheck";
            this.mustHaveCheck.Size = new System.Drawing.Size(60, 16);
            this.mustHaveCheck.TabIndex = 7;
            this.mustHaveCheck.Text = "必要詞";
            this.mustHaveCheck.UseVisualStyleBackColor = true;
            this.mustHaveCheck.Visible = false;
            // 
            // AffixListView
            // 
            this.AffixListView.AutoArrange = false;
            this.AffixListView.FullRowSelect = true;
            this.AffixListView.HideSelection = false;
            this.AffixListView.LabelWrap = false;
            this.AffixListView.Location = new System.Drawing.Point(14, 89);
            this.AffixListView.MultiSelect = false;
            this.AffixListView.Name = "AffixListView";
            this.AffixListView.Size = new System.Drawing.Size(309, 97);
            this.AffixListView.TabIndex = 8;
            this.AffixListView.TileSize = new System.Drawing.Size(305, 28);
            this.AffixListView.UseCompatibleStateImageBehavior = false;
            this.AffixListView.View = System.Windows.Forms.View.Tile;
            this.AffixListView.Click += new System.EventHandler(this.AffixListView_Click);
            this.AffixListView.DoubleClick += new System.EventHandler(this.AffixListView_DoubleClick);
            // 
            // newOrClearBtn
            // 
            this.newOrClearBtn.Location = new System.Drawing.Point(263, 9);
            this.newOrClearBtn.Name = "newOrClearBtn";
            this.newOrClearBtn.Size = new System.Drawing.Size(58, 23);
            this.newOrClearBtn.TabIndex = 9;
            this.newOrClearBtn.Text = "清除";
            this.newOrClearBtn.UseVisualStyleBackColor = true;
            this.newOrClearBtn.Click += new System.EventHandler(this.newOrClearBtn_Click);
            // 
            // newToListViewBtn
            // 
            this.newToListViewBtn.Location = new System.Drawing.Point(263, 38);
            this.newToListViewBtn.Name = "newToListViewBtn";
            this.newToListViewBtn.Size = new System.Drawing.Size(58, 36);
            this.newToListViewBtn.TabIndex = 10;
            this.newToListViewBtn.Text = "新增";
            this.newToListViewBtn.UseVisualStyleBackColor = true;
            this.newToListViewBtn.Click += new System.EventHandler(this.newToListViewBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "欲滿足詞綴數";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AffixNum
            // 
            this.AffixNum.Location = new System.Drawing.Point(91, 364);
            this.AffixNum.Name = "AffixNum";
            this.AffixNum.Size = new System.Drawing.Size(35, 22);
            this.AffixNum.TabIndex = 13;
            this.AffixNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AffixNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workCount
            // 
            this.workCount.Location = new System.Drawing.Point(191, 364);
            this.workCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.workCount.Name = "workCount";
            this.workCount.Size = new System.Drawing.Size(35, 22);
            this.workCount.TabIndex = 15;
            this.workCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "執行次數";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeMs
            // 
            this.TimeMs.Location = new System.Drawing.Point(286, 364);
            this.TimeMs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeMs.Name = "TimeMs";
            this.TimeMs.Size = new System.Drawing.Size(47, 22);
            this.TimeMs.TabIndex = 17;
            this.TimeMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeMs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "間隔毫秒";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartWork
            // 
            this.StartWork.Location = new System.Drawing.Point(10, 397);
            this.StartWork.Name = "StartWork";
            this.StartWork.Size = new System.Drawing.Size(311, 41);
            this.StartWork.TabIndex = 18;
            this.StartWork.Text = "開始";
            this.StartWork.UseVisualStyleBackColor = true;
            this.StartWork.Click += new System.EventHandler(this.StartWork_Click);
            // 
            // WorkLog
            // 
            this.WorkLog.Location = new System.Drawing.Point(451, 24);
            this.WorkLog.Multiline = true;
            this.WorkLog.Name = "WorkLog";
            this.WorkLog.ReadOnly = true;
            this.WorkLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorkLog.Size = new System.Drawing.Size(337, 414);
            this.WorkLog.TabIndex = 19;
            this.WorkLog.Text = "訊息紀錄...";
            // 
            // WindowTop
            // 
            this.WindowTop.AutoSize = true;
            this.WindowTop.Checked = true;
            this.WindowTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WindowTop.Location = new System.Drawing.Point(451, 2);
            this.WindowTop.Name = "WindowTop";
            this.WindowTop.Size = new System.Drawing.Size(72, 16);
            this.WindowTop.TabIndex = 20;
            this.WindowTop.Text = "視窗置頂";
            this.WindowTop.UseVisualStyleBackColor = true;
            this.WindowTop.CheckedChanged += new System.EventHandler(this.WindowTop_CheckedChanged);
            // 
            // minNum
            // 
            this.minNum.Location = new System.Drawing.Point(202, 336);
            this.minNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(37, 22);
            this.minNum.TabIndex = 21;
            this.minNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minNum.Visible = false;
            // 
            // maxNum
            // 
            this.maxNum.Location = new System.Drawing.Point(298, 336);
            this.maxNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(35, 22);
            this.maxNum.TabIndex = 22;
            this.maxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxNum.Visible = false;
            // 
            // augCheck
            // 
            this.augCheck.AutoSize = true;
            this.augCheck.Location = new System.Drawing.Point(18, 225);
            this.augCheck.Name = "augCheck";
            this.augCheck.Size = new System.Drawing.Size(72, 16);
            this.augCheck.TabIndex = 23;
            this.augCheck.Text = "當一詞是";
            this.augCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 247);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 16);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "製作傳奇物品(還沒寫";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // PreOrSuf
            // 
            this.PreOrSuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreOrSuf.FormattingEnabled = true;
            this.PreOrSuf.Items.AddRange(new object[] {
            "前",
            "後"});
            this.PreOrSuf.Location = new System.Drawing.Point(88, 223);
            this.PreOrSuf.Name = "PreOrSuf";
            this.PreOrSuf.Size = new System.Drawing.Size(38, 20);
            this.PreOrSuf.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "綴才使用增幅石";
            // 
            // Tier
            // 
            this.Tier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tier.FormattingEnabled = true;
            this.Tier.Items.AddRange(new object[] {
            "",
            "T1",
            "T2",
            "T3",
            "T4",
            "T5"});
            this.Tier.Location = new System.Drawing.Point(107, 52);
            this.Tier.Name = "Tier";
            this.Tier.Size = new System.Drawing.Size(62, 20);
            this.Tier.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "詞綴階級(以上)";
            // 
            // chaos
            // 
            this.chaos.AutoSize = true;
            this.chaos.Location = new System.Drawing.Point(18, 269);
            this.chaos.Name = "chaos";
            this.chaos.Size = new System.Drawing.Size(84, 16);
            this.chaos.TabIndex = 29;
            this.chaos.Text = "使用混沌石";
            this.chaos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chaos);
            this.Controls.Add(this.AffixListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PreOrSuf);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.augCheck);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.minNum);
            this.Controls.Add(this.WindowTop);
            this.Controls.Add(this.WorkLog);
            this.Controls.Add(this.StartWork);
            this.Controls.Add(this.TimeMs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.workCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AffixNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newToListViewBtn);
            this.Controls.Add(this.newOrClearBtn);
            this.Controls.Add(this.AffixListView);
            this.Controls.Add(this.mustHaveCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AffixList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AffixNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AffixList;
        private System.Windows.Forms.ListBox AffixListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox mustHaveCheck;
        private System.Windows.Forms.ListView AffixListView;
        private System.Windows.Forms.Button newOrClearBtn;
        private System.Windows.Forms.Button newToListViewBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AffixNum;
        private System.Windows.Forms.NumericUpDown workCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TimeMs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button StartWork;
        private System.Windows.Forms.TextBox WorkLog;
        private System.Windows.Forms.CheckBox WindowTop;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.CheckBox augCheck;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox PreOrSuf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Tier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chaos;
    }
}

