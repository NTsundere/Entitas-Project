using Code.Gameplay.Features.LevelUp.Systems;
using Code.Gameplay.Features.Loot.Systems;
using Code.Infrastructure.Systems;
using Entitas;

namespace Code.Gameplay.Features.Loot
{
    public class LootingFeature : Feature
    {
        public LootingFeature(ISystemFactory systems)
        {
            Add(systems.Create<CastForPullablesSystem>());
            
            Add(systems.Create<PullTowardsHeroSystem>());
            Add(systems.Create<CollectWhenNearSystem>());
            
            Add(systems.Create<CollectExperienceSystem>());
            Add(systems.Create<CollectEffectSystem>());
            Add(systems.Create<CollecStatusItemSystem>());
            
            Add(systems.Create<UpdateExperienceMeterSystem>());
            
            Add(systems.Create<CleanupCollected>());
        }
    }
}