using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    
    public InfosPlayer infosPlayer1;
    public InfosPlayer infosPlayer2;

    public InfosTime infosTime;

    public GameObject canvasEnd; 

    public GameObject canvasStart; 

    public GameObject canvasPlayer; 

    public GameObject leftController; 

    public GameObject rightController; 

    public GameObject sponsorImage;

    public GameObject jumbotron;

    public TMP_Text TextVictory;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(infosPlayer1.life <= 0 || infosPlayer2.life <= 0 || infosTime.Time <= 0){
            verifyVictory();
        }
       

    }



    public void verifyVictory(){

            if(infosPlayer1.life <= 0){
                TextVictory.text = "Le joueur 2 à gagné";
            }

            if(infosPlayer2.life <= 0){
                TextVictory.text = "Le joueur 1 à gagné";
            }

            if(infosTime.Time <= 0){


                if(infosPlayer1.life > infosPlayer2.life){
                    TextVictory.text = "Joueur 1 à gagné";
                }
                
                if(infosPlayer1.life < infosPlayer2.life){
                    TextVictory.text = "Joueur 2 à gagné";
                }

                if(infosPlayer1.life == infosPlayer2.life){
                    TextVictory.text = "Égalité";
                }

                
            }

         
            

            infosTime.Time = infosTime.StartTime;
            

            Invoke("ResetGame", 7.0f);

            canvasEnd.SetActive(true);
            canvasPlayer.SetActive(false);
            jumbotron.SetActive(false);
            leftController.SetActive(false);
            rightController.SetActive(false);
            sponsorImage.SetActive(true);

    }




    private void ResetGame(){

        infosTime.ready = 0;

        infosPlayer1.life = 5;
        infosPlayer2.life = 5;

        leftController.SetActive(true);
        rightController.SetActive(true);

        canvasStart.SetActive(true);
        canvasEnd.SetActive(false);
        

    }
}
