using System;
using System.Collections.Generic;
using Verse;
using RimWorld;
namespace BTE_MMLA
{

	public class HediffCompProperties_ExplodeOnDeath : HediffCompProperties
	{

		public HediffCompProperties_ExplodeOnDeath()
		{
			this.compClass = typeof(HediffComp_ExplodeOnDeath);
		}


		public float radius = 5;
		public DamageDef damageType = null;

	}
}