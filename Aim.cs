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
        
        //Draws a visible line from source to target
        Debug.DrawRay(transform.position, directionToFace, Color.red);
        
        //rotation to the target
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        
        //Quaternion.Slerp - interpolate the rotation (makes it smoothly)
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2);        
    }
}
