using Sandbox.UI;

namespace Alium.Hillmons
{
	public partial class HillmonsHudEntity : Sandbox.HudEntity<RootPanel>
	{
		public HillmonsHudEntity()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "/Hud.html" );
			}
		}
	}

}
