using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
   
   [SerializeField] float damageDealt = 10f;
   [SerializeField] float damageTaken;
   [SerializeField] float tankSpeed;
   [SerializeField] float bulletForce;
   [SerializeField] Rigidbody bulletPrefab;


   private float horizontalInput;
   private float verticalInput;

   
    void Update()
    {

    }
   
   

   
   
   
   protected void Move()
   {
    // add script to move generic Tank
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    transform.Translate(Vector3.forward * tankSpeed * Time.deltaTime * verticalInput);
    transform.Rotate(Vector3.up * tankSpeed * Time.deltaTime * horizontalInput);


   }

   protected void Shoot()
   {
    // add script to shoot bullet from Tank

   }
   
}
