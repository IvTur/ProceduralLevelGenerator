﻿namespace GeneralAlgorithms.Algorithms.Polygons
{
	using System.Collections.Generic;
	using DataStructures.Common;
	using DataStructures.Polygons;

	/// <summary>
	/// Helper class for creating polygons.
	/// </summary>
	public class GridPolygonBuilder
	{
		private readonly List<IntVector2> points = new List<IntVector2>();

		/// <summary>
		/// Adds point to the polygon.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public GridPolygonBuilder AddPoint(int x, int y)
		{
			points.Add(new IntVector2(x, y));
			return this;
		}

		/// <summary>
		/// Builds the polygon from added points.
		/// </summary>
		/// <returns></returns>
		public GridPolygon Build()
		{
			return new GridPolygon(points);
		}
	}
}
