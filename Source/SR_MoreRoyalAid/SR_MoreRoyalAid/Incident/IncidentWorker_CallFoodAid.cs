using RimWorld;
using System;
using System.Collections.Generic;
using Verse;

namespace SR.MRA.Incident
{
    public class IncidentWorker_CallFoodAid:IncidentWorker
    {
        protected override bool TryExecuteWorker(IncidentParms parms)
        {
            Map map = (Map)parms.target;
            int count = parms.pawnCount;
            List<Verse.Thing> things;//生成一批支援物资
            if (count == 10)
            {
                things = ThingSetMaker.ThingSetMakerDefOf.callFoodAidSmall.root.Generate();
            }
            else if (count == 20)
            {
                things = ThingSetMaker.ThingSetMakerDefOf.callFoodAidLarge.root.Generate();
            }
            else
            {
                things = ThingSetMaker.ThingSetMakerDefOf.callFoodAidGrand.root.Generate();
            }
            DropPodUtility.DropThingsNear(parms.spawnCenter, map, things, 110, false, true, false, false);//投放物资
            base.SendStandardLetter("SR_LetterLabelCallFoodAid".Translate(), "SR_TextCallFoodAid".Translate(), LetterDefOf.PositiveEvent, parms, new TargetInfo(parms.spawnCenter, map, false), Array.Empty<NamedArgument>());
            return true;
        }
    }
}
