using System.Collections.Generic;
using Code.Gameplay.Features.Abilities;
using Code.Gameplay.Features.Abilities.Configs;
using Code.Gameplay.Features.Enchants;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Configs;
using Code.Gameplay.Windows;
using Code.Gameplay.Windows.Configs;
using Code.Meta.Features.AfkGain.Configs;
using Code.Meta.UI.Shop.Items;
using UnityEngine;

namespace Code.Gameplay.StaticData
{
    public interface IStaticDataService
    {
        AfkGainConfig AfkGain { get; }
        void LoadAll();
        AbilityConfig GetAbilityConfig(AbilityId abilityId);
        LootConfig GetLootConfig(LootTypeId lootTypeId);
        AbilityLevel GetAbilityLevel(AbilityId abilityId, int level);
        EnchantConfig GetEnchantConfig(EnchantTypeId typeId);
        GameObject GetWindowPrefab(WindowId id);
        int MaxLevel();
        float ExperienceForLevel(int level);
    }
}