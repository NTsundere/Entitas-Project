using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
    public class CleanupCollected : ICleanupSystem
    {
        private const float CloseDistance = 0.2f;
        
        private readonly IGroup<GameEntity> _collected;
        private readonly IGroup<GameEntity> _heroes;

        public CleanupCollected(GameContext game)
        {
            _collected = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Collected));            
        }

        public void Cleanup()
        {
            foreach (GameEntity collected in _collected)
            {
                collected.isDestructed = true;
            }
        }
    }
}