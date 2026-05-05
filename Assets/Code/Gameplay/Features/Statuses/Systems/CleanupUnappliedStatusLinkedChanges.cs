using System.Collections.Generic;
using Code.Common.Entity;
using Code.Gameplay.Features.CharacterStats;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems
{
    public class CleanupUnappliedStatusLinkedChanges : ICleanupSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _statuses;
        private List<GameEntity> _buffer = new(32); 

        public CleanupUnappliedStatusLinkedChanges(GameContext game)
        {
            _game = game;
            _statuses = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Id,
                    GameMatcher.Status,
                    GameMatcher.Unapplied));
        }
        
        public void Execute()
        {
            foreach (GameEntity status in _statuses.GetEntities(_buffer))
            {
                CreateEntity.Empty()
                    .AddStatChange(Stats.Speed)
                    .AddTargetId(status.TargetId)
                    .AddProducerId(status.ProducerId)
                    .AddEffectValue(status.EffectValue)
                    .AddApplierStatusLink(status.Id)
                    ;
                
                status.isApplied = true;
            }
        }

        public void Cleanup()
        {
            foreach (GameEntity status in _statuses.GetEntities(_buffer))
            foreach (GameEntity entity in _game.GetEntitiesWithApplierStatusLink(status.Id))
            {
                entity.isDestructed = true;
            }
        }
    }
}