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

    public float velocity;

    //Initialise la vielle position
    void Start(){
        oldPos = new Vector3(0,0,0);
    }

    void FixedUpdate(){
        //Prend la position des manettes
        leftControllerPosition = leftController.position;
        rightControllerPosition = rightController.position;
        //Prend la nouvelle position lors de l'update et update la variable
        Vector3 newpos = leftControllerPosition;
        //Compare les deux positions et le divise avec deltatime pour donner la velocité
        Vector3 distance = ((newpos - oldPos) / Time.deltaTime);
        velocity = distance.magnitude;
        //Reset la vélocité
        oldPos = newpos;

        //Debug.Log(velocity);
    }

    
}
