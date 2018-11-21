using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : Item {

    public Sprite inGameImage;
    protected abstract void onEquip ();
    protected abstract void onUnequip ();
}
