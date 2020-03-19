using System.Collections.Generic;
using RimWorld;
using Verse;
using UnityEngine;
using System;

namespace SR.MRA
{
    public abstract class RoyalTitlePermitWorker_CallResourceAid: RoyalTitlePermitWorker
    {
        public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
        {
            if (faction.HostileTo(Faction.OfPlayer))
            {
                yield return new FloatMenuOption(this.def.LabelCap + ": " + "CommandCallRoyalAidFactionHostile".Translate(faction.Named("FACTION")), null, MenuOptionPriority.Default, null, null, 0f, null, null);
                yield break;
            }
            int permitLastUsedTick = pawn.royalty.GetPermitLastUsedTick(this.def);
            int num = Math.Max(GenTicks.TicksGame - permitLastUsedTick, 0);
            Action action = null;
            bool flag = permitLastUsedTick < 0 || num >= this.def.CooldownTicks;
            int numTicks = (permitLastUsedTick > 0) ? Math.Max(this.def.CooldownTicks - num, 0) : 0;
            string text = this.def.LabelCap + ": ";
            if (flag)
            {
                text += "CommandCallRoyalResourceAidFreeOption".Translate();
                action = delegate ()
                {
                    this.CallAid();
                };
            }
            else
            {
                if (pawn.royalty.GetFavor(faction) >= this.def.royalAid.favorCost)
                {
                    action = delegate ()
                    {
                        this.CallAid();
                    };
                }
                text += "CommandCallRoyalResourceAidFavorOption".Translate(numTicks.TicksToDays().ToString("0.0"), this.def.royalAid.favorCost, faction.Named("FACTION"));
            }
            yield return new FloatMenuOption(text, action, faction.def.FactionIcon, faction.Color, MenuOptionPriority.Default, null, null, 0f, null, null);
            yield break;
        }
        public virtual void CallAid() {

        }
    }
}
