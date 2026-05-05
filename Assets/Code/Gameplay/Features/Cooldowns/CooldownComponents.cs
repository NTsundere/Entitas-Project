using Code.Gameplay.Features.Abilities;
using Entitas;

namespace Code.Gameplay.Features.Cooldowns
{
    [Game] public class Cooldown : IComponent { public float Value; }
    [Game] public class CooldownLeft : IComponent { public float Value; }
    [Game] public class CooldownUp : IComponent {  }
    
}