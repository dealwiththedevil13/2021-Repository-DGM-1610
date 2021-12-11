using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
     //bobbing and rotation motion
    [Header("Bobbing Motion")]
    public float rotationSpeed;
    public float bobSpeed;
    public float bobHeight;
    private bool bobbingUp;

    private Vector3 startPos;
    //get Audio for pickup
   public AudioClip pickupSFX;

   void Start()
   {
       startPos = transform.position;
   }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Refrence Audio SOurce to play sound effect
            other.GetComponent<AudioSource>().PlayOneShot(pickupSFX);
            //Destroy PickUp
            Destroy(this.gameObject);
        }
    }
}
