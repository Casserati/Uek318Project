using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            dgvConnections.Rows.Clear();

            Transport transport = new Transport();
            Connections connections = new Connections();


            connections = transport.GetConnections(txtStartstation.Text, cmbFinalstation.Text);

            foreach (var connection in connections.ConnectionList)
            {
                dgvConnections.Rows.Add(connection.From.Station.Name, connection.Duration, connection.To.Station.Name);
            }
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Startstation Combobox</param>
        /// <param name="e"></param>
        private void cmbStartstation_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            Transport transport = new Transport();
            Stations stations = new Stations();

            collection.Clear();

            stations = transport.GetStations(txtStartstation.Text);
            
            foreach (var station in stations.StationList)
            {
                collection.Add(station.Name);
            }


            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            


            txtStartstation.AutoCompleteCustomSource = collection;
        }

        
    }
}
