using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient
{
	public class Consts
	{
		public const int ROW_COUNT = 20;
		public const int COLUMN_COUNT = 20;
		public const int BLOCK_WIDTH = 20;
		public const int BLOCK_HEIGHT = 20;
		public const int BLOCK_COUNT = ROW_COUNT * COLUMN_COUNT;
		public const int PLANE_COUNT = 4;

		public static Color COLOR_VALID_SELECTION { get { return Color.LightBlue; } }
		public static Color COLOR_INVALID_SELECTION { get { return Color.Red; } }
	}
}
