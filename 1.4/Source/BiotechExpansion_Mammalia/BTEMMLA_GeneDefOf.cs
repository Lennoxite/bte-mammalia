using RimWorld;
using Verse;


namespace BTE_MMLA
{
    [DefOf]
    public static class BTE_MMLA_GeneDefOf
    {
        static BTE_MMLA_GeneDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(BTE_MMLA_GeneDefOf));
        }

        public static GeneDef BTEMa_ExcessMilkProduction;

    }
}
