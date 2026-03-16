using HarmonyLib;
using MegaCrit.Sts2.Core.Odds;
using MegaCrit.Sts2.Core.Rooms;

namespace AllUnknownIs.Patches
{
    [HarmonyPatch(typeof(UnknownMapPointOdds), nameof(UnknownMapPointOdds.Roll))]
    public static class ForceShopInUnknownNodePatch
    {
        public static bool Prefix(ref RoomType __result)
        {
            __result = RoomType.Shop;

            return false;
        }
    }
}