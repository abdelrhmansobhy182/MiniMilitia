using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=20f;
    public int damage=40;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }
    void onTriggrEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Destroy(gameObject);
        if(enemy!= null)
        {
            enemy.TakeDamage(damage);
            
        }
    }

    
}
