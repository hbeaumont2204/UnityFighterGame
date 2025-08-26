using UnityEngine;

public class InventoryTest : MonoBehaviour
{
    public Player player;
    public Sprite potionIcon;
    public Sprite swordIcon;

    private void Start()
    {
        // Adding test items
        player.AddItemToInventory(new Item("Potion", potionIcon, true));
        player.AddItemToInventory(new Item("Sword", swordIcon, false));
        player.AddItemToInventory(new Item("Potion", potionIcon, true));  // This will stack with the previous potion
    }
}