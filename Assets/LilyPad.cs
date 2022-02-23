using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyPad : MonoBehaviour
{
    bool movePad;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Transform newTransform = other.transform.root;
            newTransform.parent = this.transform;
            movePad = true;
            // move platform

        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Transform newTransform = other.transform.root;
            newTransform.parent = null;
        }
    }


    void Update()
    {
        if(movePad)
        transform.position = Vector3.Lerp(transform.position, this.transform.position + new Vector3(-10, 0, 0), 1 * Time.deltaTime);
    }
}
