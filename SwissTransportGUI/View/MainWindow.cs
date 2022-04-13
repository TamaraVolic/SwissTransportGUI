using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransportGUI.ViewModels;
using GMap.NET.MapProviders;

namespace SwissTransportGUI
{
    public partial class MainWindow : Form
    {
        ITransport transport = new Transport();

        public MainWindow()
        {
            InitializeComponent();
        }



        //Funktion um mit einem Klick auf den "Verbindungen suchen" Button, die 4 nächsten Verbindungen angezeigt zu bekommen.
        private void ButtonSearchClick(object sender, EventArgs e)
        {

            if (ComboBoxTo.Text != "")
            {

                try
                {
                    DataGridConnections.Rows.Clear();
                    SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                    SwissTransport.Models.Connections connections = new SwissTransport.Models.Connections();
                    connections = transport.GetConnections(ComboBoxFrom.Text, ComboBoxTo.Text);

                    BindingList<ConnectionViewModel> connectionViewModels = new BindingList<ConnectionViewModel>();


                    foreach (Connection connection in connections.ConnectionList)
                    {
                        ConnectionViewModel vm = new ConnectionViewModel();
                        vm.Abfahrt = connection.From.Departure.ToString();
                        vm.Von = connection.From.Station.Name;
                        vm.Ankunft = connection.To.Arrival.ToString();
                        vm.Nach = connection.To.Station.Name;
                        vm.Kante = connection.From.Platform;

                        connectionViewModels.Add(vm);

                    }


                    DataGridConnections.DataSource = connectionViewModels;

                    DataGridConnections.Columns["Kante"].Width = 50;
                    DataGridConnections.Columns["Ankunft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                catch (System.ArgumentNullException)
                {
                    string fehler = "Bitte füllen Sie das erwünschte Start- und Endziel ein";
                    MessageBox.Show(fehler);
                }
            }
        }
        


            //Funktion um Start- und Endstation zu tauschen
            private void ButtonSwitchClick(object sender, EventArgs e)
        {
            string tempStation = ComboBoxFrom.Text;
            ComboBoxFrom.Text = ComboBoxTo.Text;
            ComboBoxTo.Text = tempStation;
        }
        void FormLoad(object sender, EventArgs e)
        {
            TextBoxTime.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
        }
        public void TextBoxTimeTextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSearchMapClick(object sender, EventArgs e)
        {
            GMapControl.MapProvider = GMapProviders.GoogleMap;
        }

        private void ButtonDepartureBoardClick(object sender, EventArgs e)
        {
            searchStationBoard(TextBoxDepartureBoard.Text);
        }

        public void searchStationBoard(string station)
        {
            List<StationBoard> boards = transport.GetStationBoard(station, "").Entries;
            DataGridDepartureBoard.DataSource = null;
            List<StationBoardViewModel> viewModels = new List<StationBoardViewModel>();
            foreach (StationBoard board in boards)
            {
                StationBoardViewModel vm = new StationBoardViewModel();
                vm.Zielort = board.To;
                vm.Linie = board.Category + board.Number;
                vm.Abfahrtszeit = board.Stop.Departure.ToLongTimeString();
                viewModels.Add(vm);
            }

            DataGridDepartureBoard.DataSource = viewModels;
            DataGridDepartureBoard.Columns["Abfahrtszeit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ButtonSearchStation_Click(object sender, EventArgs e)
        {
            searchStation(TextBoxSearchStation.Text);
        }
        public void searchStation(string query)
        {
            List<Station> stations = transport.GetStations(query).StationList;

            DataGridSearchStation.DataSource = stations;

            DataGridSearchStation.Columns["Score"].Visible = false;
            DataGridSearchStation.Columns["Coordinate"].Visible = false;
            DataGridSearchStation.Columns["Distance"].Visible = false;

            DataGridSearchStation.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}