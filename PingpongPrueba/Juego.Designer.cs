namespace PingpongPrueba
{
    partial class Juego
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
            this.Pelota = new System.Windows.Forms.PictureBox();
            this.Raqueta = new System.Windows.Forms.PictureBox();
            this.Playground = new System.Windows.Forms.Panel();
            this.Puntos_result = new System.Windows.Forms.Label();
            this.Puntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Juego_Finalizado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raqueta)).BeginInit();
            this.Playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pelota
            // 
            this.Pelota.BackColor = System.Drawing.Color.Red;
            this.Pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pelota.Location = new System.Drawing.Point(100, 100);
            this.Pelota.Name = "Pelota";
            this.Pelota.Size = new System.Drawing.Size(30, 30);
            this.Pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pelota.TabIndex = 0;
            this.Pelota.TabStop = false;
            // 
            // Raqueta
            // 
            this.Raqueta.BackColor = System.Drawing.Color.Black;
            this.Raqueta.Location = new System.Drawing.Point(284, 421);
            this.Raqueta.Name = "Raqueta";
            this.Raqueta.Size = new System.Drawing.Size(126, 17);
            this.Raqueta.TabIndex = 1;
            this.Raqueta.TabStop = false;
            // 
            // Playground
            // 
            this.Playground.Controls.Add(this.Juego_Finalizado);
            this.Playground.Controls.Add(this.Puntos_result);
            this.Playground.Controls.Add(this.Puntos);
            this.Playground.Location = new System.Drawing.Point(0, 0);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(741, 444);
            this.Playground.TabIndex = 2;
            this.Playground.Paint += new System.Windows.Forms.PaintEventHandler(this.Playground_Paint);
            // 
            // Puntos_result
            // 
            this.Puntos_result.AutoSize = true;
            this.Puntos_result.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos_result.Location = new System.Drawing.Point(109, 6);
            this.Puntos_result.Name = "Puntos_result";
            this.Puntos_result.Size = new System.Drawing.Size(28, 31);
            this.Puntos_result.TabIndex = 1;
            this.Puntos_result.Text = "0";
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.Location = new System.Drawing.Point(4, 4);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(104, 31);
            this.Puntos.TabIndex = 0;
            this.Puntos.Text = "Puntos:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Juego_Finalizado
            // 
            this.Juego_Finalizado.AutoSize = true;
            this.Juego_Finalizado.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Juego_Finalizado.Location = new System.Drawing.Point(255, 121);
            this.Juego_Finalizado.Name = "Juego_Finalizado";
            this.Juego_Finalizado.Size = new System.Drawing.Size(217, 155);
            this.Juego_Finalizado.TabIndex = 2;
            this.Juego_Finalizado.Text = "Juego Terminado\r\n\r\nF1 - Reinicar\r\n\r\nESC - Salir";
            this.Juego_Finalizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 444);
            this.Controls.Add(this.Raqueta);
            this.Controls.Add(this.Pelota);
            this.Controls.Add(this.Playground);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raqueta)).EndInit();
            this.Playground.ResumeLayout(false);
            this.Playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pelota;
        private System.Windows.Forms.PictureBox Raqueta;
        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Label Puntos_result;
        private System.Windows.Forms.Label Juego_Finalizado;
    }
}