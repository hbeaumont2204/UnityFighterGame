using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public GameObject[] items; // Items to randomly spawn in the arens
    public GameObject[] locations; // Locations to randomly spawn the items

    private int i;
    private int l;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        i = Random.Range(0,items.Length);
        l = Random.Range(0,locations.Length);

        Instantiate(items[i],locations[l].transform.position,locations[1].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
