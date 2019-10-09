using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wilhelmScream : MonoBehaviour
{

    public AudioSource wilhelm;
    // Start is called before the first frame update
    void Start()
    {
        wilhelm = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        wilhelm.Play();
    }
}
