using RimWorld;
using Verse;
using SR.MRA.Incident;
namespace SR.MRA.Permit
{
    public class RoyalTitlePermitWorker_CallFoodAid : RoyalTitlePermitWorker_CallResourceAidBase
    {
        /// <summary>
        /// 呼叫支援
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="faction"></param>
        /// <param name="map"></param>
        /// <param name="isFree"></param>
        protected override void CallAid(Pawn caller, Faction faction, Map map, bool isFree)
        {
            IncidentParms incidentParms = new IncidentParms();
            incidentParms.target = map;
            incidentParms.spawnCenter = caller.Position;
            incidentParms.pawnCount = def.royalAid.pawnCount;//征用这个参数做支援物品数量控制
            if (Incident.IncidentDefOf.CallFoodAid.Worker.TryExecute(incidentParms))
            {
                if (!isFree)
                {
                    caller.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
                }
                caller.royalty.Notify_PermitUsed(this.def);
                return;
            }
            Log.Error(string.Concat(new object[]
            {
                "Could not send aid to map ",
                map,
            }), false);
        }
        /// <summary>
        /// 获取皇家援助文本(免费)
        /// </summary>
        /// <returns></returns>
        protected override string GetCommandCallRoyalAidFreeOptionText()
        {
            return "SR_CommandCallRoyalFoodAidFreeOption".Translate();
        }
        /// <summary>
        /// 获取皇家援助文本(消耗声望)
        /// </summary>
        /// <returns></returns>
        protected override string GetCommandCallRoyalAidFavorOptionText(float ticksToDays, int favorCost, NamedArgument factionName)
        {
            return "SR_CommandCallRoyalFoodAidFavorOption".Translate(ticksToDays.ToString("0.0"), favorCost, factionName);
        }
    }
}
