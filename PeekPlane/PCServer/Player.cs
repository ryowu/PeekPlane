using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat
{
	public class Player
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string connectionId;

		public string ConnectionId
		{
			get { return connectionId; }
			set { connectionId = value; }
		}

		private bool syncedMap = false;

		public bool SyncedMap
		{
			get { return syncedMap; }
			set { syncedMap = value; }
		}
	}
}
