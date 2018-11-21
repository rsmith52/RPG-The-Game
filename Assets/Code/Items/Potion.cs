using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

[CreateAssetMenu(fileName = "Potion", menuName = "Data/Items/Potion", order = 1)]
public class Potion : Consumable {

    public PotionCategory potionCategory;
    public string effectCode; // string of characters that defines what this potion does

    protected override bool onUse(GameObject target) {
        // Gain health, apply poison, etc
        return true; // if successfully used
    }
}
