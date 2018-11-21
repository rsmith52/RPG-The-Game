using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor", menuName = "Data/Items/Armor", order = 1)]
public class Armor : Wearable {

    public string armorType; // Light, Medium, Heavy
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
