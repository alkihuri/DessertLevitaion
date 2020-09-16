using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    ParticleSystem.EmissionModule emission;

    [SerializeField]Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
       emission =  ps.emission;
    }

    // Update is called once per frame
    void Update()
    {
        emission.rateOverTime = rg.velocity.magnitude * 2;
    }
}
