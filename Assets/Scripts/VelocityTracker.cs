using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class VelocityTracker : MonoBehaviour
{
    [SerializeField]
    private Transform leftController;
    [SerializeField]
    private Transform rightController;

    private Vector3 leftControllerDistance;
    private Vector3 leftControllerPosition;
    private Vector3 rightControllerDistance;
    private Vector3 rightControllerPosition;

    private Vector3 oldPos;

    void Start(){
        oldPos = new Vector3(0,0,0);
    }

    void FixedUpdate(){
        float velocity;
        leftControllerPosition = leftController.position;
        rightControllerPosition = rightController.position;
        Vector3 newpos = leftControllerPosition;
        Vector3 distance = ((newpos - oldPos) / Time.deltaTime);
        velocity = distance.magnitude;
        oldPos = newpos;

        Debug.Log(velocity);
    }

    
}
