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
            button.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void Background_Load(object sender, EventArgs e)
        {

        }

        private void Background_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);

            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redbrush = new SolidBrush(Color.Red);
            SolidBrush greenbrush = new SolidBrush(Color.Green);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            Font timesNewRoman = new Font("TimesNewRoman", 16, FontStyle.Bold);
            Font Large = new Font("TimesNewRoman", 64, FontStyle.Bold);
            Font Ariel = new Font("Ariel", 16, FontStyle.Bold);
            Font Cards = new Font("Comfortaa", 16, FontStyle.Bold);

            //For diamonds

            Point[] diamond1 = new Point[4];
            diamond1[0] = new Point(70, 90);
            diamond1[1] = new Point(90, 110);
            diamond1[2] = new Point(70, 130);
            diamond1[3] = new Point(50, 110);

            Point[] diamond2 = new Point[4];
            diamond2[0] = new Point(260, 90);
            diamond2[1] = new Point(280, 110);
            diamond2[2] = new Point(260, 130);
            diamond2[3] = new Point(240, 110);

            Point[] diamond3 = new Point[4];
            diamond3[0] = new Point(440, 90);
            diamond3[1] = new Point(460, 110);
            diamond3[2] = new Point(440, 130);
            diamond3[3] = new Point(420, 110);

            Point[] diamond4 = new Point[4];
            diamond4[0] = new Point(620, 90);
            diamond4[1] = new Point(640, 110);
            diamond4[2] = new Point(620, 130);
            diamond4[3] = new Point(600, 110);

            //Lower Half

            Point[] diamond5 = new Point[4];
            diamond5[0] = new Point(70, 360);
            diamond5[1] = new Point(90, 380);
            diamond5[2] = new Point(70, 400);
            diamond5[3] = new Point(50, 380);

            Point[] diamond6 = new Point[4];
            diamond6[0] = new Point(260, 360);
            diamond6[1] = new Point(280, 380);
            diamond6[2] = new Point(260, 400);
            diamond6[3] = new Point(240, 380);

            Point[] diamond7 = new Point[4];
            diamond7[0] = new Point(440, 360);
            diamond7[1] = new Point(460, 380);
            diamond7[2] = new Point(440, 400);
            diamond7[3] = new Point(420, 380);

            Point[] diamond8 = new Point[4];
            diamond8[0] = new Point(620, 360);
            diamond8[1] = new Point(640, 380);
            diamond8[2] = new Point(620, 400);
            diamond8[3] = new Point(600, 380);


            Point[] diamond9 = new Point[4];
            diamond9[0] = new Point(175, 176);
            diamond9[1] = new Point(235, 238);
            diamond9[2] = new Point(175, 298);
            diamond9[3] = new Point(115, 238);

            g.Clear(Color.Red);

            SoundPlayer player = new SoundPlayer(Properties.Resources.BellSound);
            player.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 5 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player1 = new SoundPlayer(Properties.Resources.BellSound);
            player1.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 4 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.BellSound);
            player2.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 3 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player3 = new SoundPlayer(Properties.Resources.BellSound);
            player3.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 2 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player4 = new SoundPlayer(Properties.Resources.BellSound);
            player4.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 1 Second to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);

            SoundPlayer player5 = new SoundPlayer(Properties.Resources.DingSound);
            player5.Play();

            button.Visible = true;
            button2.Visible = true;
            button.Refresh();
            button2.Refresh();

            g.Clear(Color.Red);

            //This is the Big Card

            g.DrawRectangle(drawPen, 50, 50, 250, 375);
            g.FillRectangle(whiteBrush, 50, 50, 250, 375);
            g.FillPolygon(blackBrush, diamond9);
            g.DrawString("A", Large, blackBrush, 50, 50);
            g.DrawString("A", Large, blackBrush, 210, 325);


            g.DrawString("Was this Your Card?", Ariel, whiteBrush, 400, 230);

            
            Thread.Sleep(10000);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            button.Visible = false;
            button2.Visible = false;

            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 330);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 350);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 320);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 340);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 310);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 330);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 300);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 320);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 290);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 310);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 280);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 300);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 270);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 290);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 260);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 280);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 250);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 270);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 240);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 260);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 230);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 250);

            button3.Visible = true;
            Thread.Sleep(7500);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button.Visible = false;
            button2.Visible = false;

            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 330);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 350);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 320);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 340);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 310);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 330);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 300);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 320);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 290);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 310);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 280);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 300);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 270);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 290);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 260);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 280);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 250);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 270);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 240);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 260);

            Thread.Sleep(25);
            g.Clear(Color.Black);

            g.DrawString("Awesome. I knew it.", drawFont, whiteBrush, 400, 230);
            g.DrawString("Play Again?", drawFont, whiteBrush, 400, 250);

            button3.Visible = true;
            Thread.Sleep(7500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);

            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redbrush = new SolidBrush(Color.Red);
            SolidBrush greenbrush = new SolidBrush(Color.Green);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            Font timesNewRoman = new Font("TimesNewRoman", 16, FontStyle.Bold);
            Font Large = new Font("TimesNewRoman", 64, FontStyle.Bold);
            Font Ariel = new Font("Ariel", 16, FontStyle.Bold);
            Font Cards = new Font("Comfortaa", 16, FontStyle.Bold);

            //For diamonds

            Point[] diamond1 = new Point[4];
            diamond1[0] = new Point(70, 90);
            diamond1[1] = new Point(90, 110);
            diamond1[2] = new Point(70, 130);
            diamond1[3] = new Point(50, 110);

            Point[] diamond2 = new Point[4];
            diamond2[0] = new Point(260, 90);
            diamond2[1] = new Point(280, 110);
            diamond2[2] = new Point(260, 130);
            diamond2[3] = new Point(240, 110);

            Point[] diamond3 = new Point[4];
            diamond3[0] = new Point(440, 90);
            diamond3[1] = new Point(460, 110);
            diamond3[2] = new Point(440, 130);
            diamond3[3] = new Point(420, 110);

            Point[] diamond4 = new Point[4];
            diamond4[0] = new Point(620, 90);
            diamond4[1] = new Point(640, 110);
            diamond4[2] = new Point(620, 130);
            diamond4[3] = new Point(600, 110);

            //Lower Half

            Point[] diamond5 = new Point[4];
            diamond5[0] = new Point(70, 360);
            diamond5[1] = new Point(90, 380);
            diamond5[2] = new Point(70, 400);
            diamond5[3] = new Point(50, 380);

            Point[] diamond6 = new Point[4];
            diamond6[0] = new Point(260, 360);
            diamond6[1] = new Point(280, 380);
            diamond6[2] = new Point(260, 400);
            diamond6[3] = new Point(240, 380);

            Point[] diamond7 = new Point[4];
            diamond7[0] = new Point(440, 360);
            diamond7[1] = new Point(460, 380);
            diamond7[2] = new Point(440, 400);
            diamond7[3] = new Point(420, 380);

            Point[] diamond8 = new Point[4];
            diamond8[0] = new Point(620, 360);
            diamond8[1] = new Point(640, 380);
            diamond8[2] = new Point(620, 400);
            diamond8[3] = new Point(600, 380);


            Point[] diamond9 = new Point[4];
            diamond9[0] = new Point(175, 176);
            diamond9[1] = new Point(235, 238);
            diamond9[2] = new Point(175, 298);
            diamond9[3] = new Point(115, 238);

            g.Clear(Color.Red);

            SoundPlayer player = new SoundPlayer(Properties.Resources.BellSound);
            player.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 5 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player1 = new SoundPlayer(Properties.Resources.BellSound);
            player1.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 4 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.BellSound);
            player2.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 3 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player3 = new SoundPlayer(Properties.Resources.BellSound);
            player3.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 2 Seconds to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);
            g.Clear(Color.Red);

            SoundPlayer player4 = new SoundPlayer(Properties.Resources.BellSound);
            player4.Play();

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

            g.DrawString("Pick A Card, Any Card!", timesNewRoman, whiteBrush, 220, 220);
            g.DrawString("You Have 1 Second to Decide!", timesNewRoman, whiteBrush, 200, 240);

            Thread.Sleep(1000);

            SoundPlayer player5 = new SoundPlayer(Properties.Resources.DingSound);
            player5.Play();

            button.Visible = true;
            button2.Visible = true;
            button.Refresh();
            button2.Refresh();

            g.Clear(Color.Red);

            //This is the Big Card

            g.DrawRectangle(drawPen, 50, 50, 250, 375);
            g.FillRectangle(whiteBrush, 50, 50, 250, 375);
            g.FillPolygon(blackBrush, diamond9);
            g.DrawString("A", Large, blackBrush, 50, 50);
            g.DrawString("A", Large, blackBrush, 210, 325);


            g.DrawString("Was this Your Card?", Ariel, whiteBrush, 400, 230);


            Thread.Sleep(10000);
        }
    }
}
