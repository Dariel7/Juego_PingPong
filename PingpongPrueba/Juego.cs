using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingpongPrueba
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
            

        timer1.Enabled= true ;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            //this.Bounds = Screen.PrimaryScreen.Bounds;

            Raqueta.Top = Playground.Bottom - (Playground.Bottom / 15);

            Juego_Finalizado.Left = (Playground.Width / 2) - (Juego_Finalizado.Width / 2);
            Juego_Finalizado.Top = (Playground.Height / 2) - (Juego_Finalizado.Height / 2);
            Juego_Finalizado.Visible = false;
}

    int velocidad_left = 4;
        int velocidad = 4;
        int Puntosr = 0; // medir puntaje
       
         


        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } // Presionar ESC para salir

            if (e.KeyCode == Keys.F1)      //Precionar F1 para Reiniciar
            {
                Pelota.Top = 50;
                Pelota.Left = 50;
                velocidad_left = 4;
                velocidad = 4;
                Puntosr = 0;
                Puntos_result.Text = "0";
                timer1.Enabled = true;
                Juego_Finalizado.Visible = false;
                Playground.BackColor = Color.White;

            }
            
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Raqueta.Left = Cursor.Position.X - (Raqueta.Width / 2);

            Pelota.Left += velocidad_left;
            Pelota.Top += velocidad;

            if (Pelota.Bottom >= Raqueta.Top && Pelota.Bottom <= Raqueta.Bottom && Pelota.Left >= Raqueta.Left && Pelota.Right <= Raqueta.Right)
            {

                velocidad += 2;
                velocidad_left += 2;
                velocidad = -velocidad;
                Puntosr += 1;
                Puntos_result.Text = Puntosr.ToString();

                Random r = new Random();
                Playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150,255));


            }

            if (Pelota.Left <=Playground.Left)
            {
                velocidad_left = -velocidad_left;

            }

            if (Pelota.Right >= Playground.Right)
            {
                velocidad_left = -velocidad_left;
            }

            if (Pelota.Top <= Playground.Top)
            {
                velocidad = -velocidad;
            }

            if (Pelota.Bottom >= Playground.Bottom){
                timer1.Enabled = false;
                Juego_Finalizado.Visible = true;
            }
        }

        private void Playground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
