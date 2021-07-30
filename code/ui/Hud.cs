using Sandbox;
using Sandbox.UI;

namespace Hillmons
{
	public partial class HillmonsHudEntity : Sandbox.HudEntity<RootPanel>
	{
		public HillmonsHudEntity()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "ui/Hud.html" );
			}
		}
	}
}
