using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasPlayer : MonoBehaviour
{

    public InfosPlayer infosPlayer1;
    public InfosPlayer infosPlayer2;


    public GameObject[] CoeursB;
    public GameObject[] CoeursR;


    // Start is called before the first frame update
    void Start()
    {
        DemarrerVie();
    }

    // Update is called once per frame
    void Update()
    {
        
        CoeursB[infosPlayer2.life].SetActive(false);

        CoeursR[infosPlayer1.life].SetActive(false);

        

        

    }



    public void DemarrerVie(){

        infosPlayer1.life = 5;


        infosPlayer2.life = 5;
    }
}
