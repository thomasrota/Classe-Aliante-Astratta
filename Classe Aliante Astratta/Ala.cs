using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Astratta
{
	public class Ala : Composite
	{
		private double _lunghezza;
		private double _apertura;

		public double Lunghezza
		{
			get { return _lunghezza; }
			set
			{
				if (value >= 15F)
					_lunghezza = value;
				else
					_lunghezza = 15F;
			}
		}

		public double Apertura
		{
			get { return _apertura; }
			set
			{
				if (value * 2F >= Lunghezza)
					_apertura = value;
				else
					_apertura = Lunghezza * 2F;
			}
		}

		public Ala()
		{
			Lunghezza = 0F;
			Apertura = 0F;
		}

		public Ala(double lung, double aper)
		{
			Lunghezza = lung;
			Apertura = aper;
		}

		public Ala(Ala oldAla)
		{
			Lunghezza = oldAla.Lunghezza;
			Apertura = oldAla.Apertura;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Ala) || obj == null)
			{
				return false;
			}

			Ala other = (Ala)obj;
			return Lunghezza == other.Lunghezza && Apertura == other.Apertura;
		}

		public override void Aggiunta(Composite componente)
		{

		}

		public override void Rimuovi(int indice)
		{

		}

		public override Composite GetChild(int indice)
		{
			return null;
		}

		public override string ToString()
		{
			return $"Lunghezza ala: {Lunghezza}; Apertura ala: {Apertura}";
		}

		public override double Prezzo()
		{
			return Lunghezza * Apertura;
		}
	}
}
