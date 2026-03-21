using UnityEngine;



public class WaveManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
