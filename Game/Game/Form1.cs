using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;
        //add
        bool reverseOne = false;
        bool reverseTwo = false;
        string userName = "";
        //
        string path = Application.StartupPath;
        public Form1()
        {
            InitializeComponent();
        }
        public string getUserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbName.Text = "Name: " + userName;
        }
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {


                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            //force = 28;
                            force = 8;
                            player.Top = x.Top - player.Height;


                            if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }


                        }

                        x.BringToFront();

                    }

                    if ((string)x.Tag == "corona")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }


                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + "\nYou were killed in your journey!!";
                            gameOver();

                        }
                    }

                }
            }


            horizontalPlatform.Left -= horizontalSpeed;

            if (horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            verticalPlatform.Top += verticalSpeed;

            if (verticalPlatform.Top < 230 || verticalPlatform.Top > 800)
            {
                verticalSpeed = -verticalSpeed;
            }


            enemyOne.Left -= enemyOneSpeed;

            if (enemyOne.Left < pictureBox5.Left || enemyOne.Left + enemyOne.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;

                reverseOne = !reverseOne;
                if(reverseOne)
                {
                    enemyOne.BackgroundImage = Image.FromFile(path + @"\Image\enemyRight.png");
                }
                else
                {
                    enemyOne.BackgroundImage = Image.FromFile(path + @"\Image\enemyLeft.png");
                }
            }

            enemyTwo.Left += enemyTwoSpeed;

            if (enemyTwo.Left < pictureBox2.Left || enemyTwo.Left + enemyTwo.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;

                reverseTwo = !reverseTwo;
                if (reverseTwo)
                {
                    enemyTwo.BackgroundImage = Image.FromFile(path + @"\Image\enemyLeft.png");
                }
                else
                {
                    enemyTwo.BackgroundImage = Image.FromFile(path + @"\Image\enemyRight.png");
                }
            }


            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + "\nYou fell to your death!";
                gameOver();
                
                
            }

            if (player.Bounds.IntersectsWith(door.Bounds) && score == 26)
            {
                gameTimer.Stop();
                isGameOver = true;
                //add 6pm 23/10
                saveFile();
                txtScore.Text = "Score: " + score + "\nYour quest is complete!";
                pictureBox7.BackgroundImage = Image.FromFile(path + @"\Image\victory.jpg");
                pictureBox7.Visible = true;
                btnExit.Visible = true;
                btnRestart.Visible = true;

            }
            else
            {
                txtScore.Text = "Score: " + score + "\nCollect all the corona";
            }


        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the game?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.No)
            {
               e.Cancel = true;
            }
          
        }



        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }



        }

        private void RestartGame()
        {

            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }


            // reset the position of player, platform and enemies

            player.Left = 72;
            player.Top = 656;

            enemyOne.Left = 471;
            enemyTwo.Left = 400;

            horizontalPlatform.Left = 275;
            verticalPlatform.Top = 581;

            //add 6pm 23/10
            pictureBox7.Visible = false;
            btnExit.Visible = false;
            btnRestart.Visible = false;
            this.Focus();
            gameTimer.Start();


        }
        //add 6pm 23/10
        private void saveFile()
        {
            StreamWriter streamWriter;
            if (!File.Exists(path + @"History\history.txt"))
            {
                streamWriter = new StreamWriter(path + @"History\history.txt");
                streamWriter.WriteLine(string.Format("User Name: {0} -- Score: {1} -- DateTime: {2}", userName, score, DateTime.Now));
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(path + @"History\history.txt");
                streamWriter.WriteLine(string.Format("User Name: {0} -- Score: {1} -- DateTime: {2}", userName, score, DateTime.Now));
                streamWriter.Close();
            }
        }
        private void gameOver()
        {
            pictureBox7.BackgroundImage = Image.FromFile(path + @"\Image\gameover.png");
            pictureBox7.Visible = true;
            btnExit.Visible = true;
            btnRestart.Visible = true;
            saveFile();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

    }
}






