using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public Rigidbody2D rb;
    Vector2 mousePos;
    Vector2 movement;
    float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement  * speed * Time.fixedDeltaTime);
        Vector2 lockDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lockDir.y, lockDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
