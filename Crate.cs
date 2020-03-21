using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject fracturedCrate;
    public GameObject ExplosionEffect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            GameObject fracturedCrateObject = Instantiate(fracturedCrate, transform.position, Quaternion.identity) as GameObject;
            Rigidbody[] allRigidBodies = fracturedCrateObject.GetComponentsInChildren<Rigidbody>();
            if(allRigidBodies.Length > 0)
            {
                foreach(var rb in allRigidBodies)
                {
                    rb.AddExplosionForce(500, transform.position, 1);
                }
            }
            Destroy(this.gameObject);
        }
    }
}
