using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportUI
{
    public partial class applicationForm : Form
    {
        public applicationForm()
        {
            InitializeComponent();
        }

        private Connections connections { get; set; }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            dgvConnections.Rows.Clear();

            Transport transport = new Transport();
            DateTime dateTime = new DateTime();

            dateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            if (cmbStartstation.Text != cmbFinalstation.Text)
            {
                connections = transport.GetConnections(cmbStartstation.Text, cmbFinalstation.Text, dateTime);
                if (connections.ConnectionList.Count == 0)
                {
                    MessageBox.Show($"Es bestehen keine Verbindungen zwischen {cmbStartstation.Text} und {cmbFinalstation.Text} um {dateTime.ToString("dd:MM:yyyy")}", "WARNUNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    foreach (var connection in connections.ConnectionList.Where(c => dateTime <= Convert.ToDateTime(c.From.Departure)))
                    {
                        /* removing the unnessesary chars in the Duration time => 00d00:10:00 --> 00:10 */
                        dgvConnections.Rows.Add(connection.From.Departure.ToString("HH:mm"),connection.From.Station.Name, connection.Duration.Remove(0,3).Remove(5,3), connection.To.Station.Name);
                    }
                }
            }else
            {
                MessageBox.Show("Die Start- und Endstation dürfen nicht gleich sein.", "WARNUNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void autoComplete(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            Stations stations = new Stations();
            ComboBox input = (ComboBox)sender;

            /* activate autoComplete if the lenght of the input is two or over */
            if (input.Text.Length >= 2) {
                    stations = transport.GetStations(input.Text);
                foreach (var station in stations.StationList)
                {
                    try
                    {
                        input.Items.Add(station.Name);
                    }
                    catch (ArgumentNullException exception){
                        Console.WriteLine(exception);
                    }
                    }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            dgvDepartureTable.Rows.Clear();

            Transport transport = new Transport();
            var stationBoard = transport.GetStationBoard(cmbStation.Text).Entries; 

            foreach (var station in stationBoard)
            {
                dgvDepartureTable.Rows.Add(station.Name, station.Stop.Departure.ToShortTimeString(), station.To);
            }
        }

        private void dgvConnections_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* opens user standard-browser on double-click with connection with the start and  destionation of his inputs */
            string googleMapLocation = $"maps/dir/{cmbStartstation.Text}/{cmbFinalstation.Text}";
            System.Diagnostics.Process.Start($"http://google.com/{googleMapLocation}/");
        }

        private void dgvDepartureTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* opens the connection which was double-clicked in the stationboard datagridview*/
            string googleMapLocation = $"maps/dir/{cmbStation.Text}/{dgvDepartureTable.CurrentRow.Cells[2].Value.ToString()}";
            System.Diagnostics.Process.Start($"http://google.com/{googleMapLocation}/");
        }

        
    }
}
