using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hit : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject hitEffect;
    int counter = 0;
    public movement move;
    bool two = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("bullet"))
        {
            counter += 10;
            if(counter==100)
            {
               
                
                move.EndGame();
                move.enabled=false;
                SceneManager.LoadScene("Scene_3");
                counter = 0;
            }
            Destroy(collision.gameObject);
        }
            

    }
}
