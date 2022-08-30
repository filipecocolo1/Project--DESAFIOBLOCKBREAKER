using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarraController : MonoBehaviour
{

    public float speed = 0.5f;


    public GameObject Ball;

    private float xValorMax = 5.22f;


    private float xValorMin= -1.96f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

       
    }

    public void Move() {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xValorMin, xValorMax),transform.position.y);

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        transform.position += movement * Time.deltaTime * speed;
         
    
    
    
    }
  




}