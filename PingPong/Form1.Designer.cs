namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plansza = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.punkty_lbl = new System.Windows.Forms.Label();
            this.wynik_lbl = new System.Windows.Forms.Label();
            this.pilka = new System.Windows.Forms.PictureBox();
            this.paletka = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plansza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletka)).BeginInit();
            this.SuspendLayout();
            // 
            // plansza
            // 
            this.plansza.Controls.Add(this.gameover_lbl);
            this.plansza.Controls.Add(this.punkty_lbl);
            this.plansza.Controls.Add(this.wynik_lbl);
            this.plansza.Controls.Add(this.pilka);
            this.plansza.Controls.Add(this.paletka);
            this.plansza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plansza.Location = new System.Drawing.Point(0, 0);
            this.plansza.Name = "plansza";
            this.plansza.Size = new System.Drawing.Size(435, 299);
            this.plansza.TabIndex = 0;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("NeoSansStdBold", 24F, System.Drawing.FontStyle.Bold);
            this.gameover_lbl.Location = new System.Drawing.Point(81, 71);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(294, 156);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over\r\n\r\nF1 - Zrestartuj grę\r\nEsc - Wyjdź";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punkty_lbl
            // 
            this.punkty_lbl.AutoSize = true;
            this.punkty_lbl.Font = new System.Drawing.Font("NeoSansStdBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkty_lbl.Location = new System.Drawing.Point(139, 9);
            this.punkty_lbl.Name = "punkty_lbl";
            this.punkty_lbl.Size = new System.Drawing.Size(38, 39);
            this.punkty_lbl.TabIndex = 3;
            this.punkty_lbl.Text = "0";
            // 
            // wynik_lbl
            // 
            this.wynik_lbl.AutoSize = true;
            this.wynik_lbl.Font = new System.Drawing.Font("NeoSansStdBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wynik_lbl.Location = new System.Drawing.Point(12, 9);
            this.wynik_lbl.Name = "wynik_lbl";
            this.wynik_lbl.Size = new System.Drawing.Size(121, 39);
            this.wynik_lbl.TabIndex = 2;
            this.wynik_lbl.Text = "Wynik:";
            this.wynik_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.Black;
            this.pilka.Location = new System.Drawing.Point(30, 71);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(25, 25);
            this.pilka.TabIndex = 1;
            this.pilka.TabStop = false;
            // 
            // paletka
            // 
            this.paletka.BackColor = System.Drawing.Color.Maroon;
            this.paletka.Location = new System.Drawing.Point(136, 263);
            this.paletka.Name = "paletka";
            this.paletka.Size = new System.Drawing.Size(180, 15);
            this.paletka.TabIndex = 0;
            this.paletka.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.plansza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.plansza.ResumeLayout(false);
            this.plansza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plansza;
        private System.Windows.Forms.PictureBox pilka;
        private System.Windows.Forms.PictureBox paletka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label wynik_lbl;
        private System.Windows.Forms.Label punkty_lbl;
        private System.Windows.Forms.Label gameover_lbl;
    }
}

