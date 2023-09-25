using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {
        // Variables start here

        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 15; // default gravity speed defined with an integer
        int score = 0;  // default score integer set to 0
        bool gameOver = false;

        // variable ends

        //Random pipe appear
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
         
        private void Group_Click(object sender, EventArgs e)
        {

        }

        private void gameTimereEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity; // link the flappy bird picture box to the gravity, += means it will add the speed of gravity to the picture boxes top location so it will move down

            PipeButton.Left -= pipeSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick

            PipeTop.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign

            ScoreText.Text = "Score:"+ score; // show the current score on the score text label


            // below we are checking if any of the pipes have left the screen
            if (PipeButton.Left < -150)
            {

                // if the bottom pipes location is -150 then we will reset it back to randomly around 750 - 1300 to the score
                PipeButton.Left = rnd.Next(750,1300);
                score++;
            }
            if (PipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to randomly around 850- 1500 add 1 to the score
                PipeTop.Left = rnd.Next(850, 1500);
                score++;
            }


            // the if statement below is checking if the pipe hit the ground, pipes or if the player has left the screen from the top
            // the two pipe symbols stand for OR inside of an if statement so we can have multiple conditions inside of this if statement because its all going to do the same thing
            if (FlappyBird.Bounds.IntersectsWith(PipeButton.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Group.Bounds) ||
                FlappyBird.Top < -25
                )
                // if any of the conditions are met from above then we will run the end game function

                endGame();
            {

            }

            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5)
            {
                pipeSpeed = 15;
                // if score is greater then 10 then we will increase the pipe speed to 15
            }
            if (score >10){
                // if score is greater then 15 then we will increase the pipe speed to 20
                pipeSpeed = 20;
            }if(score > 15)
            {
                // if score is greater then 20 then we will increase the pipe speed to 25
                pipeSpeed = 25;
            }

           

            
        }
        // this is the game key is down event thats linked to the main form
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
            if (e.KeyCode == Keys.R && gameOver) 
            {
                //run the restart function
                RestartGame();
            }

        }
        private void RestartGame()
        {
            gameOver = false;
            FlappyBird.Location = new Point(81, 199);
            PipeTop.Left = 800;
            PipeButton.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            ScoreText.Text = "Score: 0";
            
            restartImage.Enabled  = false;
            restartImage.Visible = false; 

            gameTimer.Start();
        }


        private void endGame()
        {

            // this is the game end function, this function will when the bird touches the ground or the pipes
            gameTimer.Stop(); // stop the main timer
            ScoreText.Text += "Game Over!!! Press R to Retry"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it

            gameOver = true;

            restartImage.Enabled = true;
            restartImage.Visible = true;
        }

        private void ReStartClickEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
