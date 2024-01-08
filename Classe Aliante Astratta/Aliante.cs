using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Aliante_Astratta
{
	public class Aliante : Composite
	{
		private List<Composite> _componenti;

		public List<Composite> Composites
		{
			get { return _componenti; }
			set { _componenti = value; }
		}

		public Aliante()
		{
			Composites = new List<Composite>();
		}

		public Aliante(List<Composite> components)
		{
			Composites = components;
		}

		public Aliante(Aliante oldAliante)
		{
			Composites = oldAliante.Composites;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Aliante) || obj == null)
			{
				return false;
			}

			Aliante other = (Aliante)obj;
			if (Composites.Count != other.Composites.Count)
			{
				return false;
			}

			for (int i = 0; i < Composites.Count; i++)
			{
				if (!Composites[i].Equals(other.Composites[i]))
				{
					return false;
				}
			}

			return true;
		}

		public override void Aggiunta(Composite componente)
		{
			Composites.Add(componente);
		}

		public override void Rimuovi(int indice)
		{
			Composites.RemoveAt(indice);
		}

		public override Composite GetChild(int indice)
		{
			if (Composites.Count > indice)
			{
				return Composites[indice];
			}

			return null;
		}

		public override string ToString()
		{
			string str = "";

			foreach (var componente in Composites)
			{
				str += componente.ToString() + '\n';
			}

			return str;
		}

		public override double Prezzo()
		{
			double tot = 0;

			foreach (var componente in Composites)
			{
				tot += componente.Prezzo();
			}

			return tot;
		}
	}
}
