using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject canvasStart;

    public GameObject canvasPlayer;

    public InfosTime infosTime;
    public InfosPlayer infosPlayer1;
    public InfosPlayer infosPlayer2;

    public GameObject buttonManager;

    public GameObject sponsorImage;

    public GameObject jumbotron;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(infosTime.ready == 2)
        {

            Invoke("StartFight", 0.5f);

        }
    }


    private void StartFight(){

        canvasPlayer.SetActive(true);
        jumbotron.SetActive(true);

        canvasStart.SetActive(false);
        sponsorImage.SetActive(false);

        infosTime.Time = infosTime.StartTime; 
        infosPlayer1.life = 5;
        infosPlayer2.life = 5;
        infosTime.ready = 1;

        

    }


   

}
