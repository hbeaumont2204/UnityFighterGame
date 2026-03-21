using UnityEngine;


public class WaveManager : MonoBehaviour
{
    int waveNumber = 1;
    bool waveActive = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //waveActive = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (getEnemyCount() == 0) // Starts a new wave of enemies
        {
            waveActive = true;
        }
        else // Doesn't spawn new enemies until there are none left
        {
            waveActive = false; 
        }
    }


    public int getEnemyCount()
    {
        GameObject[] enemies= GameObject.FindGameObjectsWithTag("Enemy");
        int count = enemies.Length;
        Debug.Log("Enemy Count: " + count);
        return count;
    }


    public bool getActive()
    {
        return waveActive;
    }
}
