using UnityEngine;
using UnityEngine.InputSystem;

public class ConsumeItem : MonoBehaviour
{
    public Player player;
    public Inventory playerInventory;

    public Item item;

    public Consumable consumable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detect W key hold
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerInventory.checkForItem(item))
            {
                playerInventory.removeItem(item);
                player.addHealth(consumable.healAmount);
            }
        }
    }
}
