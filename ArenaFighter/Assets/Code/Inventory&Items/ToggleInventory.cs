using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleInventory : MonoBehaviour
{

    public GameObject playerInventory;
    public GameObject[] ArmourInventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInventory.SetActive(false);
        foreach (GameObject inventory in ArmourInventory)
        {
            inventory.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Detect W key hold
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I key has been pressed");
            playerInventory.SetActive(!playerInventory.activeSelf);
            foreach (GameObject inventory in ArmourInventory)
            {
            inventory.SetActive(!inventory.activeSelf);
            }
        }
    }
}
