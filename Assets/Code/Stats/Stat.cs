using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat {

    [SerializeField]
    private int baseValue;

    private List<int> modifiers = new List<int>();

    public int getValue () {
        // Add all modifiers to base stat
        int retVal = baseValue;
        foreach (int i in modifiers) {
            retVal += i;
        }
        return retVal;
    }

    public void changeValue (int value) {
        if (value != 0) {
            baseValue += value;
        }
    }

    public void addModifier (int modifier) {
        if (modifier != 0) {
            modifiers.Add(modifier);
        }
    }

    public void removeModifier (int modifier) {
        if (modifier != 0) {
            modifiers.Remove(modifier);
        }
    }

}
