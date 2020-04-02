using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Func : MonoBehaviour
{
    public Func<int> onGetName;

    private void Start()
    {
        onGetName = () => //this.gameObject.name.Length;
        {
            return this.gameObject.name.Length;
        };
        int characterCount = onGetName();

        Debug.Log("Character count: " + characterCount);

    }

    //int GetName()
    //{
    //    return this.gameObject.name.Length;
    //}
}
