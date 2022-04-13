namespace SwissTransportGUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxConnections = new System.Windows.Forms.ListBox();
            this.ButtonSwitch = new System.Windows.Forms.Button();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.DataGridConnections = new System.Windows.Forms.DataGridView();
            this.ButtonShare = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonMap = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TabPageNearby = new System.Windows.Forms.TabPage();
            this.ButtonSearchNearby = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageTimetable = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConnections)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.TabPageNearby.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabPageTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxConnections
            // 
            this.ListBoxConnections.FormattingEnabled = true;
            this.ListBoxConnections.ItemHeight = 30;
            this.ListBoxConnections.Location = new System.Drawing.Point(33, 601);
            this.ListBoxConnections.Name = "ListBoxConnections";
            this.ListBoxConnections.Size = new System.Drawing.Size(745, 244);
            this.ListBoxConnections.TabIndex = 13;
            // 
            // ButtonSwitch
            // 
            this.ButtonSwitch.Location = new System.Drawing.Point(279, 63);
            this.ButtonSwitch.Name = "ButtonSwitch";
            this.ButtonSwitch.Size = new System.Drawing.Size(101, 38);
            this.ButtonSwitch.TabIndex = 12;
            this.ButtonSwitch.Text = "Switch";
            this.ButtonSwitch.UseVisualStyleBackColor = true;
            this.ButtonSwitch.Click += new System.EventHandler(this.ButtonSwitch_Click);
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(406, 64);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(182, 38);
            this.ComboBoxTo.TabIndex = 11;
            this.ComboBoxTo.DropDown += new System.EventHandler(this.ComboBoxTo_DropDown);
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(33, 63);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(224, 38);
            this.ComboBoxFrom.TabIndex = 10;
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Location = new System.Drawing.Point(187, 145);
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(78, 37);
            this.TextBoxTime.TabIndex = 9;
            // 
            // DataGridConnections
            // 
            this.DataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridConnections.Location = new System.Drawing.Point(33, 223);
            this.DataGridConnections.Name = "DataGridConnections";
            this.DataGridConnections.RowHeadersWidth = 62;
            this.DataGridConnections.RowTemplate.Height = 33;
            this.DataGridConnections.Size = new System.Drawing.Size(753, 284);
            this.DataGridConnections.TabIndex = 8;
            // 
            // ButtonShare
            // 
            this.ButtonShare.BackColor = System.Drawing.Color.LightGray;
            this.ButtonShare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShare.Location = new System.Drawing.Point(705, 134);
            this.ButtonShare.Name = "ButtonShare";
            this.ButtonShare.Size = new System.Drawing.Size(81, 42);
            this.ButtonShare.TabIndex = 7;
            this.ButtonShare.Text = "Share";
            this.ButtonShare.UseVisualStyleBackColor = false;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(33, 142);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(139, 37);
            this.DateTimePicker.TabIndex = 3;
            // 
            // ButtonMap
            // 
            this.ButtonMap.BackColor = System.Drawing.Color.LightGray;
            this.ButtonMap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMap.Location = new System.Drawing.Point(303, 134);
            this.ButtonMap.Name = "ButtonMap";
            this.ButtonMap.Size = new System.Drawing.Size(195, 42);
            this.ButtonMap.TabIndex = 5;
            this.ButtonMap.Text = "View on Map";
            this.ButtonMap.UseVisualStyleBackColor = false;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.LightGray;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearch.Location = new System.Drawing.Point(504, 134);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(195, 42);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTime.Location = new System.Drawing.Point(178, 111);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(61, 30);
            this.LabelTime.TabIndex = 5;
            this.LabelTime.Text = "Time";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDate.Location = new System.Drawing.Point(33, 111);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(58, 30);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "Date";
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTo.Location = new System.Drawing.Point(406, 30);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(36, 30);
            this.LabelTo.TabIndex = 1;
            this.LabelTo.Text = "To";
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFrom.Location = new System.Drawing.Point(33, 30);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(64, 30);
            this.LabelFrom.TabIndex = 0;
            this.LabelFrom.Text = "From";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.TextBoxSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(816, 889);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(28, 41);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(605, 37);
            this.TextBoxSearch.TabIndex = 10;
            // 
            // TabPageNearby
            // 
            this.TabPageNearby.Controls.Add(this.ButtonSearchNearby);
            this.TabPageNearby.Controls.Add(this.textBox1);
            this.TabPageNearby.Location = new System.Drawing.Point(4, 39);
            this.TabPageNearby.Name = "TabPageNearby";
            this.TabPageNearby.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNearby.Size = new System.Drawing.Size(816, 553);
            this.TabPageNearby.TabIndex = 1;
            this.TabPageNearby.Text = "Stations Nearby";
            this.TabPageNearby.UseVisualStyleBackColor = true;
            // 
            // ButtonSearchNearby
            // 
            this.ButtonSearchNearby.Location = new System.Drawing.Point(639, 41);
            this.ButtonSearchNearby.Name = "ButtonSearchNearby";
            this.ButtonSearchNearby.Size = new System.Drawing.Size(140, 37);
            this.ButtonSearchNearby.TabIndex = 10;
            this.ButtonSearchNearby.Text = "Search";
            this.ButtonSearchNearby.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(605, 37);
            this.textBox1.TabIndex = 9;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageTimetable);
            this.TabControl.Controls.Add(this.TabPageNearby);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(824, 932);
            this.TabControl.TabIndex = 0;
            // 
            // TabPageTimetable
            // 
            this.TabPageTimetable.Controls.Add(this.ListBoxConnections);
            this.TabPageTimetable.Controls.Add(this.ButtonSwitch);
            this.TabPageTimetable.Controls.Add(this.ComboBoxTo);
            this.TabPageTimetable.Controls.Add(this.ComboBoxFrom);
            this.TabPageTimetable.Controls.Add(this.TextBoxTime);
            this.TabPageTimetable.Controls.Add(this.DataGridConnections);
            this.TabPageTimetable.Controls.Add(this.ButtonShare);
            this.TabPageTimetable.Controls.Add(this.DateTimePicker);
            this.TabPageTimetable.Controls.Add(this.ButtonMap);
            this.TabPageTimetable.Controls.Add(this.ButtonSearch);
            this.TabPageTimetable.Controls.Add(this.LabelTime);
            this.TabPageTimetable.Controls.Add(this.LabelDate);
            this.TabPageTimetable.Controls.Add(this.LabelTo);
            this.TabPageTimetable.Controls.Add(this.LabelFrom);
            this.TabPageTimetable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabPageTimetable.Location = new System.Drawing.Point(4, 39);
            this.TabPageTimetable.Name = "TabPageTimetable";
            this.TabPageTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTimetable.Size = new System.Drawing.Size(816, 889);
            this.TabPageTimetable.TabIndex = 0;
            this.TabPageTimetable.Text = "Timetable";
            this.TabPageTimetable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(751, 358);
            this.dataGridView1.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 956);
            this.Controls.Add(this.TabControl);
            this.Name = "MainWindow";
            this.Text = "Swiss Transport";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConnections)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabPageNearby.ResumeLayout(false);
            this.TabPageNearby.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TabPageTimetable.ResumeLayout(false);
            this.TabPageTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button ButtonShare;
        private DateTimePicker DateTimePicker;
        private Button ButtonMap;
        private Button ButtonSearch;
        private Label LabelTime;
        private Label LabelDate;
        private Label LabelTo;
        private Label LabelFrom;
        private DataGridView DataGridConnections;
        private TextBox TextBoxTime;
        private ComboBox ComboBoxFrom;
        private ComboBox ComboBoxTo;
        private Button ButtonSwitch;
        private ListBox ListBoxConnections;
        private TabPage tabPage1;
        private Button button1;
        private TextBox TextBoxSearch;
        private TabPage TabPageNearby;
        private Button ButtonSearchNearby;
        private TextBox textBox1;
        private TabControl TabControl;
        private TabPage TabPageTimetable;
        private DataGridView dataGridView1;
    }
}