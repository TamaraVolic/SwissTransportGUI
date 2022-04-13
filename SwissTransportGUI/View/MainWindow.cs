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

        //Funktion um Vorschläge zu der eingegebenen Endstation zu bekommen
        private void ComboBoxTo_DropDown(object sender, EventArgs e)
        {

        }

        //Funktion um mit einem Klick auf den "Verbindungen suchen" Button, die 4 nächsten Verbindungen angezeigt zu bekommen.
        private void ButtonSearch_Click(object sender, EventArgs e)
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
                    string fehler = "Bitte füllen Sie das erwünschte Start- und Endziel ein";
                    MessageBox.Show(fehler);
                }
            } 
            else
            {
                fillListboxConnections(ComboBoxFrom.Text);
            }
            //Funktion um die Abfahrtstafel zu befüllen.
             void fillListboxConnections(string fromName)
            {
                try
                {
                    ListBoxConnections.Items.Clear();
                    SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                    SwissTransport.Models.Connections connections = new SwissTransport.Models.Connections();
                    SwissTransport.Models.StationBoardRoot stationboardroot = new SwissTransport.Models.StationBoardRoot();

                    stationboardroot = transport.GetStationBoard(ComboBoxFrom.Text, "0");
                    for (int i = 0; i < stationboardroot.Entries.Count; i++)
                    {
                        string[] text = new string[2];
                        text[0] = Convert.ToString(stationboardroot.Station.Name);
                        text[1] = stationboardroot.Entries[i].To;
                        ListBoxConnections.Items.Add(text[1]);
                    }
                }
                catch (System.ArgumentNullException)
                {
                    string fehler = "Bitte füllen Sie das erwünschte Start- und Endziel ein";
                    MessageBox.Show(fehler);
                }
            }
        }

        //Funktion um Start- und Endstation zu tauschen
        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            string tempStation = ComboBoxFrom.Text;
            ComboBoxFrom.Text = ComboBoxTo.Text;
            ComboBoxTo.Text = tempStation;
        }
        void Form_Load(object sender, EventArgs e)
        {
            TextBoxTime.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
        }
        public void TextBoxime_TextChanged(object sender, EventArgs e)
        {

        }

    }
}