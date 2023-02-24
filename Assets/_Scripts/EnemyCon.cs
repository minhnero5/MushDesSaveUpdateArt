using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    public GameObject target;
    public Rigidbody2D rb;
    public static bool gameover;
    Vector3 directionToTarget;
    public float moveSpeed=1f;
    public float curHP;
    public float HP = 100f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        curHP = HP;
        //moveSpeed = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            gameover = true;
            Debug.Log("alo");
        }
    }
    public void EnemyMove()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            transform.position += new Vector3(directionToTarget.x , directionToTarget.y,0)*moveSpeed*Time.deltaTime;
            if (transform.position.x < target.transform.position.x) transform.localScale = new Vector3(1, 1, 1);
            if (transform.position.x >= target.transform.position.x) transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    public void takeDmg(float dmg)
    {
        if (curHP > 0) curHP -= dmg;
        if (curHP <= 0) Destroy(gameObject);
    }
}
