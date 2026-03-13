using Godot;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Unlocks;
using WatcherMod.Relics;

namespace WatcherMod.Models.RelicPools;

public sealed class WatcherRelicPool : RelicPoolModel
{
    public override string EnergyColorName => "watcher";

    public override Color LabOutlineColor => StsColors.purple;

    protected override IEnumerable<RelicModel> GenerateAllRelics()
    {
        return
        [
            ModelDb.Relic<PureWater>(),
            ModelDb.Relic<Damaru>(),
            ModelDb.Relic<Duality>(),
            ModelDb.Relic<TeardropLocket>(),
            ModelDb.Relic<GoldenEye>(),
            ModelDb.Relic<HolyWater>(),
            ModelDb.Relic<VioletLotus>(),
            ModelDb.Relic<Melange>()
        ];
    }

    public override IEnumerable<RelicModel> GetUnlockedRelics(UnlockState unlockState)
    {
        var list = AllRelics.ToList();
        return list;
    }
}