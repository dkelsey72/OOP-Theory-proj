using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTank : Tank
{
    // Start is called before the first frame update
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