using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorWave : MonoBehaviour {
    private HealtScript healtPlayer;

    void OnTriggerEnter(Collider other)
    {
        if (other.isTrigger)
            return;

        if (other.gameObject.tag == "Player")
            Debug.Log("aquiiiii");
    }

}
