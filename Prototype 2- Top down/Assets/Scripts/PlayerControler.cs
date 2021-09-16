using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 10.0f;
    public float hInput;
    
    public float vInput;


    public float xRange = 8.72f;
    public float yRange = 4.95f;

    // public float health
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      hInput = Input.GetAxis("Horizontal");
      vInput = Input.GetAxis("Vertical");
     
      transform.Translate(Vector3.right * speed * hInput * Time.deltaTime);

     transform.Translate(Vector3.up * speed * vInput * Time.deltaTime);
//Create a wall on -x side
     if(transform.position.x < -xRange)
     {
         transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
     }
//create a wall on x side
    
     if(transform.position.x < xRange)
     {
         transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
     }


    }
}
