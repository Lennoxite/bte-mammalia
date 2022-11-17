using RimWorld;
using Verse;

namespace BTE_MMLA
{
	[DefOf]
	public static class BTE_MMLA_ThingDefOf
	{
		static BTE_MMLA_ThingDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(BTE_MMLA_ThingDefOf));
		}

		public static ThingDef Milk;
		public static ThingDef WoolSheep;



	}

}