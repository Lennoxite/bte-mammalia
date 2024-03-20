using System;
using RimWorld;
using Verse;
namespace BTE_MMLA
{
	public class HediffComp_ExplodeOnDeath : HediffComp
	{
		public HediffCompProperties_ExplodeOnDeath Props
		{
			get
			{
				return (HediffCompProperties_ExplodeOnDeath)this.props;
			}
		}

		public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
		{
			Corpse owner = this.parent.pawn.Corpse;
			if (Props.damageType == null)
				Props.damageType = DamageDefOf.Flame;
			if (owner != null)
				GenExplosion.DoExplosion(owner.Position, owner.Map, Props.radius, Props.damageType, owner.InnerPawn, -1, -1f, null, null, null, null, null, 0f, 1, null, false, null, 0f, 1, 0f, false, null, null, null, true, 1f, 0f, true, null, 1f);
		}

	}
}