using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

public abstract class Consumable : Item {

    public bool isRawUse; // If it can be directly consumed or has to be used in a special way (ie: crafting)
    public bool isEdible; // If it can be literally consumed
    public UsageTarget usageTarget;

    protected abstract bool onUse(GameObject target);

}
