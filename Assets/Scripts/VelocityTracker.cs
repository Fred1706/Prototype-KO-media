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

    private Vector3 oldPosl;
    private Vector3 oldPosr;

    public float velocityl;
    public float velocityr;

    //Initialise la vielle position
    void Start(){
        oldPosl = new Vector3(0,0,0);
        oldPosr = new Vector3(0,0,0);
    }

    void FixedUpdate(){
        //Prend la position des manettes
        leftControllerPosition = leftController.position;
        rightControllerPosition = rightController.position;
        //Prend la nouvelle position lors de l'update et update la variable
        Vector3 newposl = leftControllerPosition;
        Vector3 newposr = rightControllerPosition;
        //Compare les deux positions et le divise avec deltatime pour donner la velocité
        Vector3 distancel = ((newposl - oldPosl) / Time.deltaTime);
        velocityl = distancel.magnitude;

        Vector3 distancer = ((newposr - oldPosr) / Time.deltaTime);
        velocityr = distancer.magnitude;
        //Reset la vélocité
        oldPosr = newposr;

        oldPosl = newposl;

        
    }

    
}
