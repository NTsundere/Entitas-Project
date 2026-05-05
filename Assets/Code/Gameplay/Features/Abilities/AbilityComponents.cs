using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Code.Gameplay.Features.Abilities
{
    [Game] public class AbilityIdComponent : IComponent { public AbilityId Value; }
    [Game] public class ParentAbiltyComponent : IComponent {[EntityIndex] public AbilityId Value; }
    [Game] public class VegetableBoltAbility : IComponent { }
    [Game] public class OrbitinMushroomAbility : IComponent { }
    [Game] public class GarlicAuraAbility : IComponent { }
    
    [Game] public class UpgradeRequest : IComponent { }
    [Game] public class RecreatedOnUpgrade : IComponent { }

}