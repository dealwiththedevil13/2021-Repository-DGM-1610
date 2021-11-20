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
    void Update()
    {
        // movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3.MovementDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate( movementDirection* moveSpeed *Time.deltaTime);

    }
}
