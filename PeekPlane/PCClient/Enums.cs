using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient
{
	public enum PlaneStyle
	{
 		NormalUp
	}

	public enum BlockState
	{
 		Raw,
		Selected,
		BrokenWithoutTarget,
		BrokenWithTarget
	}
}
