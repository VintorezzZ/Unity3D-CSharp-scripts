using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public void Start()
    {
        Main1.onClick += Spawn;
    }
    public void Spawn()
    {
        transform.position = new Vector3(4, 2, -4);
    }

    private void OnDisable()
    {
        Main1.onClick -= Spawn;
    }
}
