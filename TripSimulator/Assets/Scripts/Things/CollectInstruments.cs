using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectInstruments : MonoBehaviour
{
    public GameObject particle;

    void OnTriggerEnter(Collider other)
    {
        if (other.isTrigger)
            return;
        
        if (other.gameObject.tag == "Player")
            DestroyMe();
    }
    void DestroyMe()
    {
        Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
