namespace Sandbox.Tools
{
	[Library("tool_kickstick", Title = "Kick Stick", Description = "Kicking people", Group = "utility")]
	public partial class KickStick : BaseTool
	{
		public override void Simulate()
		{
			if (!Host.IsServer)
				return;

			using (Prediction.Off())
			{
				if (!Input.Pressed(InputButton.Attack1))
					return;

				var startPos = Owner.EyePos;
				var dir = Owner.EyeRot.Forward;

				var tr = Trace.Ray(startPos, startPos + dir * MaxTraceDistance)
					.Ignore(Owner)
					.HitLayer(CollisionLayer.Debris)
					.Run();

				if (!tr.Hit || !tr.Entity.IsValid())
					return;

				Log.Info(tr.Entity);
				bool isPlayer = tr.Entity is Player;
				if (!isPlayer)
					return;

				if (tr.Entity.IsWorld)
					return;

				var particle = Particles.Create("particles/physgun_freeze.vpcf");
				particle.SetPosition(0, tr.Entity.Position);
			}
		}
	}
}
