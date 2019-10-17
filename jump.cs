using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

  
    public float thrust = 10f;
    public OVRPlayerController controller;
    


    // Start is called before the first frame update
    void Start()
    {
        
        controller = GetComponent<OVRPlayerController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            controller.JumpForce = thrust;
            controller.Jump();
        }
            
    }
}
