using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace TransportGUI
{
    public partial class Form1 : Form
    {
        public ITransport Trans = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bitte Kontaktieren sie uns unter der Nummer: 079 351 59 84");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Connections = comboBoxVon.Text;
            {
                
                Connections connect = new Connections();
                string date = "&date=" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                string time = "&time=" + dateTimePicker1.Value.Hour + ":" + dateTimePicker1.Value.Minute + ":" + dateTimePicker1.Value.Second;
                var connections = Trans.GetConnections(comboBoxVon.Text, comboBoxNach.Text, date, time);
                if (listView1.Columns.Count==0)
                {
                    listView1.Columns.Add("", 0);
                    listView1.Columns.Add("Startstation",100);
                    listView1.Columns.Add("Endstation",100);
                    listView1.Columns.Add("Abfahrt",100);
                    listView1.Columns.Add("Ankunft",100);
                    listView1.Columns.Add("Dauer",100);
                    
                }listView1.Items.Clear();
                foreach (Connection c in connections.ConnectionList)
                {
                    DateTime departure = Convert.ToDateTime(c.From.Departure);
                    string departuretime = departure.ToShortTimeString();

                    DateTime arrival = Convert.ToDateTime(c.To.Arrival);
                    string arrivaltime = arrival.ToShortTimeString();



                    ListViewItem item1 = new ListViewItem("");

                    item1.SubItems.Add(c.From.Station.Name);
                    item1.SubItems.Add(c.To.Station.Name);
                    item1.SubItems.Add(departuretime);
                    item1.SubItems.Add(arrivaltime);
                    item1.SubItems.Add(c.Duration);

                    listView1.Items.Add(item1);

                    listView1.View = View.Details;
                    listView1.FullRowSelect = true;

                }

                if (comboBoxVon.Text == "" || comboBoxNach.Text == "")
                {
                    MessageBox.Show("Bitte wählen sie eine Station aus");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Update();
        }



        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string suche = comboBoxVon.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBoxVon.Items.Add(" " + s.Name);


            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string suche = comboBoxNach.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBoxNach.Items.Add(" " + s.Name);


            }
        }


        private void Wombocombo(ComboBox cb)
        {
            string cbtext = cb.Text;

            if (cbtext.Length >= 3)
            {
                Stations stations = new Stations();
                stations = Trans.GetStations(cbtext + ",");
                cb.Items.Clear();
                cb.DroppedDown = true;
                cb.SelectionStart = cb.Text.Length;
                foreach (Station s in stations.StationList)
                {
                    cb.Items.Add(s.Name);
                }
            }
        }
        private void comboBoxVon_TextUpdate(object sender, EventArgs e)
        {
            Wombocombo(comboBoxVon);
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            Wombocombo(comboBoxNach);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string von = comboBoxVon.Text;
            string nach = comboBoxNach.Text;
            comboBoxVon.Text = nach;
            comboBoxNach.Text = von;
        }
    }
}