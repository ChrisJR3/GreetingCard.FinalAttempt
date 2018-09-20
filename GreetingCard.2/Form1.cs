using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Created By: Chris Rouse
/// Date: Sept 2018
/// Description: A card trick.
/// </summary>
namespace GreetingCard._2
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void Background_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);

            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redbrush = new SolidBrush(Color.Red);
            SolidBrush greenbrush = new SolidBrush(Color.Green);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            Font Large = new Font("TimesNewRoman", 64, FontStyle.Bold);
            Font Ariel = new Font("Ariel", 16, FontStyle.Bold);
            Font Cards = new Font("Comfortaa", 16, FontStyle.Bold);

            //For diamonds

            Point[] diamond1 = new Point[4];
            diamond1[0] = new Point(65, 70);
            diamond1[1] = new Point(85, 90);
            diamond1[2] = new Point(65, 110);
            diamond1[3] = new Point(45, 90);

            Point[] diamond2 = new Point[4];
            diamond1[0] = new Point(165, 70);
            diamond1[1] = new Point(185, 90);
            diamond1[2] = new Point(165, 110);
            diamond1[3] = new Point(145, 90);

            Point[] diamond3 = new Point[4];
            diamond1[0] = new Point(265, 70);
            diamond1[1] = new Point(285, 90);
            diamond1[2] = new Point(265, 110);
            diamond1[3] = new Point(245, 90);

            Point[] diamond4 = new Point[4];
            diamond1[0] = new Point(365, 70);
            diamond1[1] = new Point(385, 90);
            diamond1[2] = new Point(365, 110);
            diamond1[3] = new Point(345, 90);

            //Lower Half

            Point[] diamond5 = new Point[4];
            diamond1[0] = new Point(65, 340);
            diamond1[1] = new Point(85, 360);
            diamond1[2] = new Point(65, 380);
            diamond1[3] = new Point(45, 360);

            Point[] diamond6 = new Point[4];
            diamond1[0] = new Point(165, 340);
            diamond1[1] = new Point(185, 360);
            diamond1[2] = new Point(165, 380);
            diamond1[3] = new Point(145, 360);

            Point[] diamond7 = new Point[4];
            diamond1[0] = new Point(265, 340);
            diamond1[1] = new Point(285, 360);
            diamond1[2] = new Point(265, 380);
            diamond1[3] = new Point(245, 360);

            Point[] diamond8 = new Point[4];
            diamond1[0] = new Point(365, 340);
            diamond1[1] = new Point(385, 360);
            diamond1[2] = new Point(365, 380);
            diamond1[3] = new Point(345, 360);

            g.Clear(Color.Red);

            g.DrawRectangle(drawPen, 30, 30, 100, 150);
            g.FillRectangle(whiteBrush, 30, 30, 100, 150);
            g.FillPolygon(blackBrush, diamond1);
            g.DrawString("A", Cards, blackBrush, 35, 35);
            g.DrawString("A", Cards, blackBrush, 105, 155);

            g.DrawRectangle(drawPen, 210, 30, 100, 150);
            g.FillRectangle(whiteBrush, 210, 30, 100, 150);
            g.FillPolygon(blackBrush, diamond2);
            g.DrawString("A", Cards, blackBrush, 215, 35);
            g.DrawString("A", Cards, blackBrush, 285, 155);

            g.DrawRectangle(drawPen, 390, 30, 100, 150);
            g.FillRectangle(whiteBrush, 390, 30, 100, 150);
            g.FillPolygon(blackBrush, diamond3);
            g.DrawString("A", Cards, blackBrush, 395, 35);
            g.DrawString("A", Cards, blackBrush, 465, 155);

            g.DrawRectangle(drawPen, 570, 30, 100, 150);
            g.FillRectangle(whiteBrush, 570, 30, 100, 150);
            g.FillPolygon(blackBrush, diamond4);
            g.DrawString("A", Cards, blackBrush, 575, 35);
            g.DrawString("A", Cards, blackBrush, 645, 155);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 300, 100, 150);
            g.FillRectangle(whiteBrush, 30, 300, 100, 150);
            g.FillPolygon(blackBrush, diamond5);
            g.DrawString("A", Cards, blackBrush, 35, 305);
            g.DrawString("A", Cards, blackBrush, 105, 425);

            g.DrawRectangle(drawPen, 210, 300, 100, 150);
            g.FillRectangle(whiteBrush, 210, 300, 100, 150);
            g.FillPolygon(blackBrush, diamond6);
            g.DrawString("A", Cards, blackBrush, 215, 305);
            g.DrawString("A", Cards, blackBrush, 285, 425);

            g.DrawRectangle(drawPen, 390, 300, 100, 150);
            g.FillRectangle(whiteBrush, 390, 300, 100, 150);
            g.FillPolygon(blackBrush, diamond7);
            g.DrawString("A", Cards, blackBrush, 395, 305);
            g.DrawString("A", Cards, blackBrush, 470, 425);

            g.DrawRectangle(drawPen, 570, 300, 100, 150);
            g.FillRectangle(whiteBrush, 570, 300, 100, 150);
            g.FillPolygon(blackBrush, diamond8);
            g.DrawString("A", Cards, blackBrush, 575, 305);
            g.DrawString("A", Cards, blackBrush, 650, 425);

            g.DrawString("Pick A Card, Any Card!", drawFont, whiteBrush, 220, 220);
            g.DrawString("You Have 5 Seconds to Decide!", drawFont, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            g.DrawRectangle(drawPen, 30, 30, 100, 150);
            g.FillRectangle(whiteBrush, 30, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 35);
            g.DrawString("A", Cards, blackBrush, 105, 155);

            g.DrawRectangle(drawPen, 210, 30, 100, 150);
            g.FillRectangle(whiteBrush, 210, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 35);
            g.DrawString("A", Cards, blackBrush, 285, 155);

            g.DrawRectangle(drawPen, 390, 30, 100, 150);
            g.FillRectangle(whiteBrush, 390, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 35);
            g.DrawString("A", Cards, blackBrush, 465, 155);

            g.DrawRectangle(drawPen, 570, 30, 100, 150);
            g.FillRectangle(whiteBrush, 570, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 35);
            g.DrawString("A", Cards, blackBrush, 645, 155);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 300, 100, 150);
            g.FillRectangle(whiteBrush, 30, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 305);
            g.DrawString("A", Cards, blackBrush, 105, 425);

            g.DrawRectangle(drawPen, 210, 300, 100, 150);
            g.FillRectangle(whiteBrush, 210, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 305);
            g.DrawString("A", Cards, blackBrush, 285, 425);

            g.DrawRectangle(drawPen, 390, 300, 100, 150);
            g.FillRectangle(whiteBrush, 390, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 305);
            g.DrawString("A", Cards, blackBrush, 470, 425);

            g.DrawRectangle(drawPen, 570, 300, 100, 150);
            g.FillRectangle(whiteBrush, 570, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 305);
            g.DrawString("A", Cards, blackBrush, 650, 425);

            g.DrawString("Pick A Card, Any Card!", drawFont, whiteBrush, 220, 220);
            g.DrawString("You Have 4 Seconds to Decide!", drawFont, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            g.DrawRectangle(drawPen, 30, 30, 100, 150);
            g.FillRectangle(whiteBrush, 30, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 35);
            g.DrawString("A", Cards, blackBrush, 105, 155);

            g.DrawRectangle(drawPen, 210, 30, 100, 150);
            g.FillRectangle(whiteBrush, 210, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 35);
            g.DrawString("A", Cards, blackBrush, 285, 155);

            g.DrawRectangle(drawPen, 390, 30, 100, 150);
            g.FillRectangle(whiteBrush, 390, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 35);
            g.DrawString("A", Cards, blackBrush, 465, 155);

            g.DrawRectangle(drawPen, 570, 30, 100, 150);
            g.FillRectangle(whiteBrush, 570, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 35);
            g.DrawString("A", Cards, blackBrush, 645, 155);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 300, 100, 150);
            g.FillRectangle(whiteBrush, 30, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 305);
            g.DrawString("A", Cards, blackBrush, 105, 425);

            g.DrawRectangle(drawPen, 210, 300, 100, 150);
            g.FillRectangle(whiteBrush, 210, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 305);
            g.DrawString("A", Cards, blackBrush, 285, 425);

            g.DrawRectangle(drawPen, 390, 300, 100, 150);
            g.FillRectangle(whiteBrush, 390, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 305);
            g.DrawString("A", Cards, blackBrush, 470, 425);

            g.DrawRectangle(drawPen, 570, 300, 100, 150);
            g.FillRectangle(whiteBrush, 570, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 305);
            g.DrawString("A", Cards, blackBrush, 650, 425);

            g.DrawString("Pick A Card, Any Card!", drawFont, whiteBrush, 220, 220);
            g.DrawString("You Have 3 Seconds to Decide!", drawFont, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            g.DrawRectangle(drawPen, 30, 30, 100, 150);
            g.FillRectangle(whiteBrush, 30, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 35);
            g.DrawString("A", Cards, blackBrush, 105, 155);

            g.DrawRectangle(drawPen, 210, 30, 100, 150);
            g.FillRectangle(whiteBrush, 210, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 35);
            g.DrawString("A", Cards, blackBrush, 285, 155);

            g.DrawRectangle(drawPen, 390, 30, 100, 150);
            g.FillRectangle(whiteBrush, 390, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 35);
            g.DrawString("A", Cards, blackBrush, 465, 155);

            g.DrawRectangle(drawPen, 570, 30, 100, 150);
            g.FillRectangle(whiteBrush, 570, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 35);
            g.DrawString("A", Cards, blackBrush, 645, 155);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 300, 100, 150);
            g.FillRectangle(whiteBrush, 30, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 305);
            g.DrawString("A", Cards, blackBrush, 105, 425);

            g.DrawRectangle(drawPen, 210, 300, 100, 150);
            g.FillRectangle(whiteBrush, 210, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 305);
            g.DrawString("A", Cards, blackBrush, 285, 425);

            g.DrawRectangle(drawPen, 390, 300, 100, 150);
            g.FillRectangle(whiteBrush, 390, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 305);
            g.DrawString("A", Cards, blackBrush, 470, 425);

            g.DrawRectangle(drawPen, 570, 300, 100, 150);
            g.FillRectangle(whiteBrush, 570, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 305);
            g.DrawString("A", Cards, blackBrush, 650, 425);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 30, 100, 150);
            g.FillRectangle(whiteBrush, 30, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 35);
            g.DrawString("A", Cards, blackBrush, 105, 155);

            g.DrawRectangle(drawPen, 210, 30, 100, 150);
            g.FillRectangle(whiteBrush, 210, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 35);
            g.DrawString("A", Cards, blackBrush, 285, 155);

            g.DrawRectangle(drawPen, 390, 30, 100, 150);
            g.FillRectangle(whiteBrush, 390, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 35);
            g.DrawString("A", Cards, blackBrush, 465, 155);

            g.DrawRectangle(drawPen, 570, 30, 100, 150);
            g.FillRectangle(whiteBrush, 570, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 35);
            g.DrawString("A", Cards, blackBrush, 645, 155);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 300, 100, 150);
            g.FillRectangle(whiteBrush, 30, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 305);
            g.DrawString("A", Cards, blackBrush, 105, 425);

            g.DrawRectangle(drawPen, 210, 300, 100, 150);
            g.FillRectangle(whiteBrush, 210, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 305);
            g.DrawString("A", Cards, blackBrush, 285, 425);

            g.DrawRectangle(drawPen, 390, 300, 100, 150);
            g.FillRectangle(whiteBrush, 390, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 305);
            g.DrawString("A", Cards, blackBrush, 470, 425);

            g.DrawRectangle(drawPen, 570, 300, 100, 150);
            g.FillRectangle(whiteBrush, 570, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 305);
            g.DrawString("A", Cards, blackBrush, 650, 425);

            g.DrawString("Pick A Card, Any Card!", drawFont, whiteBrush, 220, 220);
            g.DrawString("You Have 2 Seconds to Decide!", drawFont, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            g.DrawRectangle(drawPen, 30, 30, 100, 150);
            g.FillRectangle(whiteBrush, 30, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 35);
            g.DrawString("A", Cards, blackBrush, 105, 155);

            g.DrawRectangle(drawPen, 210, 30, 100, 150);
            g.FillRectangle(whiteBrush, 210, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 35);
            g.DrawString("A", Cards, blackBrush, 285, 155);

            g.DrawRectangle(drawPen, 390, 30, 100, 150);
            g.FillRectangle(whiteBrush, 390, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 35);
            g.DrawString("A", Cards, blackBrush, 465, 155);

            g.DrawRectangle(drawPen, 570, 30, 100, 150);
            g.FillRectangle(whiteBrush, 570, 30, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 35);
            g.DrawString("A", Cards, blackBrush, 645, 155);

            //Lower Cards

            g.DrawRectangle(drawPen, 30, 300, 100, 150);
            g.FillRectangle(whiteBrush, 30, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 35, 305);
            g.DrawString("A", Cards, blackBrush, 105, 425);

            g.DrawRectangle(drawPen, 210, 300, 100, 150);
            g.FillRectangle(whiteBrush, 210, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 215, 305);
            g.DrawString("A", Cards, blackBrush, 285, 425);

            g.DrawRectangle(drawPen, 390, 300, 100, 150);
            g.FillRectangle(whiteBrush, 390, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 395, 305);
            g.DrawString("A", Cards, blackBrush, 470, 425);

            g.DrawRectangle(drawPen, 570, 300, 100, 150);
            g.FillRectangle(whiteBrush, 570, 300, 100, 150);
            g.DrawString("A", Cards, blackBrush, 575, 305);
            g.DrawString("A", Cards, blackBrush, 650, 425);

            g.DrawString("Pick A Card, Any Card!", drawFont, whiteBrush, 220, 220);
            g.DrawString("You Have 1 Second to Decide!", drawFont, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            //This is the Big Card

            g.DrawRectangle(drawPen, 50, 50, 250, 375);
            g.FillRectangle(whiteBrush, 50, 50, 250, 375);
            g.DrawString("A", Large, blackBrush, 50, 50);
            g.DrawString("A", Large, blackBrush, 210, 325);


            g.DrawString("Was this Your Card?", Ariel, whiteBrush, 400, 230);

            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Visible = false;

            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 230);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 230);

            //button3.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Visible = false;

            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 230);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 230);

            //button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add "Awesome, I knew it."
            // And add a "Do you want to play again?" button

            //The Following is code for when you press one of the 'yes' buttons

            //button3.Visible = true;

            //g.DrawString("Play Again?", timesNewRoman, whiteBrush, 400, 230);
        }
    }
}
