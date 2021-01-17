using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** 1. When picture box is hovered over, have buttons appear
    2. Upload - allows user to upload an image 
       Delete - allows user to delete an image */
namespace ImageRepository
{
    public partial class Repository : Form
    {
        bool buttonPressed = false;

        public Repository()
        {
            InitializeComponent();
        }

        // method for editButton for picture box 1

        private void editButton_Click(object sender, EventArgs e)
        {

            if (!buttonPressed)
            {
                buttonPressed = true;

                add1.Show(); //show upload button
                delete1.Show(); // show delete button
                add2.Show(); //show upload button
                delete2.Show(); // show delete button
                add3.Show(); //show upload button
                delete3.Show(); // show delete button
            }
            else
            {
                buttonPressed = false;

                add1.Hide(); //show upload button
                delete1.Hide(); // show delete button
                add2.Hide(); //show upload button
                delete2.Hide(); // show delete button
                add3.Hide(); //show upload button
                delete3.Hide(); // show delete button
            }
        }

        // method for upload button for picture box 1
        private void add1_Click(object sender, EventArgs e)
        {

            String imageLocation = "";
            try
            {
                // open file dialog
                OpenFileDialog dialog = new OpenFileDialog();
                // filters out which file types are accepted
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png | JPEG files(*.jpeg)|*.jpeg";

                // opens file explorer dialog box
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                // message box to show if not the right file
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method for delete button for picture box 1
        private void delete1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;   // remove image from pictureBox
        }

        // method for upload button of picture box 2
        private void add2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                // open file dialog
                OpenFileDialog dialog = new OpenFileDialog();
                // filters out which file types are accepted
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png | JPEG files(*.jpeg)|*.jpeg";

                // opens file explorer dialog box
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox2.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                // message box to show if not the right file
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method for delete button for picture box 2
        private void delete2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;   // remove image from pictureBox
        }

        // method for upload button for picture box 3
        private void add3_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                // open file dialog
                OpenFileDialog dialog = new OpenFileDialog();
                // filters out which file types are accepted
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png | JPEG files(*.jpeg)|*.jpeg";

                // opens file explorer dialog box
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox3.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                // message box to show if not the right file
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method for delete button of picture box 3
        private void delete3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = null;   // remove image from pictureBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
