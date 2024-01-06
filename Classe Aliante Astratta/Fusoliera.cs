using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Astratta
{
	public class Fusoliera : Composite
	{
		private double _lunghezza;
		private string _materiale;

		public double Lunghezza
		{
			get { return _lunghezza; }
			set
			{
				if (value >= 75F)
					_lunghezza = value;
				else
					_lunghezza = 75F;
			}
		}

		public string Materiale
		{
			get { return _materiale; }
			set { _materiale = value; }
		}

		public Fusoliera()
		{
			Lunghezza = 0F;
			Materiale = string.Empty;
		}

		public Fusoliera(double _lunghezza, string materiale)
		{
			Lunghezza = _lunghezza;
			Materiale = materiale;
		}

		public Fusoliera(Fusoliera oldFusoliera)
		{
			Lunghezza = oldFusoliera.Lunghezza;
			Materiale = oldFusoliera.Materiale;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Fusoliera) || obj == null)
			{
				return false;
			}

			Fusoliera other = (Fusoliera)obj;
			return Lunghezza == other.Lunghezza && Materiale == other.Materiale;
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
			return $"Lunghezza fusoliera: {Lunghezza}; Materiale fusoliera: {Materiale}";
		}

		public override double Prezzo()
		{
			return Lunghezza * 30F;
		}
	}
}
