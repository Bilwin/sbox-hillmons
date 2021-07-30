
using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Hillmons
{
	[Library( "hillmons" )]
	public partial class Hillmons : Sandbox.Game
	{
		public Hillmons()
		{
			if ( IsServer )
			{
				new HillmonsHudEntity();
			}
		}

		public override void ClientJoined( Client client )
		{
			base.ClientJoined(client);

			var player = new HillmonsPlayer();
			client.Pawn = player;

			player.Respawn();
		}
	}
}
