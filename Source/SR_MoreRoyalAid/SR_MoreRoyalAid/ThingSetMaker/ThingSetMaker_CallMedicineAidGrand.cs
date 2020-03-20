using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SR.MRA.ThingSetMaker
{
    public class ThingSetMaker_CallMedicineAidGrand : RimWorld.ThingSetMaker
    {
        protected override IEnumerable<ThingDef> AllGeneratableThingsDebugSub(ThingSetMakerParams parms)
        {
            yield break;
        }
        protected override void Generate(ThingSetMakerParams parms, List<Verse.Thing> outThings)
        {
            ThingDef thingDef = ThingDefOf.MedicineUltratech;
            Verse.Thing thing = ThingMaker.MakeThing(thingDef, null);
            thing.stackCount = 30;
            outThings.Add(thing);
        }
    }
}
