using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btSound : MonoBehaviour {

   
   public int valorBT = 100;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        

    }

    void OnTriggerEnter (Collider other)
    {
       
            if (other.gameObject.tag == "Player")
            {
                InvokeRepeating("AddOne", 1, 0.1f);
            }
        
    }

    void OnTriggerExit()
    {
        CancelInvoke();
    }

    void AddOne ()
    {
        
        if (valorBT > 0)
        {
            valorBT--;
            AkSoundEngine.SetRTPCValue("DistanciaMalTrip", valorBT);
        }
    }
}
