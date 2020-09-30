using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody;
    public KeyCode Up,Down ,Right ,Left,Space;
    //movement
    float x_axcis,y_axcis;
    public float speed = 5f;
    public float  Force = 120f;
    //check is grounded
    public bool isground;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGrounded;
    //rotate
   public bool right =true;
   public bool left = false;
    bool Dead = true;
    // shooting
  public  Camera cam;
 Vector2 mousePos;
    Vector2 move;
    void Start()
    {
        animator.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
       
    }
   public void EndGame()
    {
        if(Dead==true)
        animator.SetBool("Die", true);
        else
        {
            animator.SetBool("Die", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
       

        //check if player is grounded or not 
        isground = Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGrounded);
       
        if(Input.GetKey(Right)&&left==true)
        {
            transform.Rotate(0, 180, 0);
            left = false;
            right = true;
            speed *= -1;
        }
        if (Input.GetKey(Left) && right == true)
        {
            transform.Rotate(0, 180, 0);
            right = false;
            left = true;
            speed *= -1;
        }
        if (Input.GetKey(Right) && right == true)
        {
           
            left = false;
            right = true;
            if(speed<0)
            speed *= -1;
        }
        if (Input.GetKey(Left) && left == true)
        {

            left = true;
            right = false;
            if (speed > 0)
                speed *= -1;
        }
       
       
           
        
        


      ///  Debug.Log(angle);
        
       if(Input.GetKey(Right))
        {
            x_axcis += 0.01f;
            if (x_axcis > 1)
                x_axcis = 0.9f;
        }
        else if (Input.GetKey(Left))
        {
            x_axcis -= 0.01f;
            if (x_axcis < -1)
                x_axcis = -0.9f;
        }
        else if (Input.GetKey(Up))
        {
            y_axcis += 0.01f;
            if (y_axcis > 1)
                y_axcis = 0.9f;
        }
       else if (Input.GetKey(Down))
        {
            y_axcis -= 0.01f;
            if (y_axcis < -1)
                y_axcis = -0.9f;
        }
        else
        {
            x_axcis = 0;
            y_axcis = 0;
        }


        //if (Input.GetKey(UP))
        //{
        //    rigidbody.AddForce(Vector2.up* Force);
        //}
        transform.Translate(x_axcis * Time.deltaTime * speed, y_axcis * Time.deltaTime * 10, 0);
        if (isground)
        {
            if (left == true)
                speed = -6;
            else
                speed = 6;
            animator.SetBool("fly", false);
            if (Input.GetKey(Right)|| Input.GetKey(Left))
            {
               
                animator.SetBool("walk", true);
            }
           
            else animator.SetBool("walk", false);
            if(Input.GetKey(Space))
            {
                animator.SetBool("shoot", true);
            }
            else animator.SetBool("shoot", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("run", true);
                if (left == true)
                    speed = -10;
                else
                    speed = 10;
            }
            else
            {
                animator.SetBool("run", false);
                if (left == true)
                    speed = -5;
                else
                    speed = 5;
            }
        }
        else
        {
            if(left==true)
                speed = -10;
            else
            speed = 10;
             animator.SetBool("fly", true);
            if (Input.GetKey(Space))
            {
                animator.SetBool("shoot", true);
            }
            else animator.SetBool("shoot", false);

        }
        
        
    }   
}
