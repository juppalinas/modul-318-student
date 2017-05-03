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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bitte Kontaktieren sie uns unter der Nummer: 079 351 59 84");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Connections = comboBox1.Text;
            {
                ITransport testee = new Transport();
                var connections = testee.GetConnections("Sursee", "Luzern");
                foreach (Connection c in connections.ConnectionList)
                {

                    listBox1.Items.Add(" " + c.From + "X:" + c.To.ToString() + "Score" + c.Duration);
                }
               if(comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Bitte wählen sie eine Station aus");
                }
            }

        }

        
            private void Refresh_Click(object sender, EventArgs e)
        {
            this.Update();
       }
    }
  }

