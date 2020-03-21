using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    Transform cube;
    
    void Update()
    {
        Vector3 directionToFace = cube.position - transform.position;

        Debug.DrawRay(transform.position, directionToFace, Color.red);

        transform.rotation = Quaternion.LookRotation(directionToFace);
    }
}
