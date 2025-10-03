using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SlotTag {  None, Head, Chest, Arms, Legs, Feet }

[CreateAssetMenu(menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public Sprite sprite;
    public SlotTag itemTag;


    [Header("If the item can be equipped")]
    public GameObject equipmentPrefab;
}
