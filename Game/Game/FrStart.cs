using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace Game
{
    public partial class FrStart : Form
    {
        public FrStart()
        {
            InitializeComponent();
        }
        bool checkHistory = false;
        string path = Application.StartupPath;
        private void startgame_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            btstart.BackColor = Color.Brown;
            btstart.ForeColor = Color.AntiqueWhite;
          
            //mới thêm
            btnHistory.BackColor = Color.Brown;
            btnHistory.ForeColor = Color.AntiqueWhite;


        }

        private void startgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics start;
            string s = "RESCUE GAME";
            Font f = new Font("Broadway", 30, FontStyle.Bold);
            StringFormat stf = new StringFormat();
            start = e.Graphics;
            LinearGradientBrush linearGradientBrush;

            linearGradientBrush = new LinearGradientBrush(new Point(210, 120), new Point(350, 300), Color.Red, Color.Gold);
            start.DrawString(s, f, linearGradientBrush, new PointF(120, 50));

            

        }
        //add 6pm 23/10
        private void btstart_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                Form1 f = new Form1();
                f.getUserName = txtName.Text;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("Tên không được trống !!!");
            }

        }
        //add 6pm 23/10
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (checkHistory)
            {
                lbHistory.Visible = false;
                btnHistory.Text = "History";
            }
            else
            {
                btnHistory.Text = "Close";
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(path + @"History\history.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            lbHistory.Items.Add(line);
                        }
                        lbHistory.Visible = true;
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            checkHistory = !checkHistory;
       
        }

        //private void txtName_Click(object sender, EventArgs e)
        //{
        //    if(txtName.Text == "Enter up to 10 characters")
        //    {
        //        txtName.Text = "";
        //    }
        //}

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 10)
            {
                txtName.Text = txtName.Text.Substring(0, 10);
                txtName.SelectionLength = 0;
                txtName.SelectionStart = txtName.Text.Length;
                
            }
        }
    }
}
