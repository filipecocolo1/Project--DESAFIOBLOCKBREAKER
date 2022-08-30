using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    private Rigidbody2D MyRb { get; set; }
    private float speed = 230;
   


    // Start is called before the first frame update
    private void Awake()
    {
        MyRb = GetComponent<Rigidbody2D>();
       
        


    }

    void Start()
    {
        Invoke(nameof(SetRandomTrajetory), 1f);
    }

    public void Update()
    {
      
    }

    private void SetRandomTrajetory() // DIREÇÃO EM QUE A BOLA VAI
    {
        Vector2 force = Vector2.zero;
        force.x = Random.RandomRange(-1.0f, 1.0f);

        force.y = -1f;

        MyRb.AddForce(force.normalized * speed);
    }



       public void OnCollisionEnter2D(Collision2D collision)
       {

        if (collision.gameObject.CompareTag("Dead")) // VERIFICA A TAG DO OBJETO COLIDIDO 
        {
            print(collision.gameObject.name);
            collision.gameObject.GetComponent<ControllerLife>().ReceberDano();
        }
       
       }


  





}

