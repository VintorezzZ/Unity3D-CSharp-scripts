using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //this able to use Actions

public class Player3 : MonoBehaviour
{
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    public static Action<int> OnDamageReceived;
    public int Health { get; set; }
    public void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        Health--;
        //if (onDamage != null)
        //    onDamage(Health);
        if (OnDamageReceived != null)
            OnDamageReceived(Health);
    } 
    
}
