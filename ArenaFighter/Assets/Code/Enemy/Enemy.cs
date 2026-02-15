using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int enemyHealth = 100;
    public int enemyXPDrop;

    void Start()
    {

    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Enemy Dead");
        }
    }

    public void reduceHealth(int damage)
    {
        //Debug.Log("Damage");
        enemyHealth -= damage;
    }
}
