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
            string Connections = comboBox1.Text;
            {
                Connections connect = new Connections();
                var connections = Trans.GetConnections(comboBox1.Text, comboBox2.Text);
                foreach (Connection c in connections.ConnectionList)
                {

                    listBox1.Items.Add("Von" + c.From.Station.Name + "Nach" + c.To.Station.Name + c.From.Departure + c.To.Arrival  + c.Duration);
                }
               if(comboBox1.Text == "" || comboBox2.Text == "")
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
             string suche = comboBox1.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBox1.Items.Add(" " + s.Name );


            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string suche = comboBox2.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBox2.Items.Add(" " + s.Name );


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

