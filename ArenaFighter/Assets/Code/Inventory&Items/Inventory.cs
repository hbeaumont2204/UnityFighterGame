using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventorySlot> inventoryItems = new List<InventorySlot>();

    public bool checkForItem(Item item)
    {
        foreach(var slot in inventoryItems)
        {
            if (slot.item == item)
            {
                return true;
            }
        }
        return false;
    }
    public void addItem(Item item, int amount = 1)
    {
        foreach (var slot in inventoryItems)
        {
            if (slot.item == item)
            {
                slot.quantity += amount;
                return;
            }
        }

        inventoryItems.Add(new InventorySlot(item,amount));
    }

    public void removeItem(Item item, int amount = 1)
    {
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if (inventoryItems[i].item == item)
            {
                inventoryItems[i].quantity -= amount;

                if (inventoryItems[i].quantity <= 0)
                {
                    inventoryItems.RemoveAt(i);
                }

                return;
            }
        }
    }
}