using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
namespace BTE_MMLA
{
	public class CompProperties_MilkableGene : CompProperties
	{
		public CompProperties_MilkableGene()
		{
			this.compClass = typeof(CompMilkableGene);
		}

		public bool milkFemaleOnly = true;
	}
}
