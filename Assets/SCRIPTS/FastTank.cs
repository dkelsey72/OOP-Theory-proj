using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTank : Tank
{

    [SerializeField] Rigidbody bigTankBullet;
    [SerializeField] int bigDamage;

    
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }else if (Input.GetKeyDown(KeyCode.B))
        {
            Shoot(bigTankBullet);
        }


    }

}
