using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed, jumpForce;         //movement speed in units per second
    public float jumpForce;         //force applied upwards

    public float lookSensitivity;           //Mouse look sensitivity
    public float maxlookX;      //loewest down we can look
    public float minLookX;      //highest up we can look
    public float rotX;          //curent x rotation

    private Camera camera;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Get components
        Camera= camera.main;
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x= Input.GetAxis("Horizontal") * moveSpeed;
         float z= Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector3(x,rb.velocity.y, z);
    }

    void CamLook()
    {
        float y= Input.GetAxis("Mouse X") * lookSansitivity;
        rotX -= Input.GetAxis("Mouse Y") * lookSensitivity;
    }
}
