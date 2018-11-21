using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

[CreateAssetMenu(fileName = "Ammo", menuName = "Data/Items/Ammo", order = 4)]
public class Ammo : Equipment {

    public AmmoType ammoType;
    public int ammoDamage;

    protected override void onEquip()
    {
        // only if correct weapon type is equipped
        // add weapon damage mod
    }
    protected override void onUnequip()
    {
        // Remove equipped ammo from weapon
        // remove weapon damage mod
    }
}
