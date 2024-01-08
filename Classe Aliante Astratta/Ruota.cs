using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Astratta
{
	public class Ruota : Composite
	{
		private Gomma _gomma;
		private Cerchione _cerchione;

		public Gomma Gomma
		{
			get { return _gomma; }
			set { _gomma = value; }
		}

		public Cerchione Cerchione
		{
			get { return _cerchione; }
			set { _cerchione = value; }
		}

		public Ruota()
		{
			Gomma = new Gomma();
			Cerchione = new Cerchione();
		}

		public Ruota(Cerchione cerchione, Gomma gomma)
		{
			Cerchione = cerchione;
			Gomma = gomma;
		}

		public Ruota(Ruota oldRuota)
		{
			Gomma = oldRuota.Gomma;
			Cerchione = oldRuota.Cerchione;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Ruota) || obj == null)
			{
				return false;
			}

			Ruota other = (Ruota)obj;
			return Gomma == other.Gomma && Cerchione == other.Cerchione;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
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
			return $"Dettagli gomma: {Gomma}; Dettagli cerchioni: {Cerchione}";
		}

		public override double Prezzo()
		{
			return 0;
		}
	}
}
