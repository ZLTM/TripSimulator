using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class ControllerMovementHippie : MonoBehaviour
{
    private Animator anim;
    public float speed = 2.0f;
    public float rotationSpeed = 50f;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = CnInputManager.GetAxis("Vertical");
        float rotation = CnInputManager.GetAxis("Horizontal");

        translation *= Time.deltaTime * speed;
        rotation *= Time.deltaTime * rotationSpeed;

        transform.Translate(0, 0, translation);
        transform.Rotate(Vector3.up, rotation, 0);

        if (translation > 0)
        {
            anim.SetBool("isWalking", true);
            //AkSoundEngine.PostEvent("pisadas", gameObject); //activar para colocar el sonido de pisadas el parentesis se compone de ("EVENTO DE WISE", OBJETO)    
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

    }
}