using System.Drawing;

namespace Po1450_SVGAnimace.Pages
{
	public partial class SVG1
	{
		public SVG1()
		{
			SVGWidth = 1200;
			SVGHeight = 600;
			minRozmer = 10;
			maxRozmer = 70;
		}
		#region Vlastnosti
		private int SVGWidth { get; set; }
		private int SVGHeight { get; set; }
		
		private int minRozmer;
		private int maxRozmer;

		private Random rnd = new Random();
		private int TypTvaruCount => Enum.GetNames(typeof(Models.TypTvaru)).Length;
		private List<Models.Obrazec> SvgObrazceList { get; set; } = new List<Models.Obrazec>();
		#endregion

		#region Metody
		private void PridatObrazec()
		{
			Models.TypTvaru typTvary = (Models.TypTvaru)rnd.Next(0, TypTvaruCount);
			int stranaA = rnd.Next(minRozmer, maxRozmer);
			int stranaB = rnd.Next(minRozmer, maxRozmer);
			int pozX = rnd.Next(0, SVGWidth-stranaA/2);
			Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
			Models.Obrazec? obrazec = typTvary switch
			{
				Models.TypTvaru.Ctverec => new Models.Ctverec(typTvary, pozX, rnd.Next(0, SVGHeight - stranaA / 2), color, stranaA),
				Models.TypTvaru.Obdelnik => new Models.Obdelnik(typTvary, pozX, rnd.Next(0, SVGHeight - stranaB / 2), color, stranaA, stranaB),
				Models.TypTvaru.Kruh => new Models.Kruh(typTvary, pozX, rnd.Next(0, SVGHeight - stranaA / 2), color, polomer: stranaA / 2),
				_ => null
			};
			if (obrazec != null)
			{
				SvgObrazceList.Add(obrazec);
			}
		}
		#endregion
	}
}
