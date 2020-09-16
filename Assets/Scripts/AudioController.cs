using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public Engine engine;
    float start = 0.25f;
    float total;
    // Update is called once per frame
    void Update()
    {
        total = start + engine.enginePower/20;
        GetComponent<AudioSource>().volume = total;
    }
}
