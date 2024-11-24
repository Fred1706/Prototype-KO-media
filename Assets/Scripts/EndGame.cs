using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

         
            Debug.Log("partie terminer");

            infosTime.Time = infosTime.StartTime;
            

            Invoke("ResetGame", 5.0f);

            canvasEnd.SetActive(true);
            canvasPlayer.SetActive(false);
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
