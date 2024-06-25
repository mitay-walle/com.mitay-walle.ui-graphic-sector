using System;
using UnityEngine;

namespace Mitaywalle.UI.Sector
{
	[Serializable]
	public class SectorGradient
	{
		public static Gradient WHITE => new()
		{
			alphaKeys = new[] { new GradientAlphaKey(0, 255), },
			colorKeys = new[] { new GradientColorKey(Color.white, 0), }
		};
		public Gradient Gradient = WHITE;
		public eColorOperation Operation;
		public eFillMethod UV;
		public eXY RectDirection;

		public SectorGradient()
		{
			Gradient = WHITE;
		}

		public Color Apply(Color currentColor, UIVertex vertex, Rect rect, QuadRenderValues q, ArcRenderValues arc, Settings settings, int isOuterRadius, int isLastAngle)
		{
			int d = (int)RectDirection;

			Color color = UV switch
			{
				eFillMethod.Radius => Gradient.Evaluate(q.radius[isOuterRadius]),
				eFillMethod.Rect => Gradient.Evaluate((vertex.position[d] - rect.min[d]) / rect.size[d]),
				eFillMethod.Degree => Gradient.Evaluate(q.angles[isLastAngle] / settings.DegreesTotal),
				eFillMethod.DegreeSector => Gradient.Evaluate(q.uvGradient[isLastAngle]),
				_ => Color.white,
			};

			for (int i = 0; i < 4; i++)
			{
				switch (Operation)
				{
					case eColorOperation.Multiply:
						{
							currentColor[i] *= color[i];
							break;
						}
					case eColorOperation.Add:
						{
							currentColor[i] += color[i];
							break;
						}
					case eColorOperation.Override:
						{
							currentColor[i] = color[i];
							break;
						}
					case eColorOperation.Skip: { break; }
				}
			}
			//return isLastAngle == 1 ? Color.white : Color.black;
			return currentColor;
		}
	}
}