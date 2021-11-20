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

        if(curHp <= 0)
        Die();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Move()
    {
        // movement
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        Vector3.movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate( movementDirection* moveSpeed *Time.deltaTime);

    }
}
