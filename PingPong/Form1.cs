using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form

    {

        public int speed_left = 4;  // szybkość poruszania się piłki
        public int speed_top = 4;   //
        public int wynik = 0;   //wynik w grze

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();  // ukrywa kursor

            this.FormBorderStyle = FormBorderStyle.None; // usuwa wszystkie obramowania
            this.TopMost = true;    //przenosi formularz do przodu
            this.Bounds = Screen.PrimaryScreen.Bounds;  //gra na cały ekran

            paletka.Top = plansza.Bottom - (plansza.Bottom / 10);   //ustalenie pozycji paletki

            gameover_lbl.Left = (plansza.Width / 2) - (gameover_lbl.Width / 2); //wyśrodkowanie
            gameover_lbl.Top = (plansza.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;   //ukrycie napisu podczas grania
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            paletka.Left = Cursor.Position.X - (paletka.Width / 2); //ustawienie kursora w centralnej części paletki

            pilka.Left += speed_left;   //poruszanie się piłki
            pilka.Top += speed_top;

            if (pilka.Bottom >= paletka.Top && pilka.Bottom <= paletka.Bottom && pilka.Left >= paletka.Left && pilka.Right <= paletka.Right)    //zmiana kolizji
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;     // zmienia kierunek
                wynik += 1;
                punkty_lbl.Text = wynik.ToString(); //dodanie 1 po każdym odbiciu

                Random r = new Random();
                plansza.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));   //zmiana koloru planszy na losowy
            }

            if (pilka.Left <= plansza.Left)
            {
                speed_left = -speed_left;
            }

            if (pilka.Right >= plansza.Right)
            {
                speed_left = -speed_left;
            }

            if (pilka.Top <= plansza.Top)
            {
                speed_top = -speed_top;
            }

            if (pilka.Bottom >= plansza.Bottom)
            {
                timer1.Enabled = false; //GAME OVER
                gameover_lbl.Visible = true; //pokazanie napisu GAME OVER po porażce
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();   // naciśnij Escape aby wyjść z gry
            }
            if (e.KeyCode == Keys.F1)   //ponowne załadowanie gry po porażce
            {
                pilka.Top = 50;
                pilka.Left = 50;
                speed_left = 4;
                speed_top = 4;
                wynik = 0;
                punkty_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
