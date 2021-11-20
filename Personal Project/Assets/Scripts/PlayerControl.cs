using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float turnspeed;
     
    public int curHp;
    public int maxHp;

    private Rigidbody rb;

    //applies all the damage to the player
    public void TakeDamage(int damage)
    {
        curHp-= damage;

      
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Move()
    {
        // movement
        float horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalInput = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 dir = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate( dir * moveSpeed *Time.deltaTime);

        rb.velocity = dir;

    }
}
