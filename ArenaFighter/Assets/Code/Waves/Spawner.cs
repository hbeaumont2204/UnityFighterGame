using UnityEngine;
using System.Threading.Tasks;


public class Spawner : MonoBehaviour
{
    public WaveManager waveManager;
    public GameObject enemy;

    public GameObject enemy2; // Stronger enemy than default
    public GameObject enemy3; // Weaker enemy that does more damage

    public bool bossSpawner = false;
    public bool active = true;


    int count;
    int total = 0;
    void Start()
    {
        spawn(enemy);
    }


    void Update()
    {
        if (!bossSpawner)
        {
            count = waveManager.getEnemyCount();
            if (count < 6 & active)
            {
                active = false;
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
        
        active = waveManager.getActive();

    }

    // ADD WORKING DELAY LATER
    void spawn(GameObject enemy)
    {
        //await Task.Delay(5000);
        Instantiate(enemy, transform.position, transform.rotation);
        total++;
    }
    
}
