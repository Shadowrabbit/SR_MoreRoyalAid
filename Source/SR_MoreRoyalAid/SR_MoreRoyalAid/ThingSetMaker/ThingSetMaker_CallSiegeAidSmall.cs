
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SR.MRA.ThingSetMaker
{
    public class ThingSetMaker_CallSiegeAidSmall : RimWorld.ThingSetMaker
    {
        protected override IEnumerable<ThingDef> AllGeneratableThingsDebugSub(ThingSetMakerParams parms)
        {
            yield break;
        }

        protected override void Generate(ThingSetMakerParams parms, List<Verse.Thing> outThings)
        {
            ThingDef thingDef = ThingDefOf.MealSurvivalPack;
            Verse.Thing thing = ThingMaker.MakeThing(thingDef, null);
            thing.stackCount = 5;
            outThings.Add(thing);
            ThingDef thingDef1 = ThingDefOf.MealSurvivalPack;
            Verse.Thing thing1 = ThingMaker.MakeThing(thingDef1, null);
            thing1.stackCount = 10;
            outThings.Add(thing1);
            ThingDef thingDef2 = Thing.ThingDefOf.Shell_Incendiary;
            Verse.Thing thing2 = ThingMaker.MakeThing(thingDef2, null);
            thing2.stackCount = 10;
            outThings.Add(thing2);
            ThingDef thingDef3 = ThingDefOf.Shell_HighExplosive;
            Verse.Thing thing3 = ThingMaker.MakeThing(thingDef3, null);
            thing3.stackCount = 6;
            outThings.Add(thing3);
            ThingDef thingDef4 = ThingDefOf.Cloth;
            Verse.Thing thing4 = ThingMaker.MakeThing(thingDef4, null);
            thing4.stackCount = 75;
            outThings.Add(thing4);
            ThingDef thingDef5 = ThingDefOf.Cloth;
            Verse.Thing thing5 = ThingMaker.MakeThing(thingDef5, null);
            thing5.stackCount = 75;
            outThings.Add(thing5);
            ThingDef thingDef6 = ThingDefOf.Steel;
            Verse.Thing thing6 = ThingMaker.MakeThing(thingDef6, null);
            thing6.stackCount = 75;
            outThings.Add(thing6);
            ThingDef thingDef7 = ThingDefOf.Steel;
            Verse.Thing thing7 = ThingMaker.MakeThing(thingDef7, null);
            thing7.stackCount = 75;
            outThings.Add(thing7);
            ThingDef thingDef8 = ThingDefOf.ComponentIndustrial;
            Verse.Thing thing8 = ThingMaker.MakeThing(thingDef8, null);
            thing8.stackCount = 4;
            outThings.Add(thing8);
        }
    }
}
