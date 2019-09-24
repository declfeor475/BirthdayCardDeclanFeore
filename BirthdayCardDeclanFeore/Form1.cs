using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// Created by Declan Feore
/// September 2019
/// Birthday card  
/// <summary>

namespace BirthdayCardDeclanFeore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //graphics setting for the front of card
            Graphics g = this.CreateGraphics();
            SolidBrush cakeBrush = new SolidBrush(Color.SaddleBrown);
            SolidBrush candleBrush = new SolidBrush(Color.DarkOrange);
            Pen balloonPen = new Pen(Color.CadetBlue, 5);
            SolidBrush balloonBrush = new SolidBrush(Color.CadetBlue);

            //clearing the screen
            g.Clear(Color.Black);

            //the cake  
            g.FillRectangle(cakeBrush, 120, 280, 150, 60);

            //the candles
            g.FillRectangle(candleBrush, 130, 240, 10, 40);
            g.FillRectangle(candleBrush, 150, 245, 10, 35);
            g.FillRectangle(candleBrush, 170, 240, 10, 40);
            g.FillRectangle(candleBrush, 190, 245, 10, 35);
            g.FillRectangle(candleBrush, 210, 240, 10, 40);
            g.FillRectangle(candleBrush, 230, 245, 10, 35);
            g.FillRectangle(candleBrush, 250, 240, 10, 40);

            //the balloons
            g.FillEllipse(balloonBrush, 35, 20, 50, 60);
            g.DrawLine(balloonPen, 60, 80, 60, 160);
            g.FillEllipse(balloonBrush, 115, 50, 50, 60);
            g.DrawLine(balloonPen, 140, 80, 140, 200);
            g.FillEllipse(balloonBrush, 215, 50, 50, 60);
            g.DrawLine(balloonPen, 240, 80, 240, 200);
            g.FillEllipse(balloonBrush, 295, 20, 50, 60);
            g.DrawLine(balloonPen, 320, 80, 320, 160);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //graphics setting for the inside of the card
            Graphics g = this.CreateGraphics();
            SolidBrush greenBrush = new SolidBrush(Color.DarkSeaGreen);
            Font greenFont = new Font("Comic Sans", 32);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            Font goldFont = new Font("Arial", 32);
            Pen balloonPen = new Pen(Color.DarkRed, 5);
            SolidBrush balloonBrush = new SolidBrush(Color.DarkRed);
            SoundPlayer pageSound = new SoundPlayer(Properties.Resources.PageFlip);
            SoundPlayer birthdaySound = new SoundPlayer(Properties.Resources.HappyBirthday);

            //flipping pages in the card
            pageSound.Play();
            g.Clear(Color.SlateGray);

            Thread.Sleep(100);

            g.Clear(Color.DarkGray);

            Thread.Sleep(100);

            g.Clear(Color.Gray);

            Thread.Sleep(100);

            g.Clear(Color.LightGray);

            Thread.Sleep(100);

            g.Clear(Color.White);

            Thread.Sleep(100);

            //Today's your birthday
            g.DrawString("Today's", greenFont, greenBrush, 40, 40);

            Thread.Sleep(300);

            g.DrawString("Your", greenFont, greenBrush, 120, 85);

            Thread.Sleep(300);

            g.DrawString("Birthday", greenFont, greenBrush, 180, 125);

            Thread.Sleep(1000);

            //Happy birthday to ya!
            g.DrawString("Happy", goldFont, goldBrush, 40, 200);

            Thread.Sleep(300);

            g.DrawString("Birthday", goldFont, goldBrush, 120, 245);

            Thread.Sleep(300);

            g.DrawString("To Ya!", goldFont, goldBrush, 180, 290);

            Thread.Sleep(300);

            birthdaySound.Play();

            //the balloons
            g.FillEllipse(balloonBrush, 15, 260, 50, 60);
            g.DrawLine(balloonPen, 40, 320, 40, 400);
            g.FillEllipse(balloonBrush, 345, 20, 50, 60);
            g.DrawLine(balloonPen, 370, 80, 370, 160);
        }
    }
}
