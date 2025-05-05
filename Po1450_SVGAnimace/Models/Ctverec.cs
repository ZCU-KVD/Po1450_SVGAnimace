using System.Drawing;

namespace Po1450_SVGAnimace.Models
{
	public class Ctverec : Obrazec
	{
		public Ctverec(TypTvaru typTvary, int pozX, int pozY, Color barva, int stranaA) : base(typTvary, pozX, pozY, barva)
		{
			StranaA = stranaA;
		}
		public int StranaA { get; set; }
	}
}
