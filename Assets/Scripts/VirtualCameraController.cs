using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VirtualCameraController : MonoBehaviour
{
    float speed; 
     public CinemachineVirtualCamera camera;
    public Engine im;
    private void Start()
    {
         camera = GetComponent<CinemachineVirtualCamera>();
    }
    // Update is called once per frame
    void Update()
    {

        camera.GetCinemachineComponent<Cinemachine.CinemachineTransposer>().m_FollowOffset.y = 35 - Mathf.Abs(im.verticalInput * 35);
        camera.GetCinemachineComponent<Cinemachine.CinemachineTransposer>().m_FollowOffset.z = -40 - Mathf.Abs(im.verticalInput * 25);

    }
}
