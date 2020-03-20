using System.Collections.Generic;
using RimWorld;
using Verse;

using System;

namespace SR.MRA.Permit
{
    public abstract class RoyalTitlePermitWorker_CallResourceAidBase: RoyalTitlePermitWorker
    {
        /// <summary>
        /// 获取皇家支援选项
        /// </summary>
        /// <param name="map"></param>
        /// <param name="pawn"></param>
        /// <param name="faction"></param>
        /// <returns></returns>
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
                text += GetCommandCallRoyalAidFreeOptionText();
                action = delegate ()
                {
                    CallAid(pawn, faction, map, true);
                };
            }
            else
            {
                if (pawn.royalty.GetFavor(faction) >= this.def.royalAid.favorCost)
                {
                    action = delegate ()
                    {
                        CallAid(pawn, faction, map, true);
                    };
                }
                text += GetCommandCallRoyalAidFavorOptionText(numTicks.TicksToDays(), def.royalAid.favorCost,faction.Named("FACTION"));
 
            }
            yield return new FloatMenuOption(text, action, faction.def.FactionIcon, faction.Color, MenuOptionPriority.Default, null, null, 0f, null, null);
            yield break;
        }
        /// <summary>
        /// 呼叫支援
        /// </summary>
        /// <param name="map"></param>
        /// <param name="isFree"></param>
        protected abstract void CallAid(Pawn caller,Faction faction,Map map,bool isFree);
        /// <summary>
        /// 获取皇家援助文本(免费)
        /// </summary>
        /// <returns></returns>
        protected abstract string GetCommandCallRoyalAidFreeOptionText();
        /// <summary>
        /// 获取皇家援助文本(消耗声望)
        /// </summary>
        /// <returns></returns>
        protected abstract string GetCommandCallRoyalAidFavorOptionText(float ticksToDays, int favorCost, NamedArgument factionName);
    }
}
