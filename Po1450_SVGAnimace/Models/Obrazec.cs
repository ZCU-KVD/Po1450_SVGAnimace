using System.Drawing;

namespace Po1450_SVGAnimace.Models
{
	public class Obrazec
	{
		public Obrazec(TypTvaru typTvary, int pozX, int pozY, Color barva)
		{
			TypTvary = typTvary;
			PozX = pozX;
			PozY = pozY;
			Barva = barva;
		}

		public TypTvaru TypTvary { get;  }
		public int PozX { get; private set; }
		public int PozY { get; private set; }
		public Color Barva { get; }
	}
}
