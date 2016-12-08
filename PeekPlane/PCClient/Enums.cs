using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient
{
	public enum PlaneStyle
	{
 		Up = 1,
		Right = 2,
		Down = 3,
		Left = 4
	}

	public enum BlockState
	{
 		Raw,
		Selected,
		BrokenWithoutTarget,
		BrokenWithTarget,
		Preview
	}
}
