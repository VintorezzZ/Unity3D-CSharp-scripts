using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDmgScript : MonoBehaviour
{    
    public int health = 50;
   
    void Update()
    {
        if (Gameover() == false)
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                Damage(Random.Range(1 ,10));
            }
        }        
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (Gameover() == true)
        {
            health = 0;            
            Debug.Log("Player is died");
        }
    }
    
    public bool Gameover()
    {
        return health < 1;
    }
}
