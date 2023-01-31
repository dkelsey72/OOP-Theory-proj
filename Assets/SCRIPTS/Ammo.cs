using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
  
  [SerializeField] int damageDealt;


  protected void DealDamage()
  {
    // deal damage to other tank in the amt of damageDealt
  } 

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Target")
    {
      Destroy(other.gameObject);
      Destroy(gameObject);
      Debug.Log("Deal Damage " + damageDealt );
    }
  }
  
  
}
