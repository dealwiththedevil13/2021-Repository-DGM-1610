using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public float lifetime;
    private float shootTime;

    void OnEnable()
    {
        shootTime= Time.time;
    }

    void OnTriggerEnter(Collider other)
    {
        //If hit deal out damage to the Player
        if(other.CompareTag("Player"))
            other.GetComponent<PlayerController>().TakeDamage(damage);
            //If hit deal out damage to the Enemy
        else if(other.CompareTag("Enemy"))
            other.GetComponent<Enemy>().TakeDamage(damage);
        // Disable Projectile for future use
        gameObject.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time - shootTime >= lifetime)
        gameObject.SetActive(false);
    }
}
