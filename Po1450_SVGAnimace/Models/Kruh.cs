using System.Drawing;

namespace Po1450_SVGAnimace.Models
{
	public class Kruh : Obrazec
	{
		public Kruh(TypTvaru typTvary, int pozX, int pozY, Color barva, int polomer) : base(typTvary, pozX, pozY, barva)
		{
			Polomer = polomer;
		}
		public int Polomer { get; }
	}
}
