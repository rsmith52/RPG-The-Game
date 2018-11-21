using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

[CreateAssetMenu(fileName = "Weapon", menuName = "Data/Items/Weapon", order = 3)]
public class Weapon : Holdable {

    public WeaponType weaponType;
    public string weaponDamage; // How much damage it does
    public int weaponRange; // In tiles
    public AmmoType weaponAmmoType;

    protected override void onEquip () {
        // Add attack option
        // Show weapon
    }

    protected override void onUnequip () {
        // Remove attack option
        // Don't show weapon
    }
}
