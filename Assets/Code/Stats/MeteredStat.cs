using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MeteredStat : Stat {

    [SerializeField]
    private int currValue;

    public int getCurrValue() {
        return currValue;
    }

    public void changeCurrValue(int value) {
        if (value != 0) {
            currValue += value;
        }
    }

}
