using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SR.MRA.ThingSetMaker
{
    public class ThingSetMaker_CallMedicineAidSmall : RimWorld.ThingSetMaker
    {
        protected override IEnumerable<ThingDef> AllGeneratableThingsDebugSub(ThingSetMakerParams parms)
        {
            yield break;
        }
        protected override void Generate(ThingSetMakerParams parms, List<Verse.Thing> outThings)
        {
            ThingDef thingDef = ThingDefOf.MedicineHerbal;
            Verse.Thing thing = ThingMaker.MakeThing(thingDef, null);
            thing.stackCount = 10;
            outThings.Add(thing);
        }
    }
}
