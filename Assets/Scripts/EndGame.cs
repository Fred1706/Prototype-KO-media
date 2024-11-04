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

    public GameObject leftController; 

    public GameObject rightController; 




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(infosPlayer1.life == 0 || infosPlayer2.life == 0 || infosTime.Time == 0){
            verifyVictory();
        }
       

    }



    public void verifyVictory(){

         
            Debug.Log("partie terminer");

            infosTime.Time = infosTime.StartTime;
            infosPlayer1.life = 5;
            infosPlayer2.life = 5;

            Invoke("ResetGame", 5.0f);

            canvasEnd.SetActive(true);
            leftController.SetActive(false);
            rightController.SetActive(false);
       

    }




    private void ResetGame(){

        infosTime.ready = 0;



        leftController.SetActive(true);
        rightController.SetActive(true);

        canvasStart.SetActive(true);
        canvasEnd.SetActive(false);

    }
}
