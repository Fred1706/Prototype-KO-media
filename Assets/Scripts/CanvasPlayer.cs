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

    public TMP_Text Text1;

    public TMP_Text Text2;


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

        
        Text1.text = infosPlayer1.life.ToString();
        Text2.text = infosPlayer2.life.ToString();


        

    }



    public void DemarrerVie(){

        infosPlayer1.life = 5;


        infosPlayer2.life = 5;
    }
}
