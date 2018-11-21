using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGNamespace {

    /// <summary>
    /// Item Category Enums
    /// </summary>
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        VeryRare,
        Legendary
    };
    public enum ArmorType
    {
        Light,
        Medium,
        Heavy
    }
    public enum UsageTarget
    {
        SelfOnly,
        AnyParty,
        Weapon,
        Any
    };
    public enum PotionCategory
    {
        Healing,
        Poison,
        Resistance
    };
    public enum WeaponType
    {
        Dagger,
        Sword,
        Hammer,
        Bow,
        Mace
    };
    public enum BodyPart
    {
        Head,
        Body,
        Legs,
        Feet,
        Finger,
        Neck
    };
    public enum AmmoType
    {
        None,
        Arrow,
        Bolt,
        Stone
    };
}
