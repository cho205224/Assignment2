using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrack : MonoBehaviour
{
    public GameObject player;
    private Vector3 _angles;

    void Start()
    {
        _angles = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float maxSpeed = 1000.0f;
        float minSpeed = 10.0f;
        float alpha = 0.2f; // normalized to [0.0, 1.0] scale
        float interpolatedSpeed = (1.0f - alpha) * minSpeed + alpha * maxSpeed;

        transform.Rotate (_angles * interpolatedSpeed * Time.deltaTime);
    }
}
