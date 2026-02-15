using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        spawn();
    }

    void spawn()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
