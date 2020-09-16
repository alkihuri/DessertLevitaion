using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<Engine>().verticalInput = Input.GetAxis("Vertical"); /// w , s 
        GetComponent<Engine>().horizontalInput = Input.GetAxis("Horizontal"); // a ,d 
    }
}
