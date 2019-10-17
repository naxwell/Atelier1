using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//PUT THIS ON THE OBJECT YOU WANT TO CHANGE COLOUR
public class colorChangeOnRay : MonoBehaviour
{
    public lookingAt lookingAt; //reference our lookingAt script
    public Renderer Rend; //Renderers are in charge of how objects look 
    public Color startingColor; // the default colour of this object 
    public Color lookedAt; // the colour we want to change it to when it is looking at
    // Start is called before the first frame update
    void Start()
    {
        Rend = GetComponent<Renderer>(); //get the renderer attached to this gameObject
    }

    // Update is called once per frame
    void Update()
    {
       if(lookingAt.raycasted == this.gameObject) // this is the reference to the public variable we created in the other script. it is what we the player is currently looking at
        {                                        // we want to check if what we are looking at is this gameObject
            Rend.material.SetColor("_Color", lookedAt); // if it is, change it to our lookedAt colour
        } else
        {
            Rend.material.SetColor("_Color", startingColor); // if not, make our colour the default
        }
    }
}
