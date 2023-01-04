using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapCOn : MonoBehaviour
{
    public Animator animWeap;
    public static float attackDmg=35;
    public bool isCoolDown=false;

    public void AttackAnim()
    {
        if (!isCoolDown)
        {
            animWeap.SetTrigger("Attack");
            isCoolDown = true;
            StartCoroutine(CoolDownAttack());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            EnemyCon enemy = collision.gameObject.GetComponent<EnemyCon>();
            enemy.takeDmg(attackDmg);
            Debug.Log(attackDmg);
        }    
    }
    IEnumerator CoolDownAttack()
    {
        yield return new WaitForSeconds(0.5f);
        isCoolDown = false;
    }
}
