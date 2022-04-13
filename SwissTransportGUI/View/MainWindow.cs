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

namespace SwissTransportGUI
{
    public partial class MainWindow : Form
    {

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

                    DataGridConnections.Columns["Kante"].Width = 40;
                    DataGridConnections.Columns["Ankunft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                catch (System.ArgumentNullException)
                {
                    string error = "Bitte füllen Sie das erwünschte Start- und Endziel ein";
                    MessageBox.Show(error);
                }
            }
        }
        private void ButtonSearchTimetableClick(object sender, EventArgs e)
        {

            if (ComboBoxTimetable.Text != "")
            {

                try
                {
                    DataGridTimetable.Rows.Clear();
                    SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                    SwissTransport.Models.Connections connections = new SwissTransport.Models.Connections();
                    connections = transport.GetConnections(ComboBoxTimetable.Text, ComboBox2.Text);

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


                    DataGridTimetable.DataSource = connectionViewModels;

                    DataGridTimetable.Columns["Kante"].Width = 40;
                    DataGridTimetable.Columns["Ankunft"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                catch (System.ArgumentNullException)
                {
                    string error = "Bitte füllen Sie das erwünschte Start- und Endziel ein";
                    MessageBox.Show(error);
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
        public void TextBoximeTextChanged(object sender, EventArgs e)
        {

        }
    }
}