﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace BTE_MMLA
{
	public class Gene_HeavyHooves : Gene
	{

		public List<Hediff> LinkedHediff
		{
			get
			{
				List<Hediff> foundHd = new List<Hediff>();
				List<Hediff> hediffs = this.pawn.health.hediffSet.hediffs;
				for (int i = 0; i < hediffs.Count; i++)
				{


					if (hediffs[i].def == BTE_MMLA_HediffDefOf.BTEMa_HeavyHooves)
					{
						foundHd.Add(hediffs[i]);
					}
				}
				return foundHd;
			}
		}

		public override void PostAdd()
		{
			base.PostAdd();
			List<BodyPartRecord> hands = this.pawn.def.race.body.GetPartsWithDef(BodyPartDefOf.Leg);

			foreach (BodyPartRecord hd in hands)
			{
				if (!this.pawn.health.hediffSet.PartIsMissing(hd))
				{
					Hediff h = this.pawn.health.AddHediff(BTE_MMLA_HediffDefOf.BTEMa_HeavyHooves, hd, null, null);

				}
			}
		}

		public override void Tick()
		{
			base.Tick();
			ticksToRegrow--;
			if (ticksToRegrow <= 0)
			{
				ticksToRegrow = 60000;

				foreach (Hediff h in LinkedHediff)
				{
					this.pawn.health.RemoveHediff(h);
				}

				List<BodyPartRecord> feet = this.pawn.def.race.body.GetPartsWithDef(BodyPartDefOf.Leg);

				foreach (BodyPartRecord hd in feet)
				{
					if (!this.pawn.health.hediffSet.PartIsMissing(hd))
					{
						Hediff h = this.pawn.health.AddHediff(BTE_MMLA_HediffDefOf.BTEMa_HeavyHooves, hd, null, null);

					}
				}
			}
		}

		public override void PostRemove()
		{
			//		List<BodyPartRecord> hands = this.pawn.def.race.body.GetPartsWithDef(BodyPartDefOf.Hand);
			//
			//		foreach (BodyPartRecord hd in hands)
			//		{
			//			if (!this.pawn.health.hediffSet.PartIsMissing(hd))
			//			{
			//				this.pawn.health.RemoveHediff()
			//				this.pawn.health.AddHediff(BTE_MMLA_HediffDefOf.BTE_Ma_heavyHooves, hd, null, null);
			//			}
			//		}

			foreach (Hediff h in LinkedHediff)
			{
				this.pawn.health.RemoveHediff(h);
			}
			base.PostRemove();
		}

		public override void Reset()
		{
		}

		private int ticksToRegrow = 60000;

	}
}
