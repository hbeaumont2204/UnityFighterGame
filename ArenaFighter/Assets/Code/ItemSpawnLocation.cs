using UnityEngine;

public class ItemSpawnLocation : MonoBehaviour
{
    private bool used = false;
    private float timer = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (used)
        {
            timer -= Time.deltaTime; // Timer counts down
            if (timer <= 0)
            {
                timer = 30f;
                used = true;
            }
        }
    }

    public bool getUsed()
    {
        return used;
    }

    public void setUsed(bool x)
    {
        used = x;
    }
}
