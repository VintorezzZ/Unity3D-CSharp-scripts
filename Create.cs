using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject thePrefab;
    void Start()
    {
        GameObject instance = new GameObject();
        instance = Instantiate(thePrefab, transform.position, transform.rotation) as GameObject;
    }

    
}
