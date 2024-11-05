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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(infosTime.ready == 2)
        {

            StartFight();

        }
    }


    private void StartFight(){

        canvasPlayer.SetActive(true);

        canvasStart.SetActive(false);

        infosTime.Time = infosTime.StartTime; 
        infosPlayer1.life = 5;
        infosPlayer2.life = 5;
        infosTime.ready = 0;

        Debug.Log("grtegre");
    }


   

}
