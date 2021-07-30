
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
				Log.Info( "My Gamemode Has Created Serverside!" );
				new HillmonsHudEntity();
			}

			if ( IsClient )
			{
				Log.Info( "My Gamemode Has Created Clientside!" );
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
