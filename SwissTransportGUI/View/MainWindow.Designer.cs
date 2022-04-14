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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ButtonSwitch = new System.Windows.Forms.Button();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.DataGridConnections = new System.Windows.Forms.DataGridView();
            this.ButtonShare = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.TabPageTimetable = new System.Windows.Forms.TabPage();
            this.TextBoxDepartureBoard = new System.Windows.Forms.TextBox();
            this.DataGridDepartureBoard = new System.Windows.Forms.DataGridView();
            this.ButtonDepartureBoard = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageConnections = new System.Windows.Forms.TabPage();
            this.NumericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.TabPageNearby = new System.Windows.Forms.TabPage();
            this.GMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.ButtonSearchMap = new System.Windows.Forms.Button();
            this.TabPageSearchStation = new System.Windows.Forms.TabPage();
            this.DataGridSearchStation = new System.Windows.Forms.DataGridView();
            this.ButtonSearchStation = new System.Windows.Forms.Button();
            this.TextBoxSearchStation = new System.Windows.Forms.TextBox();
            this.ButtonGMaps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConnections)).BeginInit();
            this.TabPageTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDepartureBoard)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPageConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHour)).BeginInit();
            this.TabPageNearby.SuspendLayout();
            this.TabPageSearchStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearchStation)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSwitch
            // 
            this.ButtonSwitch.BackColor = System.Drawing.Color.LightGray;
            this.ButtonSwitch.Location = new System.Drawing.Point(279, 63);
            this.ButtonSwitch.Name = "ButtonSwitch";
            this.ButtonSwitch.Size = new System.Drawing.Size(101, 45);
            this.ButtonSwitch.TabIndex = 2;
            this.ButtonSwitch.Text = "Switch";
            this.ButtonSwitch.UseVisualStyleBackColor = false;
            this.ButtonSwitch.Click += new System.EventHandler(this.ButtonSwitchClick);
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(406, 63);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(183, 38);
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
            // DataGridConnections
            // 
            this.DataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridConnections.Location = new System.Drawing.Point(33, 223);
            this.DataGridConnections.Name = "DataGridConnections";
            this.DataGridConnections.RowHeadersWidth = 62;
            this.DataGridConnections.RowTemplate.Height = 33;
            this.DataGridConnections.Size = new System.Drawing.Size(753, 283);
            this.DataGridConnections.TabIndex = 8;
            // 
            // ButtonShare
            // 
            this.ButtonShare.BackColor = System.Drawing.Color.LightGray;
            this.ButtonShare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShare.Location = new System.Drawing.Point(616, 63);
            this.ButtonShare.Name = "ButtonShare";
            this.ButtonShare.Size = new System.Drawing.Size(170, 127);
            this.ButtonShare.TabIndex = 7;
            this.ButtonShare.Text = "Share";
            this.ButtonShare.UseVisualStyleBackColor = false;
            this.ButtonShare.Click += new System.EventHandler(this.ButtonShareClick);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(33, 148);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(198, 37);
            this.DateTimePicker.TabIndex = 3;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.LightGray;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearch.Location = new System.Drawing.Point(406, 132);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(184, 55);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTime.Location = new System.Drawing.Point(265, 113);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(61, 30);
            this.LabelTime.TabIndex = 5;
            this.LabelTime.Text = "Time";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDate.Location = new System.Drawing.Point(33, 113);
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
            // TabPageTimetable
            // 
            this.TabPageTimetable.Controls.Add(this.TextBoxDepartureBoard);
            this.TabPageTimetable.Controls.Add(this.DataGridDepartureBoard);
            this.TabPageTimetable.Controls.Add(this.ButtonDepartureBoard);
            this.TabPageTimetable.Location = new System.Drawing.Point(4, 39);
            this.TabPageTimetable.Name = "TabPageTimetable";
            this.TabPageTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTimetable.Size = new System.Drawing.Size(816, 549);
            this.TabPageTimetable.TabIndex = 1;
            this.TabPageTimetable.Text = "Timetable";
            this.TabPageTimetable.UseVisualStyleBackColor = true;
            // 
            // TextBoxDepartureBoard
            // 
            this.TextBoxDepartureBoard.Location = new System.Drawing.Point(29, 42);
            this.TextBoxDepartureBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDepartureBoard.Name = "TextBoxDepartureBoard";
            this.TextBoxDepartureBoard.Size = new System.Drawing.Size(601, 37);
            this.TextBoxDepartureBoard.TabIndex = 12;
            // 
            // DataGridDepartureBoard
            // 
            this.DataGridDepartureBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDepartureBoard.Location = new System.Drawing.Point(29, 107);
            this.DataGridDepartureBoard.Name = "DataGridDepartureBoard";
            this.DataGridDepartureBoard.RowHeadersWidth = 62;
            this.DataGridDepartureBoard.RowTemplate.Height = 33;
            this.DataGridDepartureBoard.Size = new System.Drawing.Size(751, 372);
            this.DataGridDepartureBoard.TabIndex = 11;
            // 
            // ButtonDepartureBoard
            // 
            this.ButtonDepartureBoard.Location = new System.Drawing.Point(639, 42);
            this.ButtonDepartureBoard.Name = "ButtonDepartureBoard";
            this.ButtonDepartureBoard.Size = new System.Drawing.Size(140, 45);
            this.ButtonDepartureBoard.TabIndex = 10;
            this.ButtonDepartureBoard.Text = "Search";
            this.ButtonDepartureBoard.UseVisualStyleBackColor = true;
            this.ButtonDepartureBoard.Click += new System.EventHandler(this.ButtonDepartureBoardClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageConnections);
            this.TabControl.Controls.Add(this.TabPageTimetable);
            this.TabControl.Controls.Add(this.TabPageNearby);
            this.TabControl.Controls.Add(this.TabPageSearchStation);
            this.TabControl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.Location = new System.Drawing.Point(11, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(824, 592);
            this.TabControl.TabIndex = 0;
            // 
            // TabPageConnections
            // 
            this.TabPageConnections.Controls.Add(this.NumericUpDownMinutes);
            this.TabPageConnections.Controls.Add(this.NumericUpDownHour);
            this.TabPageConnections.Controls.Add(this.ButtonSwitch);
            this.TabPageConnections.Controls.Add(this.ComboBoxTo);
            this.TabPageConnections.Controls.Add(this.ComboBoxFrom);
            this.TabPageConnections.Controls.Add(this.DataGridConnections);
            this.TabPageConnections.Controls.Add(this.ButtonShare);
            this.TabPageConnections.Controls.Add(this.DateTimePicker);
            this.TabPageConnections.Controls.Add(this.ButtonSearch);
            this.TabPageConnections.Controls.Add(this.LabelTime);
            this.TabPageConnections.Controls.Add(this.LabelDate);
            this.TabPageConnections.Controls.Add(this.LabelTo);
            this.TabPageConnections.Controls.Add(this.LabelFrom);
            this.TabPageConnections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabPageConnections.Location = new System.Drawing.Point(4, 39);
            this.TabPageConnections.Name = "TabPageConnections";
            this.TabPageConnections.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageConnections.Size = new System.Drawing.Size(816, 549);
            this.TabPageConnections.TabIndex = 0;
            this.TabPageConnections.Text = "Connections";
            this.TabPageConnections.UseVisualStyleBackColor = true;
            // 
            // NumericUpDownMinutes
            // 
            this.NumericUpDownMinutes.Location = new System.Drawing.Point(332, 145);
            this.NumericUpDownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumericUpDownMinutes.Name = "NumericUpDownMinutes";
            this.NumericUpDownMinutes.Size = new System.Drawing.Size(61, 37);
            this.NumericUpDownMinutes.TabIndex = 10;
            // 
            // NumericUpDownHour
            // 
            this.NumericUpDownHour.Location = new System.Drawing.Point(265, 145);
            this.NumericUpDownHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumericUpDownHour.Name = "NumericUpDownHour";
            this.NumericUpDownHour.Size = new System.Drawing.Size(61, 37);
            this.NumericUpDownHour.TabIndex = 9;
            // 
            // TabPageNearby
            // 
            this.TabPageNearby.Controls.Add(this.ButtonGMaps);
            this.TabPageNearby.Controls.Add(this.GMapControl);
            this.TabPageNearby.Controls.Add(this.ButtonSearchMap);
            this.TabPageNearby.Location = new System.Drawing.Point(4, 39);
            this.TabPageNearby.Name = "TabPageNearby";
            this.TabPageNearby.Size = new System.Drawing.Size(816, 549);
            this.TabPageNearby.TabIndex = 2;
            this.TabPageNearby.Text = "Map";
            this.TabPageNearby.UseVisualStyleBackColor = true;
            // 
            // GMapControl
            // 
            this.GMapControl.Bearing = 0F;
            this.GMapControl.CanDragMap = true;
            this.GMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapControl.GrayScaleMode = false;
            this.GMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapControl.LevelsKeepInMemory = 5;
            this.GMapControl.Location = new System.Drawing.Point(29, 130);
            this.GMapControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GMapControl.MarkersEnabled = true;
            this.GMapControl.MaxZoom = 2;
            this.GMapControl.MinZoom = 2;
            this.GMapControl.MouseWheelZoomEnabled = true;
            this.GMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapControl.Name = "GMapControl";
            this.GMapControl.NegativeMode = false;
            this.GMapControl.PolygonsEnabled = true;
            this.GMapControl.RetryLoadTile = 0;
            this.GMapControl.RoutesEnabled = true;
            this.GMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapControl.ShowTileGridLines = false;
            this.GMapControl.Size = new System.Drawing.Size(750, 353);
            this.GMapControl.TabIndex = 12;
            this.GMapControl.Zoom = 0D;
            // 
            // ButtonSearchMap
            // 
            this.ButtonSearchMap.Location = new System.Drawing.Point(29, 38);
            this.ButtonSearchMap.Name = "ButtonSearchMap";
            this.ButtonSearchMap.Size = new System.Drawing.Size(463, 45);
            this.ButtonSearchMap.TabIndex = 11;
            this.ButtonSearchMap.Text = "GMAP";
            this.ButtonSearchMap.UseVisualStyleBackColor = true;
            this.ButtonSearchMap.Click += new System.EventHandler(this.ButtonSearchMapClick);
            // 
            // TabPageSearchStation
            // 
            this.TabPageSearchStation.Controls.Add(this.DataGridSearchStation);
            this.TabPageSearchStation.Controls.Add(this.ButtonSearchStation);
            this.TabPageSearchStation.Controls.Add(this.TextBoxSearchStation);
            this.TabPageSearchStation.Location = new System.Drawing.Point(4, 39);
            this.TabPageSearchStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageSearchStation.Name = "TabPageSearchStation";
            this.TabPageSearchStation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageSearchStation.Size = new System.Drawing.Size(816, 549);
            this.TabPageSearchStation.TabIndex = 3;
            this.TabPageSearchStation.Text = "Search Station";
            this.TabPageSearchStation.UseVisualStyleBackColor = true;
            // 
            // DataGridSearchStation
            // 
            this.DataGridSearchStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSearchStation.Location = new System.Drawing.Point(29, 107);
            this.DataGridSearchStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridSearchStation.Name = "DataGridSearchStation";
            this.DataGridSearchStation.RowHeadersWidth = 62;
            this.DataGridSearchStation.RowTemplate.Height = 25;
            this.DataGridSearchStation.Size = new System.Drawing.Size(751, 372);
            this.DataGridSearchStation.TabIndex = 2;
            // 
            // ButtonSearchStation
            // 
            this.ButtonSearchStation.Location = new System.Drawing.Point(639, 42);
            this.ButtonSearchStation.Name = "ButtonSearchStation";
            this.ButtonSearchStation.Size = new System.Drawing.Size(140, 45);
            this.ButtonSearchStation.TabIndex = 1;
            this.ButtonSearchStation.Text = "Search";
            this.ButtonSearchStation.UseVisualStyleBackColor = true;
            this.ButtonSearchStation.Click += new System.EventHandler(this.ButtonSearchStationClick);
            // 
            // TextBoxSearchStation
            // 
            this.TextBoxSearchStation.Location = new System.Drawing.Point(29, 42);
            this.TextBoxSearchStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSearchStation.Name = "TextBoxSearchStation";
            this.TextBoxSearchStation.Size = new System.Drawing.Size(605, 37);
            this.TextBoxSearchStation.TabIndex = 0;
            // 
            // ButtonGMaps
            // 
            this.ButtonGMaps.Location = new System.Drawing.Point(498, 38);
            this.ButtonGMaps.Name = "ButtonGMaps";
            this.ButtonGMaps.Size = new System.Drawing.Size(281, 45);
            this.ButtonGMaps.TabIndex = 13;
            this.ButtonGMaps.Text = "Search on Google Maps";
            this.ButtonGMaps.UseVisualStyleBackColor = true;
            this.ButtonGMaps.Click += new System.EventHandler(this.ButtonGMaps_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 617);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Swiss Transport";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConnections)).EndInit();
            this.TabPageTimetable.ResumeLayout(false);
            this.TabPageTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDepartureBoard)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPageConnections.ResumeLayout(false);
            this.TabPageConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHour)).EndInit();
            this.TabPageNearby.ResumeLayout(false);
            this.TabPageSearchStation.ResumeLayout(false);
            this.TabPageSearchStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearchStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button ButtonShare;
        private DateTimePicker DateTimePicker;
        private Button ButtonSearch;
        private Label LabelTime;
        private Label LabelDate;
        private Label LabelTo;
        private Label LabelFrom;
        private DataGridView DataGridConnections;
        private ComboBox ComboBoxFrom;
        private ComboBox ComboBoxTo;
        private Button ButtonSwitch;
        private TabPage TabPageTimetable;
        private TabControl TabControl;
        private TabPage TabPageConnections;
        private TabPage TabPageNearby;
        private Button ButtonSearchMap;
        private TextBox TextBoxDepartureBoard;
        private Button ButtonDepartureBoard;
        private DataGridView DataGridDepartureBoard;
        private TabPage TabPageSearchStation;
        private TextBox TextBoxSearchStation;
        private Button ButtonSearchStation;
        private DataGridView DataGridSearchStation;
        private GMap.NET.WindowsForms.GMapControl GMapControl;
        private NumericUpDown NumericUpDownHour;
        private NumericUpDown NumericUpDownMinutes;
        private Button ButtonGMaps;
    }
}