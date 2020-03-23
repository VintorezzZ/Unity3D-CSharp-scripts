using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.CreateObject();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            UtilityHelper.SetPositionToZero(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            UtilityHelper.ChangeColor(this.gameObject, Color.red, true);
        }
    }
}
