using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAndDestroy : MonoBehaviour
{
    private void Start()
    {
        Destroy(GameObject.Find("Cube"), 3);
    }
}
