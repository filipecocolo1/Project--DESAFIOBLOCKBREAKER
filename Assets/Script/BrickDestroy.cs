using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickDestroy : MonoBehaviour
{

    private int score;




    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") )
       
        {
            
            Debug.Log(collision.gameObject.name);
            RecebendoPontus.SetPoints(1, collision.otherCollider.gameObject);
           // Destroy(this.gameObject) ;
            
           
        }
      

    }
   
}
