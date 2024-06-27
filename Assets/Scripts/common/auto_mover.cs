using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class auto_mover : MonoBehaviour
{
    [SerializeField] float speed = 45f;
    [SerializeField] bool isFacingRight=false;
    [SerializeField] Transform wallcheck;
    [SerializeField] Rigidbody2D rb;
    float direction = -1f;
    bool wall = false;
    [SerializeField] LayerMask wallLayer;
    float rad = 0.2f;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        wall = Physics2D.OverlapCircle(wallcheck.position,rad,wallLayer);

        if (wall)
        {
            
            flip();
        }
    }
    private void FixedUpdate()
    {
        if (!isFacingRight)
        {
            rb.velocity = new Vector2(speed * direction * Time.deltaTime, 0);
        }else
        {
            rb.velocity = new Vector2(speed  * Time.deltaTime, 0);
        }
        
       
    }

    void flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        isFacingRight = !isFacingRight;
    }

}
