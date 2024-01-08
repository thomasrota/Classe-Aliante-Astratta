using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Aliante_Astratta
{
	public partial class Form1 : Form
	{
		public Aliante aliante;
		public int n;
		public Form1()
		{
			InitializeComponent();
			aliante = new Aliante();
			n = 0;
		}

		private void radioButtonFusoliera_CheckedChanged(object sender, EventArgs e)
		{
			labelCrc.Hide();

			label3.Hide();
			label4.Hide();
			label5.Hide();

			textBox3.Hide();
			textBox4.Hide();
			textBox5.Hide();
			textBox6.Hide();

			textBox1.Show();
			label1.Show();

			textBox2.Show();
			label2.Show();

			label1.Text = "Lunghezza";
			label2.Text = "Materiale";
		}

		private void radioButtonAla_CheckedChanged(object sender, EventArgs e)
		{
			labelCrc.Hide();

			label3.Hide();
			label4.Hide();
			label5.Hide();

			textBox3.Hide();
			textBox4.Hide();
			textBox5.Hide();
			textBox6.Hide();

			textBox1.Show();
			label1.Show();

			textBox2.Show();
			label2.Show();

			label1.Text = "Lunghezza";
			label2.Text = "Apertura";
		}

		private void radioButtonCoda_CheckedChanged(object sender, EventArgs e)
		{
			labelCrc.Hide();

			label2.Hide();
			label3.Hide();
			label4.Hide();
			label5.Hide();

			textBox2.Hide();
			textBox3.Hide();
			textBox4.Hide();
			textBox5.Hide();
			textBox6.Hide();

			textBox1.Show();
			label1.Show();

			label1.Text = "Lunghezza";
		}

		private void radioButtonRuota_CheckedChanged(object sender, EventArgs e)
		{
			labelCrc.Show();

			label1.Text = "Pollici";
			label2.Text = "Materiale";

			label3.Text = "Altezza";
			label4.Text = "Larghezza";
			label5.Text = "Raggio";
		}

		private void buttonAggiungi_Click(object sender, EventArgs e)
		{
			if (!double.TryParse(textBox1.Text, out double t1) || t1 < 0 || textBox1.Text == "0" || String.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Inserire un valore valido.");
				return;
			}

			if (radioButtonFusoliera.Checked)
			{
				if (String.IsNullOrEmpty(textBox2.Text))
				{
					MessageBox.Show("Inserire un materiale valido.");
					return;
				}

				if (t1 < 75F)
				{
					MessageBox.Show("La lunghezza minima possibile è 75.");
					return;
				}

				Fusoliera fusoliera = new Fusoliera(t1, textBox2.Text);
				aliante.Aggiunta(fusoliera);

				return;
			}

			if (radioButtonAla.Checked)
			{
				if (t1 < 15F)
				{
					MessageBox.Show("La lunghezza minima possibile è 15.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!double.TryParse(textBox2.Text, out double t2) || t2 < 0 || textBox2.Text == "0" || String.IsNullOrEmpty(textBox2.Text))
				{
					MessageBox.Show("Inserire un valore valido.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (t2 * 2F < t1)
				{
					MessageBox.Show("L'apertura minima possibile equivale a due volte la lunghezza.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				Ala ala = new Ala(t1, t2);
				aliante.Aggiunta(ala);

				return;
			}

			if (radioButtonCoda.Checked)
			{
				if (t1 < 7F || t1 > 12F)
				{
					MessageBox.Show("7 <= lunghezza <= 12.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Coda coda = new Coda(t1);
				aliante.Aggiunta(coda);

				return;
			}

			if (radioButtonRuota.Checked)
			{
				if (t1 < 15F || t1 > 20F)
				{
					MessageBox.Show("La lunghezza in pollici deve essere compresa tra 15 e 20.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (String.IsNullOrEmpty(textBox2.Text))
				{
					MessageBox.Show("Materiale non valido.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!double.TryParse(textBox3.Text, out double t3) || t3 < 0 || textBox3.Text == "0" || String.IsNullOrEmpty(textBox3.Text))
				{
					MessageBox.Show("Inserire un'altezza valida.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (t3 < 200F || t3 > 400F)
				{
					MessageBox.Show("L'altezza deve essere compresa tra 200 e 400.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!double.TryParse(textBox4.Text, out double t4) || t4 < 0 || textBox4.Text == "0" || String.IsNullOrEmpty(textBox4.Text))
				{
					MessageBox.Show("Larghezza non valida.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (t4 < 200F || t4 > 400F)
				{
					MessageBox.Show("La larghezza deve essere compresa tra 300 e 400.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!double.TryParse(textBox5.Text, out double t5) || t5 < 0 || textBox5.Text == "0" || String.IsNullOrEmpty(textBox5.Text))
				{
					MessageBox.Show("Inserire un raggio valido.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (t5 < 40F || t5 > 60F)
				{
					MessageBox.Show("40 <= raggio <= 60.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Cerchione cerchione = new Cerchione(t1, textBox2.Text);
				Gomma gomma = new Gomma(t3, t4, t5);

				Ruota ruota = new Ruota(cerchione, gomma);

				aliante.Aggiunta(ruota);
			}
		}

		private void buttonRImuovi_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(textBox6.Text, out int index) || index < 0 || textBox6.Text == "0" || String.IsNullOrEmpty(textBox6.Text) || index - 1 > aliante.Composites.Count)
			{
				MessageBox.Show("Indice non valido!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			aliante.Rimuovi(index - 1);
		}

		private void buttonPrice_Click(object sender, EventArgs e)
		{
			if (aliante.Composites.Count < 1)
			{
				MessageBox.Show("Per ottenere i costi occorre inserire almeno un elemento.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show($"Il prezzo totale dei componenti è: {aliante.Prezzo()}");
		}

		private void buttonStampa_Click(object sender, EventArgs e)
		{
			if (aliante.Composites.Count < 1)
			{
				MessageBox.Show("Per effettuare la cancellazione occorre almeno un elemento.", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show(aliante.ToString());
		}
	}
}