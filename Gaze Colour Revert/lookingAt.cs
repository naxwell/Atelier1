using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//PUT THIS ON YOUR CAMERA

public class lookingAt : MonoBehaviour
{

    public RaycastHit CastHit;
    public GameObject raycasted; // stores the object player is looking at in a public variable to be accessed by other scripts
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out CastHit, Mathf.Infinity))
        {

            raycasted = CastHit.collider.gameObject; //sets the public variable above to the object being hit by the raycast

        }
    }
}
