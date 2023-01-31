using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
   
   [SerializeField] float damageDealt = 10f;
   [SerializeField] float damageTaken;
   [SerializeField] public float tankSpeed {get; private set;}
   [SerializeField] public float turboSpeed {get; private set;}
   [SerializeField] float tankRotationSpeed;
   [SerializeField] float bulletForce;
   [SerializeField] Rigidbody bulletPrefab;
   [SerializeField] Transform firePoint;


   private float horizontalInput;
   private float verticalInput;


   void Awake()
   {
      // bulletPrefab = GetComponent<Rigidbody>();
   }
   
    void Update()
    {

    }
   
   
   protected void Move()
   {
    // add script to move generic Tank
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");
   // make sure only positive numbers are used
    transform.Translate(Vector3.forward * Mathf.Abs(tankSpeed) * Time.deltaTime * verticalInput);
    transform.Rotate(Vector3.up * Mathf.Abs(tankRotationSpeed) * Time.deltaTime * horizontalInput);


   }

   protected void Shoot()
   {
    // add script to shoot bullet from Tank
      var bull = Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity);
      bull.AddForce(transform.forward * bulletForce, ForceMode.Impulse);


    
   }

   protected void Shoot(Rigidbody ammo)
   {
   // add script to shoot bullet from Tank
      var bull = Instantiate(ammo, firePoint.transform.position, Quaternion.identity);
      bull.AddForce(transform.forward * bulletForce, ForceMode.Impulse);
   
 
   }
   
}
