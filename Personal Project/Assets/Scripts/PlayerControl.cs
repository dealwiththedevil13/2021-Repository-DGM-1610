using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header ("Stats")]
    public float moveSpeed;
    public float jumpForce;
    public float turnspeed;

    public int curHp;
    public int maxHp;

    private Camera camera;
    private Rigidbody rb;

    public float lookSensitivity;           //Mouse look sensitivity
    public float maxLookX;      //loewest down we can look
    public float minLookX;      //highest up we can look
    public float rotX;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
