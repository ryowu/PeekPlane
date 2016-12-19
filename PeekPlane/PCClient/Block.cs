using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
	public partial class Block : UserControl
	{
		public Block()
		{
			InitializeComponent();
		}

		private Point pos;

		public Point Pos
		{
			get { return pos; }
			set { pos = value; }
		}

		private BlockState state = BlockState.Raw;

		public BlockState State
		{
			get { return state; }
			set { state = value; }
		}

		private int parentIndex = 0;

		public int ParentIndex
		{
			get { return parentIndex; }
			set { parentIndex = value; }
		}
	}
}
