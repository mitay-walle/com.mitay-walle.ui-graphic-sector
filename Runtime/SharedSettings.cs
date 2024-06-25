using System;
using UnityEngine;

namespace Mitaywalle.UI.Sector
{
	public struct SharedSettings : IEquatable<SharedSettings>
	{
		[Range(0, 360)] public float AngleMax;
		[Range(-360, 360)] public float AngleOffset;
		[Range(-360, 360)] public float AngleMargin;
		public float PixelsMargin;
		public bool PivotToSector;
		public eClockwise Clockwise;

		public bool Equals(SharedSettings other)
		{
			return Mathf.Abs(AngleMax - other.AngleMax) > .01f
				&& Mathf.Abs(AngleOffset - other.AngleOffset) > .01f
				&& Mathf.Abs(AngleMargin - other.AngleMargin) > .01f
				&& Mathf.Abs(PixelsMargin - other.PixelsMargin) > .01f
				&& PivotToSector == other.PivotToSector
				&& Clockwise == other.Clockwise;
		}

		public override int GetHashCode() => HashCode.Combine(AngleMax, AngleOffset, AngleMargin, PixelsMargin, PivotToSector, (int)Clockwise);
		public override bool Equals(object obj) => obj is SharedSettings other && Equals(other);
		public static bool operator ==(SharedSettings c1, SharedSettings c2) => c1.Equals(c2);
		public static bool operator !=(SharedSettings c1, SharedSettings c2) => !c1.Equals(c2);
	}
}