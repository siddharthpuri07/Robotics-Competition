using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerial_Assist_Souting_C
{
    public partial class Rating : Form
    {

        public Rating(string text1, string text2, string text3, string text4, string text5)
        {
            InitializeComponent();
            int tb1Value;
            Int32.TryParse(tb1.Text, out tb1Value);
            trackBar1.Value = tb1Value;
            
            tb1.Text = text1;
            tb2.Text = text2;
            tb3.Text = text3;
            tb4.Text = text4;
            tb5.Text = text5;
        }

        //private void Rating_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Do You Want To Save Your Data", "CodeJuggler", MessageBoxButtons.YesNoCancel);
        //    if (dialogResult == DialogResult.Yes) { }
        //    else if (dialogResult == DialogResult.Cancel) e.Cancel = true;
        //}
        //public PerformaceData(string text1, string text2, string text3, string text4, string text5)
        //{
        //    tb1.Text = text1;
        //    tb2.Text = text2;
        //    tb3.Text = text3;
        //    tb4.Text = text4;
        //    tb5.Text = text5;
        //}


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb1.Text = trackBar1.Value.ToString();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            tb2.Text = trackBar2.Value.ToString();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            tb3.Text = trackBar3.Value.ToString();

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            tb4.Text = trackBar4.Value.ToString();

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            tb5.Text = trackBar5.Value.ToString();

        }

        private void Rating_Load(object sender, EventArgs e)
        {

        }

        private void Rating_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;             
        }
    }
}
