
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SR.MRA.ThingSetMaker
{
    public class ThingSetMaker_CallSiegeAidLarge : RimWorld.ThingSetMaker
    {
        protected override IEnumerable<ThingDef> AllGeneratableThingsDebugSub(ThingSetMakerParams parms)
        {
            yield break;
        }

        protected override void Generate(ThingSetMakerParams parms, List<Verse.Thing> outThings)
        {
            ThingDef thingDef = ThingDefOf.MealSurvivalPack;
            Verse.Thing thing = ThingMaker.MakeThing(thingDef, null);
            outThings.Add(thing);
            thing.stackCount = 10;
            ThingDef thingDef1 = ThingDefOf.MealSurvivalPack;
            Verse.Thing thing1 = ThingMaker.MakeThing(thingDef1, null);
            outThings.Add(thing1);
            thing1.stackCount = 10;
            ThingDef thingDef2 = ThingDefOf.MealSurvivalPack;
            Verse.Thing thing2 = ThingMaker.MakeThing(thingDef2, null);
            outThings.Add(thing2);
            thing2.stackCount = 10;
            ThingDef thingDef3 = Thing.ThingDefOf.Shell_Incendiary;
            Verse.Thing thing3 = ThingMaker.MakeThing(thingDef3, null);
            thing3.stackCount = 10;
            outThings.Add(thing3);
            ThingDef thingDef4 = ThingDefOf.Shell_HighExplosive;
            Verse.Thing thing4 = ThingMaker.MakeThing(thingDef4, null);
            thing4.stackCount = 6;
            outThings.Add(thing4);
            ThingDef thingDef5 = ThingDefOf.Shell_HighExplosive;
            Verse.Thing thing5 = ThingMaker.MakeThing(thingDef5, null);
            thing5.stackCount = 6;
            outThings.Add(thing5);
            ThingDef thingDef6 = ThingDefOf.Cloth;
            Verse.Thing thing6 = ThingMaker.MakeThing(thingDef6, null);
            thing6.stackCount = 75;
            outThings.Add(thing6);
            ThingDef thingDef7 = ThingDefOf.Cloth;
            Verse.Thing thing7 = ThingMaker.MakeThing(thingDef7, null);
            thing7.stackCount = 75;
            outThings.Add(thing7);
            ThingDef thingDef8 = ThingDefOf.Cloth;
            Verse.Thing thing8 = ThingMaker.MakeThing(thingDef8, null);
            thing8.stackCount = 50;
            outThings.Add(thing8);
            ThingDef thingDef9 = ThingDefOf.Steel;
            Verse.Thing thing9 = ThingMaker.MakeThing(thingDef9, null);
            thing9.stackCount = 75;
            outThings.Add(thing9);
            ThingDef thingDef10 = ThingDefOf.Steel;
            Verse.Thing thing10 = ThingMaker.MakeThing(thingDef10, null);
            thing10.stackCount = 75;
            outThings.Add(thing10);
            ThingDef thingDef11 = ThingDefOf.Steel;
            Verse.Thing thing11 = ThingMaker.MakeThing(thingDef11, null);
            thing11.stackCount = 75;
            outThings.Add(thing11);
            ThingDef thingDef12 = ThingDefOf.Steel;
            Verse.Thing thing12 = ThingMaker.MakeThing(thingDef12, null);
            thing12.stackCount = 75;
            outThings.Add(thing12);
            ThingDef thingDef13 = ThingDefOf.ComponentIndustrial;
            Verse.Thing thing13 = ThingMaker.MakeThing(thingDef13, null);
            thing13.stackCount = 8;
            outThings.Add(thing13);
        }
    }
}
