using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class callback : MonoBehaviour
{
    public Action action;
    public void Start()
    {
        StartCoroutine(MyRoutine(() => 
        { 
            Debug.Log("Routine is finished");            
        }));
    }

    public IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5.0f);

        if (onComplete != null)
        {
            onComplete();
        }
            
    }

}
