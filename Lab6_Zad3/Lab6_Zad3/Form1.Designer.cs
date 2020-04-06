namespace Lab6_Zad3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPredkosc = new System.Windows.Forms.Label();
            this.lblPaliwo = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.btnGaz = new System.Windows.Forms.Button();
            this.btnHamulec = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.tbSpalanie = new System.Windows.Forms.TrackBar();
            this.lblSpalanie = new System.Windows.Forms.Label();
            this.lblSpalanie2 = new System.Windows.Forms.Label();
            this.lblWybierzSpalanie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpalanie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPredkosc
            // 
            this.lblPredkosc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPredkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPredkosc.Location = new System.Drawing.Point(12, 9);
            this.lblPredkosc.Name = "lblPredkosc";
            this.lblPredkosc.Size = new System.Drawing.Size(200, 60);
            this.lblPredkosc.TabIndex = 0;
            this.lblPredkosc.Text = "label1";
            this.lblPredkosc.Visible = false;
            this.lblPredkosc.Click += new System.EventHandler(this.lblPredkosc_Click);
            // 
            // lblPaliwo
            // 
            this.lblPaliwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaliwo.Location = new System.Drawing.Point(307, 9);
            this.lblPaliwo.Name = "lblPaliwo";
            this.lblPaliwo.Size = new System.Drawing.Size(120, 60);
            this.lblPaliwo.TabIndex = 1;
            this.lblPaliwo.Text = "label2";
            this.lblPaliwo.Visible = false;
            this.lblPaliwo.Click += new System.EventHandler(this.lblPaliwo_Click);
            // 
            // lblKm
            // 
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKm.Location = new System.Drawing.Point(588, 9);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(200, 60);
            this.lblKm.TabIndex = 2;
            this.lblKm.Text = "label3";
            this.lblKm.Visible = false;
            this.lblKm.Click += new System.EventHandler(this.lblKm_Click);
            // 
            // btnGaz
            // 
            this.btnGaz.BackColor = System.Drawing.Color.Lime;
            this.btnGaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGaz.Location = new System.Drawing.Point(588, 283);
            this.btnGaz.Name = "btnGaz";
            this.btnGaz.Size = new System.Drawing.Size(200, 125);
            this.btnGaz.TabIndex = 3;
            this.btnGaz.Text = "Gaz";
            this.btnGaz.UseVisualStyleBackColor = false;
            this.btnGaz.Visible = false;
            this.btnGaz.Click += new System.EventHandler(this.btnGaz_Click);
            // 
            // btnHamulec
            // 
            this.btnHamulec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHamulec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHamulec.Location = new System.Drawing.Point(15, 283);
            this.btnHamulec.Name = "btnHamulec";
            this.btnHamulec.Size = new System.Drawing.Size(200, 125);
            this.btnHamulec.TabIndex = 4;
            this.btnHamulec.Text = "Hamulec";
            this.btnHamulec.UseVisualStyleBackColor = false;
            this.btnHamulec.Visible = false;
            this.btnHamulec.Click += new System.EventHandler(this.btnHamulec_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRun.Location = new System.Drawing.Point(346, 340);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 68);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Jedź";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(346, 283);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 42);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbSpalanie
            // 
            this.tbSpalanie.LargeChange = 1;
            this.tbSpalanie.Location = new System.Drawing.Point(213, 232);
            this.tbSpalanie.Maximum = 15;
            this.tbSpalanie.Minimum = 5;
            this.tbSpalanie.Name = "tbSpalanie";
            this.tbSpalanie.Size = new System.Drawing.Size(374, 45);
            this.tbSpalanie.TabIndex = 7;
            this.tbSpalanie.Value = 5;
            this.tbSpalanie.Scroll += new System.EventHandler(this.tbSpalanie_Scroll);
            // 
            // lblSpalanie
            // 
            this.lblSpalanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpalanie.Location = new System.Drawing.Point(207, 150);
            this.lblSpalanie.Name = "lblSpalanie";
            this.lblSpalanie.Size = new System.Drawing.Size(394, 33);
            this.lblSpalanie.TabIndex = 8;
            this.lblSpalanie.Text = "Wybierz spalanie samochodu ";
            this.lblSpalanie.Click += new System.EventHandler(this.lblSpalanie_Click);
            // 
            // lblSpalanie2
            // 
            this.lblSpalanie2.AutoSize = true;
            this.lblSpalanie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpalanie2.Location = new System.Drawing.Point(283, 183);
            this.lblSpalanie2.Name = "lblSpalanie2";
            this.lblSpalanie2.Size = new System.Drawing.Size(0, 31);
            this.lblSpalanie2.TabIndex = 9;
            // 
            // lblWybierzSpalanie
            // 
            this.lblWybierzSpalanie.AutoSize = true;
            this.lblWybierzSpalanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWybierzSpalanie.Location = new System.Drawing.Point(305, 198);
            this.lblWybierzSpalanie.Name = "lblWybierzSpalanie";
            this.lblWybierzSpalanie.Size = new System.Drawing.Size(184, 31);
            this.lblWybierzSpalanie.TabIndex = 10;
            this.lblWybierzSpalanie.Text = "0L na 100KM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWybierzSpalanie);
            this.Controls.Add(this.lblSpalanie2);
            this.Controls.Add(this.lblSpalanie);
            this.Controls.Add(this.tbSpalanie);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnHamulec);
            this.Controls.Add(this.btnGaz);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblPaliwo);
            this.Controls.Add(this.lblPredkosc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSpalanie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPredkosc;
        private System.Windows.Forms.Label lblPaliwo;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Button btnGaz;
        private System.Windows.Forms.Button btnHamulec;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar tbSpalanie;
        private System.Windows.Forms.Label lblSpalanie;
        private System.Windows.Forms.Label lblSpalanie2;
        private System.Windows.Forms.Label lblWybierzSpalanie;
    }
}

