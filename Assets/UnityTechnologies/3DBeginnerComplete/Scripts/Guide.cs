using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;
    bool hasPlayed = false;

    void Start()
    {
        hasPlayed = false;
    }
    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider collider)
    {
        if (!hasPlayed && collider.gameObject.tag == "Player")
        {
            source.Play();
            hasPlayed = true;
        }
    }
}