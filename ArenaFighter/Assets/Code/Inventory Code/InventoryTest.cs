using UnityEngine;

public class TestInventoryAdd : MonoBehaviour
{
    public Inventory inventory;
    public Item itemToAdd;

    void Start()
    {
        inventory.addItem(itemToAdd, 1);
        Debug.Log("Item added");
    }
}