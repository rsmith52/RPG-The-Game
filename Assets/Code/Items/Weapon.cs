using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Data/Items/Weapon", order = 2)]
public class Weapon : Holdable {

    public string weaponType; // Sword, Dagger, Hammer, etc
    public string weaponDamage; // How much damage it does

    protected override void onEquip () {
        // Add attack option
        // Show weapon
    }

    protected override void onUnequip () {
        // Remove attack option
        // Don't show weapon
    }
}
