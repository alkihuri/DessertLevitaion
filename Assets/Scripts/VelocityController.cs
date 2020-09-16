using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{
    [Range(1, 30)] public float maxSpeed;
    [Range(1, 30)] public float minSpeed;
    [Range(1, 30)] public float currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = 12;
        minSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        if(currentSpeed > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized*maxSpeed; 
        } 
    }
}
