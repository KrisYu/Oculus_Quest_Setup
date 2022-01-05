using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public GameObject balloonPrefab;
    private GameObject balloon;


    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A button Pressed");
            NewBalloon();
        }
    }

    private void NewBalloon()
    {
        Debug.Log( OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch) );
        Debug.Log( OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch) );
        Vector3 location = OVRInput.GetLocalControllerPosition( OVRInput.Controller.RTouch );
        Quaternion rotation = OVRInput.GetLocalControllerRotation( OVRInput.Controller.RTouch) ;
        balloon = Instantiate(balloonPrefab, location, rotation);
        balloon.GetComponent<MeshRenderer>().material.SetColor("_Color", UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
    }
}
