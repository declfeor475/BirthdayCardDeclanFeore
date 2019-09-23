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
            SolidBrush candleBrush = new SolidBrush(Color.CadetBlue);

            //the cake and candles 
            g.FillRectangle(cakeBrush, 120, 280, 150, 60);
            g.FillRectangle(candleBrush, 130, 240, 10, 40);
            g.FillRectangle(candleBrush, 150, 245, 10, 35);
            g.FillRectangle(candleBrush, 170, 240, 10, 40);
            g.FillRectangle(candleBrush, 190, 245, 10, 35);
            g.FillRectangle(candleBrush, 210, 240, 10, 40);
            g.FillRectangle(candleBrush, 230, 245, 10, 35);
            g.FillRectangle(candleBrush, 250, 240, 10, 40);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //graphics setting for the inside of the card
            Graphics g = this.CreateGraphics();
            SolidBrush roseBrush = new SolidBrush(Color.Red);
            Font roseFont = new Font("Comic Sans", 32);
            SolidBrush violetBrush = new SolidBrush(Color.Blue);
            Font violetFont = new Font("Comic Sans", 32);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            Font goldFont = new Font("Comic Sans", 32);

            //clear the screen
            g.Clear(Color.White);

            //rose text and image
            g.DrawString("Roses", roseFont, roseBrush, 40, 40);

            Thread.Sleep(300);

            g.DrawString("Are", roseFont, roseBrush, 120, 80);

            Thread.Sleep(300);

            g.DrawString("Red", roseFont, roseBrush, 180, 120);

            Thread.Sleep(300);

            //violet text and image
            g.DrawString("Violets", violetFont, violetBrush, 30, 120);

            Thread.Sleep(300);

            g.DrawString("Are", violetFont, violetBrush, 130, 160);

            Thread.Sleep(300);

            g.DrawString("Blue", violetFont, violetBrush, 180, 200);

            Thread.Sleep(300);
            
            //violet text and image
            g.DrawString("Happy", goldFont, goldBrush, 40, 200);

            Thread.Sleep(300);

            g.DrawString("Birthday", goldFont, goldBrush, 120, 240);

            Thread.Sleep(300);

            g.DrawString("To You!", goldFont, goldBrush, 160, 280);

            Thread.Sleep(300);
        }
    }
}
