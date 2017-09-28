using UnityEngine;
using System.Collections;

public class TransformRotate : MonoBehaviour
{
    public float rotateSpeed = 120;

    void Update()
    {
        if (!this.enabled)
            return;

        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
    }
}
