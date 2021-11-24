using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnspeed;

    // Start is called before the first frame update
    void Start()
    {
        turnspeed = ;

            print(speed);
            print(turnspeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.translate(Vector3.forward* speed * Time.deltaTime);
    }
}
