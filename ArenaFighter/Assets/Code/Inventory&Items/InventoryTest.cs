using UnityEngine;

public class TestInventoryAdd : MonoBehaviour
{
    public Inventory inventory;
    public Item itemToAdd;
    public Item itemToAdd2;

    public Item itemToAdd3;
    public Item itemToAdd4;

    void Start()
    {
        //inventory.addItem(itemToAdd, 2);
        //inventory.addItem(itemToAdd2, 3);
        inventory.addItem(itemToAdd3, 5); // Health Crystals
        inventory.addItem(itemToAdd4,1); // Chestplate
        Debug.Log("Items added");
    }
}