using System.Security.Cryptography;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WeaponController wc;
    //public GameObject HitParticle;

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy" && wc.isAttacking)
        {
            Debug.Log(other.name);
            //other.GetComponent<Animator>().SetTrigger("Hit");
            /*Instantiate(HitParticle, new Vector3(other.transform.position.x,
            transform.position.y, other.transform.position.z),
            other.transform.rotation);*/
            Enemy enemy = other.GetComponent<Enemy>();
            enemy.reduceHealth(wc.damage);
        }
    }
}
