using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    

    SlowTank slowTank;

    void Awake()
    {
        slowTank = FindObjectOfType<SlowTank>();
    }
 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BigSlowTank")
        {
            //StartCoroutine(PowerUpOff());
            slowTank.isPowerUp = true;
            //other.tankSpeed *= turboSpeed;
            gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "FastTank")
        {
            Destroy(gameObject);
        }
    }

   
   
   
   
   



}
 
 
  // IEnumerator backToNormalSpeed()
 // {
     // yield return new WaitForSeconds(timeForTurbo);
     // Debug.Log(regularSpeed);
     // tankmovement.movementSpeed = regularSpeed;
 // }
 

 
 
 
 
 
