using RimWorld;
using System;
using System.Collections.Generic;
using Verse;

namespace SR.MRA.Incident
{
    public class IncidentWorker_CallSiegeAid : IncidentWorker
    {
        protected override bool TryExecuteWorker(IncidentParms parms)
        {
            Map map = (Map)parms.target;
            int count = parms.pawnCount;
            List<Verse.Thing> things;//生成一批支援物资
            things = count == 10 ?ThingSetMaker.ThingSetMakerDefOf.CallSiegeAidSmall.root.Generate() : ThingSetMaker.ThingSetMakerDefOf.CallSiegeAidLarge.root.Generate();
            DropPodUtility.DropThingsNear(parms.spawnCenter, map, things, 110, false, false, false, false);//投放物资
            base.SendStandardLetter("SR_LetterLabelCallSiegeAid".Translate(), "SR_TextCallSiegeAid".Translate(), LetterDefOf.PositiveEvent, parms, new TargetInfo(parms.spawnCenter, map, false), Array.Empty<NamedArgument>());
            return true;
        }
    }
}
