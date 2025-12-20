using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InventorySlot
{
    public Item item;

    public int quantity;

    public InventorySlot(Item Item, int Quantity)
    {
        this.item = Item;
        this.quantity = Quantity;
    }
}