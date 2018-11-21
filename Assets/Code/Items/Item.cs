using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

public abstract class Item : ScriptableObject {

    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;

    public Rarity itemRarity;
    public int itemValue;
    public int itemWeight;
	
}
