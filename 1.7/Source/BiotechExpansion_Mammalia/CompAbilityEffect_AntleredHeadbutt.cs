using System;
using Verse;
using RimWorld;
namespace BTE_MMLA
{

	public class CompAbilityEffect_AntleredHeadbutt : CompAbilityEffect
	{

		public new CompProperties_AbilityAntleredHeadbutt Props
		{
			get
			{
				return (CompProperties_AbilityAntleredHeadbutt)this.props;
			}
		}


		public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
		{
			base.Apply(target, dest);
            if (target.Thing is Pawn pawn)
            {
                pawn.stances.stunner.StunFor(8f.SecondsToTicks(), parent.pawn, addBattleLog: false);
            }
        }


		public override bool CanApplyOn(LocalTargetInfo target, LocalTargetInfo dest)
		{
			return this.Valid(target, false);
		}


		public override bool Valid(LocalTargetInfo target, bool throwMessages = false)
		{
			Pawn pawn = target.Pawn;
			if (pawn == null)
			{
				return false;
			}
			//if (!AbilityUtility.ValidateMustBeHumanOrWildMan(pawn, throwMessages, this.parent))
			//{
			//	return false;
			//}

			return true;
		}
		public override bool AICanTargetNow(LocalTargetInfo target)
		{
			return Valid(target, false);
		}
	}
}
