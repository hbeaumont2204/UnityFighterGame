using System.Collections;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject Sword;
    public bool canAttack = true;
    public bool isAttacking = false;
    public float cooldown = 1.0f;
    public AudioClip swordAttackSound;
    public int damage = 20;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            attack();
        }
    }

    public void attack()
    {
        isAttacking = true;
        canAttack = false;
        Animator swordAnim = Sword.GetComponent<Animator>();
        swordAnim.SetTrigger("Attack");
        //AudioSource ac = GetComponent<AudioSource>();
        //ac.PlayOneShot(swordAttackSound);
        StartCoroutine(ResetAttackCooldown());
    }

    IEnumerator ResetAttackCooldown()
    {
        StartCoroutine(ResetAttack());
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    }

    IEnumerator ResetAttack()
    {
        yield return new WaitForSeconds(1.0f);
        isAttacking = false;
    }
}
