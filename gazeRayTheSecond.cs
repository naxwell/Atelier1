using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is a script for destroying cubes with your eyeballs 


public class gazeRayTheSecond : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; 
        if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.tag == "Cubes")
            {

                Destroy(hit.collider.gameObject);
            }
        }
    }
}
