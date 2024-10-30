using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    [SerializeField]
    private GameObject XrOrigin;
    [SerializeField]
    private float requiredVelocity = 3;
    private void OnTriggerEnter(Collider other){

        VelocityTracker velocityTracker = XrOrigin.GetComponent<VelocityTracker>();

        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityr >= requiredVelocity){
            Debug.Log("Blocked");
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityr >= requiredVelocity){
            Debug.Log("Hit");
        }
        
    }

}
