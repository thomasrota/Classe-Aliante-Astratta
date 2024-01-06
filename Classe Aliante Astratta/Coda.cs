using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Astratta
{
	public class Coda : Composite
	{
		private double _lunghezza;

		public double Lunghezza
		{
			get { return _lunghezza; }
			set
			{
				if (value >= 7F && value <= 12F)
					_lunghezza = value;
				else
					_lunghezza = 8F;
			}
		}

		public Coda()
		{
			Lunghezza = 0F;
		}

		public Coda(double lung)
		{
			Lunghezza = lung;
		}

		public Coda(Coda oldCoda)
		{
			Lunghezza = oldCoda.Lunghezza;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Coda) || obj == null)
			{
				return false;
			}

			Coda other = (Coda)obj;
			return Lunghezza == other.Lunghezza;
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
			return $"Lunghezza coda: {Lunghezza}";
		}

		public override double Prezzo()
		{
			return Lunghezza * 30;
		}
	}
}
