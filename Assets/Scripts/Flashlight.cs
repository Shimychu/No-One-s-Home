using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public AudioSource audioSource;
    public Light light;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleLight()
    {
        if (light.enabled)
            light.enabled = false;
        else
            light.enabled = true;
        audioSource.Play();
    }


}
