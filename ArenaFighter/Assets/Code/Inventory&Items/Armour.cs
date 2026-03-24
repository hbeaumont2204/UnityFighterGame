using UnityEngine;

public enum ArmourType {Helmet, Chestplate, LegArmour, Boots}

[CreateAssetMenu(menuName = "Items/Armour")]
public class Armour : Item
{
    public ArmourType armourType;
    public int armourPoints;
}