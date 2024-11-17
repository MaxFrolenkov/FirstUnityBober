using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private int health = 10;
    private int level = 5;
    privte int speed = 2;
    
    void Start()
    {
        helth+=level;
        print('Здоровье нпс'+ health)
    }

    
    void Update()
    {
        Vector3 newPosition= transfom.position;
        newPosition.z += speed * Time.deltaTime
        
    }
}
