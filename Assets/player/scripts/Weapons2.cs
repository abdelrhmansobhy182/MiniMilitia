using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons2 : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bulletprefab;
    public float bulletForce = 20f;
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {
            shoot();
        }
        


    }
    void shoot()
    {
        GameObject bullet = Instantiate(Bulletprefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
