using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    bool isInRange = false;
    public Transform destination;
    private GameObject player;
    private AudioSource audioSource;   


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.FindWithTag("Player");
    }       

    void Update()
    {
        transform.Rotate(0f, 1f, 0f); //Монета с каждым кадром будет вращаться
        if (isInRange)
            Teleportt();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isInRange = true;
            audioSource.Play();
        }
            
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            isInRange = false;
    }

    void Teleportt()
    {
        player.transform.position = destination.position;
    }
}
