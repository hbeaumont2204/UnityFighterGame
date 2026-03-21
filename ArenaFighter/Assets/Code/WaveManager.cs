using UnityEngine;


public class WaveManager : MonoBehaviour
{
    int waveNumber = 1;
    bool waveStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waveStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        getEnemyCount();
    }

    public int getEnemyCount()
    {
        GameObject[] enemies= GameObject.FindGameObjectsWithTag("Enemy");
        int count = enemies.Length;
        Debug.Log("Enemy Count: " + count);
        return count;
    }
}
