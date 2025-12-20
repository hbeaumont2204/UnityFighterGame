using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

// Add the rest of armour later
//public enum ItemType {  Consumable, Weapon, Helmet, Chestplate, Gauntlets, Greaves, Boots }
public enum ItemType {Consumable, Weapon, Armour}

[CreateAssetMenu(menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public String itemName;
    public Sprite icon;
    public ItemType type;

}
