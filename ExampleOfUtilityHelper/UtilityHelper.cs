using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    public static void CreateObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPositionToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }

    public static void ChangeColor(GameObject obj, Color color, bool randomColor = false)
    {
        if(randomColor == true)
        {
            color = new Color(Random.value, Random.value, Random.value);
        }
               
        obj.GetComponent<MeshRenderer>().material.color = color;       
        
    }
}
