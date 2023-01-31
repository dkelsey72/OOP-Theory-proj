using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTank : Tank
{

    // make a shooting speed that is different and or an override
    

    // make an override of the vehicle speed
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
