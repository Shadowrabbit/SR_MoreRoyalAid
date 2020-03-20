using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SR.MRA.ThingSetMaker
{
    /// <summary>
    /// 用于按照某个规则生成一系列物品
    /// </summary>
    public class ThingSetMaker_CallFoodAidSmall : RimWorld.ThingSetMaker
    {
        /// <summary>
        /// 测试全部可生成的物品
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        protected override IEnumerable<ThingDef> AllGeneratableThingsDebugSub(ThingSetMakerParams parms)
        {
            yield break;
        }
        /// <summary>
        /// 生成方法
        /// </summary>
        /// <param name="parms"></param>
        /// <param name="outThings"></param>
        protected override void Generate(ThingSetMakerParams parms, List<Verse.Thing> outThings)
        {
            ThingDef thingDef = ThingDefOf.MealSimple;
            Verse.Thing thing = ThingMaker.MakeThing(thingDef, null);
            thing.stackCount = 10;
            outThings.Add(thing);
        }
    }
}
