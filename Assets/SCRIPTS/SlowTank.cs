using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTank : Tank
{

    // make a shooting speed that is different and or an override
       

    // make an override of the vehicle speed
    float tankBoost = 1.1f;
    private float turboAmount = 5f;
    //[SerializeField] public bool isPowerUp;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              
            Move(isPowerUp);
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    
    
    
    
    
}
