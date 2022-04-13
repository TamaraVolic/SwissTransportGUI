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
            this.TabPageNearby = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TabPageTimetable = new System.Windows.Forms.TabPage();
            this.ComboBoxTimetable = new System.Windows.Forms.ComboBox();
            this.DataGridTimetable = new System.Windows.Forms.DataGridView();
            this.ButtonSearchTimetable = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageConnections = new System.Windows.Forms.TabPage();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConnections)).BeginInit();
            this.TabPageNearby.SuspendLayout();
            this.TabPageTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTimetable)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPageConnections.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSwitch
            // 
            this.ButtonSwitch.Location = new System.Drawing.Point(279, 63);
            this.ButtonSwitch.Name = "ButtonSwitch";
            this.ButtonSwitch.Size = new System.Drawing.Size(101, 38);
            this.ButtonSwitch.TabIndex = 2;
            this.ButtonSwitch.Text = "Switch";
            this.ButtonSwitch.UseVisualStyleBackColor = true;
            this.ButtonSwitch.Click += new System.EventHandler(this.ButtonSwitchClick);
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(406, 64);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(182, 38);
            this.ComboBoxTo.TabIndex = 3;
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(33, 63);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(224, 38);
            this.ComboBoxFrom.TabIndex = 1;
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
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
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
            // TabPageNearby
            // 
            this.TabPageNearby.Controls.Add(this.button1);
            this.TabPageNearby.Controls.Add(this.TextBoxSearch);
            this.TabPageNearby.Location = new System.Drawing.Point(4, 39);
            this.TabPageNearby.Name = "TabPageNearby";
            this.TabPageNearby.Size = new System.Drawing.Size(816, 548);
            this.TabPageNearby.TabIndex = 2;
            this.TabPageNearby.Text = "Stations Nearby";
            this.TabPageNearby.UseVisualStyleBackColor = true;
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
            // TabPageTimetable
            // 
            this.TabPageTimetable.Controls.Add(this.ComboBox2);
            this.TabPageTimetable.Controls.Add(this.ComboBoxTimetable);
            this.TabPageTimetable.Controls.Add(this.DataGridTimetable);
            this.TabPageTimetable.Controls.Add(this.ButtonSearchTimetable);
            this.TabPageTimetable.Location = new System.Drawing.Point(4, 39);
            this.TabPageTimetable.Name = "TabPageTimetable";
            this.TabPageTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTimetable.Size = new System.Drawing.Size(816, 548);
            this.TabPageTimetable.TabIndex = 1;
            this.TabPageTimetable.Text = "Timetable";
            this.TabPageTimetable.UseVisualStyleBackColor = true;
            // 
            // ComboBoxTimetable
            // 
            this.ComboBoxTimetable.FormattingEnabled = true;
            this.ComboBoxTimetable.Location = new System.Drawing.Point(28, 40);
            this.ComboBoxTimetable.Name = "ComboBoxTimetable";
            this.ComboBoxTimetable.Size = new System.Drawing.Size(605, 38);
            this.ComboBoxTimetable.TabIndex = 12;
            // 
            // DataGridTimetable
            // 
            this.DataGridTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTimetable.Location = new System.Drawing.Point(28, 107);
            this.DataGridTimetable.Name = "DataGridTimetable";
            this.DataGridTimetable.RowHeadersWidth = 62;
            this.DataGridTimetable.RowTemplate.Height = 33;
            this.DataGridTimetable.Size = new System.Drawing.Size(751, 372);
            this.DataGridTimetable.TabIndex = 11;
            // 
            // ButtonSearchTimetable
            // 
            this.ButtonSearchTimetable.Location = new System.Drawing.Point(639, 41);
            this.ButtonSearchTimetable.Name = "ButtonSearchTimetable";
            this.ButtonSearchTimetable.Size = new System.Drawing.Size(140, 37);
            this.ButtonSearchTimetable.TabIndex = 10;
            this.ButtonSearchTimetable.Text = "Search";
            this.ButtonSearchTimetable.UseVisualStyleBackColor = true;
            this.ButtonSearchTimetable.Click += new System.EventHandler(this.ButtonSearchTimetableClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageConnections);
            this.TabControl.Controls.Add(this.TabPageTimetable);
            this.TabControl.Controls.Add(this.TabPageNearby);
            this.TabControl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(824, 591);
            this.TabControl.TabIndex = 0;
            // 
            // TabPageConnections
            // 
            this.TabPageConnections.Controls.Add(this.ButtonSwitch);
            this.TabPageConnections.Controls.Add(this.ComboBoxTo);
            this.TabPageConnections.Controls.Add(this.ComboBoxFrom);
            this.TabPageConnections.Controls.Add(this.TextBoxTime);
            this.TabPageConnections.Controls.Add(this.DataGridConnections);
            this.TabPageConnections.Controls.Add(this.ButtonShare);
            this.TabPageConnections.Controls.Add(this.DateTimePicker);
            this.TabPageConnections.Controls.Add(this.ButtonMap);
            this.TabPageConnections.Controls.Add(this.ButtonSearch);
            this.TabPageConnections.Controls.Add(this.LabelTime);
            this.TabPageConnections.Controls.Add(this.LabelDate);
            this.TabPageConnections.Controls.Add(this.LabelTo);
            this.TabPageConnections.Controls.Add(this.LabelFrom);
            this.TabPageConnections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabPageConnections.Location = new System.Drawing.Point(4, 39);
            this.TabPageConnections.Name = "TabPageConnections";
            this.TabPageConnections.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageConnections.Size = new System.Drawing.Size(816, 548);
            this.TabPageConnections.TabIndex = 0;
            this.TabPageConnections.Text = "Connections";
            this.TabPageConnections.UseVisualStyleBackColor = true;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(28, 485);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(182, 38);
            this.ComboBox2.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 617);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Swiss Transport";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConnections)).EndInit();
            this.TabPageNearby.ResumeLayout(false);
            this.TabPageNearby.PerformLayout();
            this.TabPageTimetable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTimetable)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPageConnections.ResumeLayout(false);
            this.TabPageConnections.PerformLayout();
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
        private TabPage TabPageNearby;
        private Button button1;
        private TextBox TextBoxSearch;
        private TabPage TabPageTimetable;
        private Button ButtonSearchTimetable;
        private TabControl TabControl;
        private TabPage TabPageConnections;
        private DataGridView DataGridTimetable;
        private ComboBox ComboBoxTimetable;
        private ComboBox ComboBox2;
    }
}