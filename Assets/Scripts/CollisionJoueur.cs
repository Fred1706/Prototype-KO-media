using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    // --Test velocity
    // private Rigidbody rb;
    // private float speed;

    // void Start(){
    //     rb = GetComponent<Rigidbody>();
        
    // }
    

    // void Update(){
    //     speed = rb.velocity.magnitude;
    //     Debug.Log(speed);
    //     // if(speed == 1.0f){
    //     //     Debug.Log("Speed Test");
    //     // }
    // }
    private void OnTriggerEnter(Collider other){
        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove"){
            Debug.Log("Blocked");
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player"){
            Debug.Log("Hit");
        }
        
    }

}
