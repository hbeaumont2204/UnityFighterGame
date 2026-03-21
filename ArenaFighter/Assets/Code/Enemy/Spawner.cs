using UnityEngine;


public class Spawner : MonoBehaviour
{
    public WaveManager waveManager;
    public GameObject enemy;

    public GameObject enemy2; // Stronger enemy than default
    public GameObject enemy3; // Weaker enemy that does more damage

    

    int count;
    int total = 0;
    void Start()
    {
        spawn(enemy);
    }

    void Update()
    {
        count = waveManager.getEnemyCount();
        if (count == 0)
        {
            if (total % 5 == 0) // Chance of stronger enemy spawning
            {
                int n1 = Random.Range(1,10);
                int n2 = Random.Range(1,10);
                if (n1 == n2)
                {
                    spawn(enemy2);
                }
                else
                {
                    spawn(enemy3);
                }
            }
            else
            {
                spawn(enemy);
            }
        }
    }

    void spawn(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
        total++;
    }
}
