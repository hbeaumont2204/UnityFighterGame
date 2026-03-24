using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public GameObject[] items; // Items to randomly spawn in the arens
    public GameObject[] locations; // Locations to randomly spawn the items

    private int i;
    private int j;
    private GameObject item;
    private GameObject location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*    void spawnItem()
    {
        i = Random.Range(0,items.Length);
        j = Random.Range(0,locations.Length);

        Instantiate(items[i],locations[j].transform.position,locations[j].transform.rotation);
    } */

    void spawnItem()
    {
        while (true)
        {
            i = Random.Range(0,items.Length);
            j = Random.Range(0,locations.Length);

            item = items[i];
            location = locations[j];
            ItemSpawnLocation spawnLocation = location.GetComponent<ItemSpawnLocation>();
            if (!(spawnLocation.getUsed()))
            {
                Instantiate(item,location.transform.position,location.transform.rotation);
                spawnLocation.setUsed(true);
                break;
            }
        }
    }
}
