namespace Classe_Aliante_Astratta
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.radioButtonFusoliera = new System.Windows.Forms.RadioButton();
			this.radioButtonAla = new System.Windows.Forms.RadioButton();
			this.radioButtonCoda = new System.Windows.Forms.RadioButton();
			this.radioButtonRuota = new System.Windows.Forms.RadioButton();
			this.buttonAggiungi = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.labelCrc = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.buttonRImuovi = new System.Windows.Forms.Button();
			this.buttonStampa = new System.Windows.Forms.Button();
			this.buttonPrice = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// radioButtonFusoliera
			// 
			this.radioButtonFusoliera.AutoSize = true;
			this.radioButtonFusoliera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonFusoliera.Location = new System.Drawing.Point(21, 113);
			this.radioButtonFusoliera.Name = "radioButtonFusoliera";
			this.radioButtonFusoliera.Size = new System.Drawing.Size(153, 36);
			this.radioButtonFusoliera.TabIndex = 0;
			this.radioButtonFusoliera.TabStop = true;
			this.radioButtonFusoliera.Text = "Fusoliera";
			this.radioButtonFusoliera.UseVisualStyleBackColor = true;
			this.radioButtonFusoliera.CheckedChanged += new System.EventHandler(this.radioButtonFusoliera_CheckedChanged);
			// 
			// radioButtonAla
			// 
			this.radioButtonAla.AutoSize = true;
			this.radioButtonAla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonAla.Location = new System.Drawing.Point(21, 155);
			this.radioButtonAla.Name = "radioButtonAla";
			this.radioButtonAla.Size = new System.Drawing.Size(77, 36);
			this.radioButtonAla.TabIndex = 1;
			this.radioButtonAla.TabStop = true;
			this.radioButtonAla.Text = "Ala";
			this.radioButtonAla.UseVisualStyleBackColor = true;
			this.radioButtonAla.CheckedChanged += new System.EventHandler(this.radioButtonAla_CheckedChanged);
			// 
			// radioButtonCoda
			// 
			this.radioButtonCoda.AutoSize = true;
			this.radioButtonCoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonCoda.Location = new System.Drawing.Point(21, 191);
			this.radioButtonCoda.Name = "radioButtonCoda";
			this.radioButtonCoda.Size = new System.Drawing.Size(103, 36);
			this.radioButtonCoda.TabIndex = 2;
			this.radioButtonCoda.TabStop = true;
			this.radioButtonCoda.Text = "Coda";
			this.radioButtonCoda.UseVisualStyleBackColor = true;
			this.radioButtonCoda.CheckedChanged += new System.EventHandler(this.radioButtonCoda_CheckedChanged);
			// 
			// radioButtonRuota
			// 
			this.radioButtonRuota.AutoSize = true;
			this.radioButtonRuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonRuota.Location = new System.Drawing.Point(21, 233);
			this.radioButtonRuota.Name = "radioButtonRuota";
			this.radioButtonRuota.Size = new System.Drawing.Size(111, 36);
			this.radioButtonRuota.TabIndex = 3;
			this.radioButtonRuota.TabStop = true;
			this.radioButtonRuota.Text = "Ruota";
			this.radioButtonRuota.UseVisualStyleBackColor = true;
			this.radioButtonRuota.CheckedChanged += new System.EventHandler(this.radioButtonRuota_CheckedChanged);
			// 
			// buttonAggiungi
			// 
			this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			this.buttonAggiungi.Location = new System.Drawing.Point(486, 412);
			this.buttonAggiungi.Name = "buttonAggiungi";
			this.buttonAggiungi.Size = new System.Drawing.Size(95, 35);
			this.buttonAggiungi.TabIndex = 4;
			this.buttonAggiungi.Text = "Aggiungi";
			this.buttonAggiungi.UseVisualStyleBackColor = true;
			this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(12, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(172, 54);
			this.labelTitle.TabIndex = 5;
			this.labelTitle.Text = "Aliante";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(481, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(655, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(837, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(481, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(655, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "label5";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(486, 126);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 11;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(660, 126);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 12;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(842, 126);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 13;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(486, 233);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 14;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(660, 233);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 15;
			// 
			// labelCrc
			// 
			this.labelCrc.AutoSize = true;
			this.labelCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCrc.Location = new System.Drawing.Point(481, 333);
			this.labelCrc.Name = "labelCrc";
			this.labelCrc.Size = new System.Drawing.Size(65, 25);
			this.labelCrc.TabIndex = 16;
			this.labelCrc.Text = "Cerca";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(486, 361);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 17;
			// 
			// buttonRImuovi
			// 
			this.buttonRImuovi.Location = new System.Drawing.Point(587, 412);
			this.buttonRImuovi.Name = "buttonRImuovi";
			this.buttonRImuovi.Size = new System.Drawing.Size(95, 35);
			this.buttonRImuovi.TabIndex = 18;
			this.buttonRImuovi.Text = "Rimuovi";
			this.buttonRImuovi.UseVisualStyleBackColor = true;
			this.buttonRImuovi.Click += new System.EventHandler(this.buttonRImuovi_Click);
			// 
			// buttonStampa
			// 
			this.buttonStampa.Location = new System.Drawing.Point(21, 320);
			this.buttonStampa.Name = "buttonStampa";
			this.buttonStampa.Size = new System.Drawing.Size(95, 34);
			this.buttonStampa.TabIndex = 19;
			this.buttonStampa.Text = "Stampa";
			this.buttonStampa.UseVisualStyleBackColor = true;
			this.buttonStampa.Click += new System.EventHandler(this.buttonStampa_Click);
			// 
			// buttonPrice
			// 
			this.buttonPrice.Location = new System.Drawing.Point(132, 320);
			this.buttonPrice.Name = "buttonPrice";
			this.buttonPrice.Size = new System.Drawing.Size(95, 35);
			this.buttonPrice.TabIndex = 20;
			this.buttonPrice.Text = "Prezzo";
			this.buttonPrice.UseVisualStyleBackColor = true;
			this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 644);
			this.Controls.Add(this.buttonPrice);
			this.Controls.Add(this.buttonStampa);
			this.Controls.Add(this.buttonRImuovi);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.labelCrc);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.buttonAggiungi);
			this.Controls.Add(this.radioButtonRuota);
			this.Controls.Add(this.radioButtonCoda);
			this.Controls.Add(this.radioButtonAla);
			this.Controls.Add(this.radioButtonFusoliera);
			this.Name = "Form1";
			this.Text = "1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonFusoliera;
		private System.Windows.Forms.RadioButton radioButtonAla;
		private System.Windows.Forms.RadioButton radioButtonCoda;
		private System.Windows.Forms.RadioButton radioButtonRuota;
		private System.Windows.Forms.Button buttonAggiungi;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label labelCrc;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button buttonRImuovi;
		private System.Windows.Forms.Button buttonStampa;
		private System.Windows.Forms.Button buttonPrice;
	}
}

