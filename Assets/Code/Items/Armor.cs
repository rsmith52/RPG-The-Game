using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

[CreateAssetMenu(fileName = "Armor", menuName = "Data/Items/Armor", order = 2)]
public class Armor : Wearable {

    public ArmorType armorType;
    public int armorMod; // How much protection it adds

    protected override void onEquip () {
        // Add armor mod + any effects
        // Show armor
    }

    protected override void onUnequip () {
        // Remove armor mod + any effects
        // Don't show armor
    }
}
