using Microsoft.VisualBasic.ApplicationServices;

namespace CSCI363_GeneralDisarrays_JonsWindow1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
            pictureBox2.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
            pictureBox3.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
            pictureBox4.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
            pictureBox5.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
            pictureBox6.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
            pictureBox7.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170726_094506_12.jpg");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
                pictureBox1.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
                pictureBox2.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
                pictureBox3.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
                pictureBox4.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
                pictureBox5.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
                pictureBox6.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170727_094956_12.jpg");
                pictureBox7.Load("C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\ImagesForSecurityCamera\\IMG_20170726_094506_12.jpg");
            //}
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
