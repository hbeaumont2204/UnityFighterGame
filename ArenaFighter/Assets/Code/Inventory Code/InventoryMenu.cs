using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{

    public Inventory inventory;

    public GameObject inventorySlot; // Slot prefab
    public Transform InventoryPanel; // Inventory UI

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RefreshUI(); // Updates UI on game start 
    }

    // Update is called once per frame
    void Update()
    {
        RefreshUI();
    }
    public void RefreshUI()
    {
        // Remove old slots
        foreach (Transform child in InventoryPanel)
        {
            Destroy(child.gameObject);
        }

        // Create a new slot for each item in the inventory
        foreach (var slot in inventory.inventoryItems)
        {
            GameObject newSlot = Instantiate(inventorySlot, InventoryPanel);

            // Set the icon
            Image iconImage = newSlot.transform.Find("Icon").GetComponent<Image>();
            iconImage.sprite = slot.item.icon;

            // Set the quantity text
            TMP_Text qtyText = newSlot.transform.Find("Quantity").GetComponent<TMP_Text>();
            qtyText.text = slot.quantity.ToString();
        }
    }

}
