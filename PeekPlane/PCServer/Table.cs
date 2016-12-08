using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat
{
	public class Table
	{
		private Player player1;

		public Player Player1
		{
			get { return player1; }
			set { player1 = value; }
		}

		private Player player2;

		public Player Player2
		{
			get { return player2; }
			set { player2 = value; }
		}
	}
}
