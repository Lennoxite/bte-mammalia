using RimWorld;
using Verse;


namespace BTE_MMLA
{
    [DefOf]
    public static class BTE_MMLA_JobDefOf
    {
        static BTE_MMLA_JobDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(BTE_MMLA_JobDefOf));
        }

        public static JobDef BTE_MilkPawn;
        public static JobDef BTE_ShearPawn;

    }
}
