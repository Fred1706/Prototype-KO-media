using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

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


    private bool invincible1 = false;
    private bool invincible2 = false;


    [SerializeField]
    private VisualEffect vfxB;

    [SerializeField]
    private VisualEffect vfxR;


    
    


    private void OnTriggerEnter(Collider other){

        VelocityTracker velocityTracker = XrOrigin.GetComponent<VelocityTracker>();
        


        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityr >= requiredVelocity){
            
            audioManager.GetComponent<RandomSons>().Block();
        }

        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
           if(invincible2 == false){
                audioManager.GetComponent<RandomSons>().Hit();
                infoPlayer2.life --;
                 SetInvincible2();
                 vfxB.Play();
            }
            
           

            
        }





         //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityl >= requiredVelocity ){
            
            audioManager.GetComponent<RandomSons>().Block();
        }

        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
            if(invincible2 == false){
                audioManager.GetComponent<RandomSons>().Hit();
                infoPlayer2.life --;

                SetInvincible2();
                vfxB.Play();
            }
            
            
        }






        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityr >= requiredVelocity){
            
            audioManager.GetComponent<RandomSons>().Block();
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player1" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove"){
            
           if(invincible1 == false){
                audioManager.GetComponent<RandomSons>().Hit();
                infoPlayer1.life --;

                SetInvincible1();
                vfxR.Play();
            }
            
            

           
        }





         //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityl >= requiredVelocity){
            
            audioManager.GetComponent<RandomSons>().Block();
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player1" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove"){
            

            if(invincible1 == false){
                audioManager.GetComponent<RandomSons>().Hit();
                infoPlayer1.life --;

                SetInvincible1();
                vfxR.Play();
            }
            
            
           
        }




        if(other.transform.tag == "Glove1" && gameObject.transform.tag == "Glove" && time.ready == 0){

            
            time.ready = 2;
        }
        
    }


    private void SetInvincible1(){
        invincible1 = true;
        Debug.Log("invincible 1");
        Invoke("RemoveInvincible1", 4f);
    }

    private void SetInvincible2(){
        invincible2 = true;
        Debug.Log("invincible 2");
        Invoke("RemoveInvincible2", 4f);
    }

    private void RemoveInvincible1(){
        invincible1 = false;
        Debug.Log("pu invincible 1");
    }

    private void RemoveInvincible2(){
        invincible2 = false;
        Debug.Log("pu invincible 2");
    }

}
