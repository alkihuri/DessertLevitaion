using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public Engine engine;
    float start = 0.1f;
    float total;
    // Update is called once per frame
    void Update()
    {
        total = start + engine.enginePower/10;
        GetComponent<AudioSource>().volume = total;
    }
}
