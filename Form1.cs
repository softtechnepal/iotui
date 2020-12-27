using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomButtonDesign();

        }

        private void powerform_load(object sender, EventArgs e)
        {
            /*int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(width, height);*/
            // WindowState = FormWindowState.Maximized;
            timer1.Start();

            //panel2.BackColor = Color.FromArgb(25, Color.Blue);
        }

        private void btnManual_Click(object sender, EventArgs e)
        {

        }

        private void btnAutomatic_Click(object sender, EventArgs e)
        {

        }
        private void CustomButtonDesign()
        {
            btnAutomatic.TabStop = false;
            btnAutomatic.FlatStyle = FlatStyle.Flat;
            btnAutomatic.FlatAppearance.BorderSize = 0;

            btnManual.TabStop = false;
            btnManual.FlatStyle = FlatStyle.Flat;
            btnManual.FlatAppearance.BorderSize = 0;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;

            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

            button7.TabStop = false;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;

            button8.TabStop = false;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;

            button9.TabStop = false;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;

            button10.TabStop = false;
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;

            button11.TabStop = false;
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 0;

            button12.TabStop = false;
            button12.FlatStyle = FlatStyle.Flat;
            button12.FlatAppearance.BorderSize = 0;

            button13.TabStop = false;
            button13.FlatStyle = FlatStyle.Flat;
            button13.FlatAppearance.BorderSize = 0;

            button14.TabStop = false;
            button14.FlatStyle = FlatStyle.Flat;
            button14.FlatAppearance.BorderSize = 0;

            button15.TabStop = false;
            button15.FlatStyle = FlatStyle.Flat;
            button15.FlatAppearance.BorderSize = 0;

            button16.TabStop = false;
            button16.FlatStyle = FlatStyle.Flat;
            button16.FlatAppearance.BorderSize = 0;

            button17.TabStop = false;
            button17.FlatStyle = FlatStyle.Flat;
            button17.FlatAppearance.BorderSize = 0;

            button18.TabStop = false;
            button18.FlatStyle = FlatStyle.Flat;
            button18.FlatAppearance.BorderSize = 0;

            button19.TabStop = false;
            button19.FlatStyle = FlatStyle.Flat;
            button19.FlatAppearance.BorderSize = 0;

            button20.TabStop = false;
            button20.FlatStyle = FlatStyle.Flat;
            button20.FlatAppearance.BorderSize = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dt.ToString("hh:mm:ss");

            this.lblTimeShow.Text = dt.ToString("hh:mm:ss");
        }
    }
}
