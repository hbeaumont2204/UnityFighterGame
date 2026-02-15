using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleInventory : MonoBehaviour
{

    public GameObject playerInventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Detect W key hold
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I key has been pressed");
            playerInventory.SetActive(!playerInventory.activeSelf);
        }
    }
}
