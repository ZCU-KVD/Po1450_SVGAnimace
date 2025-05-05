using System.Drawing;

namespace Po1450_SVGAnimace.Models
{
	public class Obdelnik : Ctverec
	{
		public Obdelnik(TypTvaru typTvary, int pozX, int pozY, Color barva, int stranaA, int stranaB) : base(typTvary, pozX, pozY, barva, stranaA)
		{
			StranaB = stranaB;
		}
		public int StranaB { get;  }
	}
}
