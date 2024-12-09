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
    private VisualEffect vfxR;

    


  
    


    private void OnTriggerEnter(Collider other){

        VelocityTracker velocityTracker = XrOrigin.GetComponent<VelocityTracker>();
        
        GameObject vfxB = GameObject.Find("VFX_hit_2_blue");

        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
            audioManager.GetComponent<RandomSons>().Block();
            Debug.Log("joueur 2 a bloquer");
            //SetInvincible2();
        }

        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
           if(invincible2 == false){
                //audioManager.GetComponent<RandomSons>().Hit();
                //infoPlayer2.life --;
                // SetInvincible2();
                 //vfxB.GetComponent<VisualEffect>().Play();

                 
            }
            
           

            
        }





         //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
            audioManager.GetComponent<RandomSons>().Block();
            Debug.Log("joueur 2 a bloquer");
           // SetInvincible2();
        }

        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove1"){
            
            if(invincible2 == false){
                //audioManager.GetComponent<RandomSons>().Hit();
                //infoPlayer2.life --;

                //SetInvincible2();
                //vfxB.GetComponent<VisualEffect>().Play();
            }
            
            
        }






        //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove1" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove"){
            
            audioManager.GetComponent<RandomSons>().Block();
            Debug.Log("joueur 1 a bloquer");
           // SetInvincible1();
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player1" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove"){
            
           if(invincible1 == false){
                //audioManager.GetComponent<RandomSons>().Hit();
               // infoPlayer1.life --;

                //SetInvincible1();
                //vfxB.GetComponent<VisualEffect>().Play();
            }
            
            

           
        }





         //Vérifie la collision avec un gant.
        if(other.transform.tag == "Glove1" && velocityTracker.velocityr >= requiredVelocity && gameObject.transform.tag == "Glove"){
            
            audioManager.GetComponent<RandomSons>().Block();
            Debug.Log("joueur 1 a bloquer");
           // SetInvincible1();
        }
        //Vérifie la collision avec un joueur.
        else if(other.transform.tag == "Player1" && velocityTracker.velocityl >= requiredVelocity && gameObject.transform.tag == "Glove"){
            

            if(invincible1 == false){
                //audioManager.GetComponent<RandomSons>().Hit();
                //infoPlayer1.life --;

                //SetInvincible1();
                //vfxB.GetComponent<VisualEffect>().Play();
            }
            
            
           
        }




        if(other.transform.tag == "Glove1" && gameObject.transform.tag == "Glove" && time.ready == 0){

            
            time.ready = 2;
        }
        
    }


    private void SetInvincible1(){
        invincible1 = true;
        Debug.Log("invincible 1");
        Invoke("RemoveInvincible1", 2f);
    }

    private void SetInvincible2(){
        invincible2 = true;
        Debug.Log("invincible 2");
        Invoke("RemoveInvincible2", 2f);
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
