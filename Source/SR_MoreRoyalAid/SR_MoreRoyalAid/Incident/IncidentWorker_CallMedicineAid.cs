﻿using RimWorld;
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
            if (count==10)
            {
                things = ThingSetMaker.ThingSetMakerDefOf.callMedicineAidSmall.root.Generate(thingSetMakerParams);
            }
            else if (count==20)
            {
                things = ThingSetMaker.ThingSetMakerDefOf.callMedicineAidLarge.root.Generate(thingSetMakerParams);
            }
            else
            {
                things = ThingSetMaker.ThingSetMakerDefOf.callMedicineAidGrand.root.Generate(thingSetMakerParams);
            }
            IntVec3 intVec = DropCellFinder.TradeDropSpot(map);//将支援物资投放坐标定在交易处
            DropPodUtility.DropThingsNear(intVec, map, things, 110, false, true, true, false);//投放物资
            base.SendStandardLetter("SR_LetterLabelCallMedicineAid".Translate(), "SR_TextCallMedicineAid".Translate(), LetterDefOf.PositiveEvent, parms, new TargetInfo(intVec, map, false), Array.Empty<NamedArgument>());
            return true;
        }
    }
}
