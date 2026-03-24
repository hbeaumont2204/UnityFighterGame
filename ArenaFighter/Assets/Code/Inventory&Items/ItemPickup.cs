using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public Item item; // The item the object represents
    public int quantity = 1; 

    Inventory inventory;

    private void OnTriggerEnter(Collider other)
    {
        inventory = other.GetComponent<Inventory>();


        if (inventory != null)
        {
            inventory.addItem(item,quantity);

            Destroy(gameObject); // Destroys item on use
        }
    }
}
