using RimWorld;
using Verse;
using System;
using System.Collections.Generic;

namespace SR.MRA.Incident
{
    public class IncidentWorker_CallMedicineAid : IncidentWorker
    {
        protected override bool TryExecuteWorker(IncidentParms parms)
        {
            Map map = (Map)parms.target;
            ThingSetMakerParams thingSetMakerParams = new ThingSetMakerParams();
            int count = parms.pawnCount;
            List<Verse.Thing> things;//生成一批支援物资
            things = count == 10 ? ThingSetMaker.ThingSetMakerDefOf.CallMedicineAidSmall.root.Generate(thingSetMakerParams) : count == 20 ? ThingSetMaker.ThingSetMakerDefOf.CallMedicineAidLarge.root.Generate(thingSetMakerParams) : ThingSetMaker.ThingSetMakerDefOf.CallMedicineAidGrand.root.Generate(thingSetMakerParams);
            DropPodUtility.DropThingsNear(parms.spawnCenter, map, things, 110, false, false, false, false);//投放物资
            base.SendStandardLetter("SR_LetterLabelCallMedicineAid".Translate(), "SR_TextCallMedicineAid".Translate(), LetterDefOf.PositiveEvent, parms, new TargetInfo(parms.spawnCenter, map, false), Array.Empty<NamedArgument>());
            return true;
        }
    }
}
