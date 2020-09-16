using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    RaycastHit ground;
    [Range(1, 30)] public float groundDistance;
    [Range(1, 30)] public float needDistance;
    [Range(1, 30)] public float enginePower;
    [Range(0, 3)] public float idleDelta;
    [Range(-1, 1)] public float verticalInput;
    [Range(-1, 1)] public float horizontalInput;
    float realMass;
    // Start is called before the first frame update
    void Start()
    {
        idleDelta = 0.2f;
        realMass = GetComponent<Rigidbody>().mass;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        #region levitation
        if (Physics.Raycast(transform.position,-transform.up+transform.forward,out ground))
        {
            groundDistance = ground.distance;
        }
         
        enginePower = Mathf.Pow(Mathf.Abs(needDistance - groundDistance),2); 

        if(groundDistance <  needDistance)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * realMass * enginePower, ForceMode.Impulse);
        }
        if(groundDistance > needDistance - idleDelta)
        {
            GetComponent<Rigidbody>().AddForce(-transform.up * realMass * enginePower, ForceMode.Impulse);
        }
        
        #endregion

        #region control
        float vertical, horizontal;
        vertical = verticalInput;
        horizontal = horizontalInput * GetComponent<Rigidbody>().velocity.magnitude/25;
        GetComponent<Rigidbody>().AddForce(transform.forward  * vertical  * realMass/33, ForceMode.VelocityChange);
        transform.Rotate(0, horizontal, 0);
        #endregion

         
    }

   

}
