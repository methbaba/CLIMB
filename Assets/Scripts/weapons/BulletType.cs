using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;


    //reference to trigger SO 

    [SerializeField] attackManager attack;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        //here transform.right is VERY IMP since it is local space without this we cannot rotate our bullet with our player  
        rb.velocity = transform.right * speed *Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("destructible"))
        {
            attack.doDamage();
            gameObject.SetActive(false);
        }
    }
}
