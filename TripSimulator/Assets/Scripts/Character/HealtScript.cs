using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtScript : MonoBehaviour {

    public Transform Bar;
    public float max_healt = 100f;
    public float cur_healt = 0f;
    public bool active = false;
	void Start ()
    {
        cur_healt = max_healt;
        //decreaserIsActive(active);
        InvokeRepeating("decreaserIsActive", 0f, 2f);
    }
    void decreaserIsActive (bool active)
    {
        Debug.Log(active);
        if (active)
        {
            InvokeRepeating("decreaseHealt", 0f, 2f);
        }
    }
    void decreaseHealt()
    {
        cur_healt -= cur_healt / max_healt;
        float calc_healt = cur_healt / max_healt;
        setHealt(calc_healt);
    }
    void setHealt(float myHealt)
    {
        Bar.GetComponent<Image> ().fillAmount = myHealt;
    }
}
