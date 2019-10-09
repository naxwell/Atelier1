using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noGravityMovement : MonoBehaviour
{
    public GameObject centerCamera;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
          
        {

            transform.position += centerCamera.transform.forward * Time.deltaTime * movementSpeed;
        }
    }
}
