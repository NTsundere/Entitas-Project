using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
    public class SetHeroDirectionByInputSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<GameEntity> _axisInputs;

        public SetHeroDirectionByInputSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero, 
                GameMatcher.MovementAvailable));
            _axisInputs = game.GetGroup(GameMatcher.Input);
        }
        
        public void Execute()
        {
            foreach (GameEntity input in _axisInputs)
            foreach (GameEntity hero in _heroes)
            {
                hero.isMoving = input.hasAxisInput;

                if (input.hasAxisInput)
                {
                    hero.ReplaceDirection(input.AxisInput.normalized);
                }
            }
        }
    }
}