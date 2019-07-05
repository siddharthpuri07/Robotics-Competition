using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;


using CsvHelper;

namespace Aerial_Assist_Souting_C
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(470, 670);
            ratingGroup.Visible = false;
            listView.HotTracking = true;
        }

        //string match;
        string imagePath;

        public string test1 { get; private set; }
        public string test2 { get; private set; }
        public string test3 { get; private set; }
        public string test4 { get; private set; }

        /// <summary>Triggered when a combobox is is created. </summary>
        /// <param name="sender">The ComboBox that was created</param>
        ///<param name="e">Details of the event that was triggered</param>
        private void comboBox_VisibleChanged(object sender, EventArgs e)
        {
            // This method handles event for all the comboxBox.
            // Using "Visual Studio" event in "Design" I can set all
            // the visibleChanged to this method therefore this sets
            // all the comboBox selectedIndex to 0
            ComboBox cb = (ComboBox)sender;
            cb.SelectedIndex = 0;

        }

        /// <summary> Triggered when the selected index of a ComboBox is changed.</summary>
        /// <param name="sender">The ComboBox that was altered</param>
        /// <param name="e">Details of the event that was triggered</param>
        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            // Gets the selected index number for switch case
            int index = cb.SelectedIndex;
            // Set the foreground color(the text) to white.
            cb.ForeColor = Color.White;
            //Colour Code for User-interface to differntiate yes =Green,no=Red,unknown=Orange
            switch (index)
            {
                case 0:
                    {
                        cb.BackColor = Color.Orange;
                        break;
                    }
                case 1:
                    {
                        cb.BackColor = Color.Green;
                        break;
                    }
                case 2:
                    {
                        cb.BackColor = Color.Red;
                        break;
                    }
            }

            //User selects either pre-match option or in-match option from radio button before putting in any details
            if (preMatch.Checked == false && InMatch.Checked == false && index != 0)
            {
                cb.SelectedIndex = 0;
                MessageBox.Show("Please Select Pre Match or In Match Button above");
            }
        }

        private void TeamNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If they typed in something other than backspace or a number...
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // writting a CSV file
        static void WriteCsvFile(string filename, IEnumerable<Record> people)
        {
            TextWriter textWriter = File.CreateText(filename);

            var csvWriter = new CsvWriter(textWriter);
            csvWriter.WriteRecords(people);

            textWriter.Close();

        }
        // the Save button saves the data of the form to CSV file
        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var filename = sfd.FileName;
                    //list of all coloumn in the csv file and the data that will be entered by the user respectively.
                    List<Record> list = new List<Record>() {
                new  Record(){Name= TeamNameBox.Text, Number= TeamNumberBox.Text,
                DriveFoward = AutoForwardBox.Text, AutoLowGoal = AutoLowGoalBox.Text,
                   AutoHighGoal = AutoHighGoalBox.Text,PassBall= PassBallBox.Text, CatchBall = CatchBallBox.Text,
                       PickUpBall = PickUpBallBox.Text, MiddleBall = MiddleBarBox.Text, LowGoal = LowGoalBox.Text,
                    HighGoal=  HighGoalBox.Text, OverallDefence = tb1.Text, Maneuverability = tb2.Text,
                Speed = tb3.Text, HighGoalAccuracy = tb4.Text, OverallAttack = tb5.Text, url = imagePath, Description = ds.Text  }
        };
                    WriteCsvFile(filename, list);
                    listView.Items.Add(filename);
                }
            }
        }

        //Load button to open up a pre-exisiting CSV file and load its information in the form.
        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open CSV File";
            theDialog.Filter = "CSV (*.csv)|*.csv";
            theDialog.InitialDirectory = @"C:\";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                using (var sr = new StreamReader(filename))
                {
                    var reader = new CsvReader(sr);

                    //CSVReader will now read the whole file into an enumerable
                    IEnumerable<Record> records = reader.GetRecords<Record>();

                    //records in CSV file will be printed to the Output Window
                    foreach (Record record in records)
                    {
                        TeamNameBox.Text = record.Name;
                        TeamNumberBox.Text = record.Number;

                        AutoForwardBox.Text = record.DriveFoward;
                        AutoLowGoalBox.Text = record.AutoLowGoal;
                        AutoHighGoalBox.Text = record.AutoHighGoal;

                        PassBallBox.Text = record.PassBall;
                        CatchBallBox.Text = record.PassBall;
                        PickUpBallBox.Text = record.PickUpBall;
                        MiddleBarBox.Text = record.MiddleBall;
                        LowGoalBox.Text = record.LowGoal;
                        HighGoalBox.Text = record.HighGoal;

                        tb1.Text = record.OverallDefence;
                        tb2.Text = record.Maneuverability;
                        tb3.Text = record.Speed;
                        tb4.Text = record.HighGoalAccuracy;
                        tb5.Text = record.OverallDefence;
                        ds.Text = record.Description;
                        
                        int tbValue1 =0, tbValue2=0, tbValue3=0, tbValue4=0, tbValue5=0;


                        Int32.TryParse(tb1.Text, out tbValue1);
                        Int32.TryParse(tb2.Text, out tbValue2);
                        Int32.TryParse(tb3.Text, out tbValue3);
                        Int32.TryParse(tb4.Text, out tbValue4);
                        Int32.TryParse(tb5.Text, out tbValue5);
                        trackBar1.Value = tbValue1;
                        trackBar2.Value = tbValue2;
                        trackBar3.Value = tbValue3;
                        trackBar4.Value = tbValue4;
                        trackBar5.Value = tbValue5;

                    }
                }
            }
        }



        #region //Performance Rating
        //Performance area in the form with all the diffetrent abilities that a robot can be marked against using a scroll bar.
        private void ratingBtn_Click(object sender, EventArgs e)
        {
            ratingGroup.Visible = true;
        }

        private void ratingHideBtn_Click(object sender, EventArgs e)
        {
            ratingGroup.Visible = false;
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            tb1.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            tb2.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll_1(object sender, EventArgs e)
        {
            tb3.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_Scroll_1(object sender, EventArgs e)
        {
            tb4.Text = trackBar4.Value.ToString();
        }

        private void trackBar5_Scroll_1(object sender, EventArgs e)
        {
            tb5.Text = trackBar5.Value.ToString();
        }

        #endregion

       

        private void loadimgBtn_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                imagePath = open.FileName;
            }
        }

        private void saveimgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(@"Path", ImageFormat.Jpeg);
                MessageBox.Show(@"path");
            }
        }


        
        //Size settings for screen  including the default and extended value.
        private void saveList_Click(object sender, EventArgs e)
        {
            this.Size = new Size(980, 670);
        }
        private void detfaultSizeBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(470, 670);
        }

        private void listView_ItemActivate_1(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullName = System.IO.Path.Combine(desktopPath, listView.SelectedItems[0].Text);
            Process proc = Process.Start(fullName);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RatingGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
