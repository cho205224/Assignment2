using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] ParticleSystem collectParticle = null;

    void Start()
    {
        CollectPause();
    }

    void OnTriggerEnter(Collider collider)
    {
        Collect();
    }

    void OnTriggerExit(Collider collider)
    {
        CollectPause();
    }

    public void Collect()
    {
        collectParticle.Play();
    }

    public void CollectPause()
    {
        collectParticle.Pause();
        collectParticle.Clear();
    }
}
