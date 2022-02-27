using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class LilyPad : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    private float distanceTravelled;
    public bool movePad;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Transform newTransform = other.transform.root;
            newTransform.parent = this.transform;
            movePad = true;
        }
    }

    // void OnTriggerExit(Collider other)
    // {
    //     if(other.CompareTag("Player"))
    //     {
    //         Transform newTransform = other.transform.root;
    //         newTransform.parent = null;
    //     }
    // }


    void Update()
    {
        if(movePad)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        }
    }
}
