using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTank : Tank
{

    [SerializeField] Rigidbody bigTankBullet;
    [SerializeField] int bigDamage;

    //[SerializeField] public bool isPowerUp;
    
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //INHERITANCE
        Move(isPowerUp);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }else if (Input.GetKeyDown(KeyCode.B))
        {
            //POLYMORPHISM
            Shoot(bigTankBullet);
        }


    }

}
