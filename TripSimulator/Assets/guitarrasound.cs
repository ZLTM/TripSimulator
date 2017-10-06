using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guitarrasound : AudioMaster
{

    public int valor = 80;
    // Use this for initialization
    void awake()
    {
       AkSoundEngine.SetRTPCValue("DistanciaGuit", 80);
    }

    void Start()
    {
        
        valor = 80;
    }

    // Update is called once per frame
    void Update()
    {
        AkSoundEngine.SetRTPCValue("DistanciaGuit", valor);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            valor = 0;

        }
    }
}
