using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJoueur : MonoBehaviour
{
    [SerializeField]
    private GameObject XrOrigin;

    [SerializeField]
    private float requiredVelocity = 3;

    [SerializeField]
    private GameObject audioManager;
     
    [SerializeField]
    private InfosPlayer infoPlayer1;

    [SerializeField]
    private InfosPlayer infoPlayer2;

     [SerializeField]
    private InfosTime time;


    
    


    private void OnTriggerEnter(Collider other){

        VelocityTracker velocityTracker = XrOrigin.GetComponent<VelocityTracker>();
        


        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityr >= requiredVelocity){
            Debug.Log("Blocked");
            audioManager.GetComponent<RandomSons>().Block();
        }

        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
            audioManager.GetComponent<RandomSons>().Hit();
            infoPlayer2.life --;

            
        }





         //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityl >= requiredVelocity ){
            Debug.Log("Blocked");
            audioManager.GetComponent<RandomSons>().Block();
        }

        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
            audioManager.GetComponent<RandomSons>().Hit();
            infoPlayer2.life --;

           
        }






        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityr >= requiredVelocity){
            Debug.Log("Blocked");
            audioManager.GetComponent<RandomSons>().Block();
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player1" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove"){
            
            audioManager.GetComponent<RandomSons>().Hit();
            infoPlayer1.life --;

           
        }





         //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityl >= requiredVelocity){
            Debug.Log("Blocked");
            audioManager.GetComponent<RandomSons>().Block();
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player1" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove"){
            
            audioManager.GetComponent<RandomSons>().Hit();
            infoPlayer1.life --;

           
        }




        if(other.transform.tag == "Glove1" && gameObject.transform.tag == "Glove" && time.ready == 0){

            
            time.ready = 2;
        }
        
    }

}
