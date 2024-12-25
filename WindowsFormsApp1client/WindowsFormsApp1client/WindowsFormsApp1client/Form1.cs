using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1client
{
    public partial class DNS : Form
    {
        public DNS()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            // Populate ComboBox with DNS query types
            cmbQueryType.Items.AddRange(new string[] { "A", "MX", "CNAME", "PTR" });
            cmbQueryType.SelectedIndex = 0; // Set default selection to "A"
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpenWebsite.Enabled = false; // Disable "Open Website" button initially
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            string domain = txtDomain.Text.Trim();
            string queryType = cmbQueryType.SelectedItem.ToString(); // Get selected query type

            if (string.IsNullOrWhiteSpace(domain))
            {
                MessageBox.Show("Please enter a valid domain or IP.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstResults.Items.Clear(); // Clear previous results

            try
            {
                using (TcpClient client = new TcpClient("127.0.0.1", 5050)) // Connect to server
                {
                    NetworkStream stream = client.GetStream();

                    // Send query to server
                    string query = $"{queryType}:{domain}"; // Format query as "Type:Domain"
                    byte[] dataToSend = Encoding.UTF8.GetBytes(query);
                    stream.Write(dataToSend, 0, dataToSend.Length);

                    // Receive response from server
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    lstResults.Items.Add($"Response: {response}"); // Display the response
                    btnOpenWebsite.Enabled = true; // Enable "Open Website" button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Lookup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenWebsite_Click(object sender, EventArgs e)
        {
            string domain = txtDomain.Text.Trim();

            if (!string.IsNullOrWhiteSpace(domain))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"http://{domain}",
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Please enter a valid domain first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDomain.Text = string.Empty;
            lstResults.Items.Clear();
            btnOpenWebsite.Enabled = false; // Disable "Open Website" button
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
