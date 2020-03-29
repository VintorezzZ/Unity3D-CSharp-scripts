using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnEnable()
    {
        Player3.OnDamageReceived += UpdateHealth;
    }

    public void UpdateHealth(int health)
    {
        Debug.Log("Current health " + health);
    }
}
