using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FeatureInterface
{
    public partial class GPS : Form
    {
        private Dictionary<string, string> driverPictures = new Dictionary<string, string>();

        public GPS()
        {
            InitializeComponent();
            InitializeDriverPictures();
        }

        private void InitializeDriverPictures()
        {
            driverPictures.Add("Driver1", @"C:\Users\tysou\source\repos\Ty\Geofencing.jpg");
            driverPictures.Add("Driver2", @"C:\Users\tysou\source\repos\Ty\Geofencing2.jpg");
            driverPictures.Add("Driver3", @"C:\Users\tysou\source\repos\Ty\Geofencing3.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowGeofenceDialog("Driver1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowGeofenceDialog("Driver2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowGeofenceDialog("Driver3");
        }

        private void ShowGeofenceDialog(string driverId)
        {
            if (driverPictures.ContainsKey(driverId))
            {
                string imagePath = driverPictures[driverId];
                try
                {
                    if (!System.IO.File.Exists(imagePath))
                    {
                        MessageBox.Show($"Image not found: {imagePath}");
                        return;
                    }

                    Form dialog = new Form
                    {
                        Text = $"{driverId} Geofence",
                        Size = new Size(800, 600),
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(imagePath),
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    dialog.Controls.Add(pictureBox);
                    dialog.ShowDialog();
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("The image file is not a valid format or is too large.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"No image found for driver: {driverId}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editing geofencing...", "Geofencing Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updating map from cloud...", "Map Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying today's history...", "History Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying last week's history...", "History Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying last month's history...", "History Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
