using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{
    public Inventory inventory;

    public GameObject inventorySlot; // Slot prefab
    public Transform InventoryPanel; // Inventory UI
    public Transform helmetPanel;
    public Transform chestPanel;
    public Transform legPanel;
    public Transform bootPanel;

    private Transform panel;


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
        foreach (Transform child in helmetPanel)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in chestPanel) {
            Destroy(child.gameObject);
        }

        // Create a new slot for each item in the inventory
        foreach (var slot in inventory.inventoryItems)
        {
            if (slot.item.type == ItemType.Consumable)
            {
                panel = InventoryPanel;
            }
            else if (slot.item.type == ItemType.Helmet)
            {
                panel = helmetPanel;
            }
            else if (slot.item.type == ItemType.Chestplate) {
                panel = chestPanel;
            }
            

            GameObject newSlot = Instantiate(inventorySlot, panel);

            // Set the icon
            Image iconImage = newSlot.transform.Find("Icon").GetComponent<Image>();
            iconImage.sprite = slot.item.icon;

            // Set the quantity text
            TMP_Text qtyText = newSlot.transform.Find("Quantity").GetComponent<TMP_Text>();
            qtyText.text = slot.quantity.ToString();
        }
    }

}
