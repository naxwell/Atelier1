using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gazeColourChange : MonoBehaviour
{
    public RaycastHit CastHit;//This is needed for all raycasts to work
    public GameObject raycasted; //this is referencable by other scripts in case you to know what object the player is looking at


    void Start()
    {
        
    }

    void Update()
    {
        //this is the most basic raycast script
        if (Physics.Raycast(transform.position, transform.forward, out CastHit, Mathf.Infinity))
        {

            if (CastHit.collider.gameObject.tag == "colourChanging") //checks to make sure the tag of the object is something we have set to allow colour a change to
            {
                raycasted = CastHit.collider.gameObject; //sets the public variable above to the object being hit by the raycast
                CastHit.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green); //changes the base colour of the object to green 
            }
        }
    }
}
