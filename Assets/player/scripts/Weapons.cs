using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bulletprefab;
    public float bulletForce=20f;
    


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
           
        }
      


    }
    void shoot()
    {
     GameObject bullet=   Instantiate(Bulletprefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * bulletForce, ForceMode2D.Impulse);
       
    }
}
