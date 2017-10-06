using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodTrip : MonoBehaviour
{

    
    public int valorGT = 100;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject.tag == "Player")
            {
                InvokeRepeating("AddOne", 1, 0.1f);
            }
        
    }

    void OnTriggerExit ()
    {
        CancelInvoke();
    }

    void AddOne()
    {
       
        if (valorGT <= 100)
        {
            valorGT++;
            AkSoundEngine.SetRTPCValue("DistanciaMalTrip", valorGT);
        }
    }
}
