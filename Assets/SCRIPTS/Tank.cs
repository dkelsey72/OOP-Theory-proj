using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
   // ENCAPSULATION
   [SerializeField] float damageDealt = 10f;
   [SerializeField] float damageTaken;
   [SerializeField] public float tankSpeed; 
   [SerializeField] public float turboSpeed;
   [SerializeField] float tankRotationSpeed;
   [SerializeField] float bulletForce;
   [SerializeField] Rigidbody bulletPrefab;
   [SerializeField] Transform firePoint;

   [SerializeField] public bool isPowerUp;
    

   private float horizontalInput;
   private float verticalInput;
   private int waitTime = 5;

   


   void Awake()
   {
      // bulletPrefab = GetComponent<Rigidbody>();
      //isPowerUp = false;
   }
   
    void Update()
    {

    }
   
   //ABSTRACTION
   protected void Move(bool tf)
   {
      if (tf)
      {
         tankSpeed = 100;
         StartCoroutine("PowerUpOff");
      }else
      {
         tankSpeed = 50;
      }

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

    IEnumerator PowerUpOff()
      {
         yield return new WaitForSeconds(waitTime);
         isPowerUp = false;
      }
   
}
