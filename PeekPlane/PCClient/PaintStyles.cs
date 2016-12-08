using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient
{
	internal class PaintStyles
	{
		public static List<Point> GetStyle(PlaneStyle p)
		{
			List<Point> styleResult = new List<Point>();
			switch (p)
			{
				case PlaneStyle.Up:
					{
						styleResult.Add(new Point(0, 0));
						styleResult.Add(new Point(-1, 0));
						styleResult.Add(new Point(-2, 0));
						styleResult.Add(new Point(1, 0));
						styleResult.Add(new Point(2, 0));
						styleResult.Add(new Point(0, -1));
						styleResult.Add(new Point(0, 1));
						styleResult.Add(new Point(0, 2));
						styleResult.Add(new Point(0, 3));
						styleResult.Add(new Point(-1, 3));
						styleResult.Add(new Point(1, 3));
						break;
					}
				case PlaneStyle.Right:
					{
						styleResult.Add(new Point(0, 0));
						styleResult.Add(new Point(1, 0));
						styleResult.Add(new Point(-1, 0));
						styleResult.Add(new Point(-2, 0));
						styleResult.Add(new Point(-3, 0));
						styleResult.Add(new Point(0, 1));
						styleResult.Add(new Point(0, 2));
						styleResult.Add(new Point(0, -1));
						styleResult.Add(new Point(0, -2));
						styleResult.Add(new Point(-3, 1));
						styleResult.Add(new Point(-3, -1));
						break;
					}
				case PlaneStyle.Down:
					{
						styleResult.Add(new Point(0, 0));
						styleResult.Add(new Point(0, -1));
						styleResult.Add(new Point(0, 1));
						styleResult.Add(new Point(0, -2));
						styleResult.Add(new Point(0, -3));
						styleResult.Add(new Point(-1, -3));
						styleResult.Add(new Point(1, -3));
						styleResult.Add(new Point(-1, 0));
						styleResult.Add(new Point(-2, 0));
						styleResult.Add(new Point(1, 0));
						styleResult.Add(new Point(2, 0));
						break;
					}
				case PlaneStyle.Left:
					{
						styleResult.Add(new Point(0, 0));
						styleResult.Add(new Point(-1, 0));
						styleResult.Add(new Point(1, 0));
						styleResult.Add(new Point(2, 0));
						styleResult.Add(new Point(3, 0));
						styleResult.Add(new Point(0, 1));
						styleResult.Add(new Point(0, 2));
						styleResult.Add(new Point(0, -1));
						styleResult.Add(new Point(0, -2));
						styleResult.Add(new Point(3, 1));
						styleResult.Add(new Point(3, -1));
						break;
					}
			}
			return styleResult;
		}
	}
}
