using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasPlayer : MonoBehaviour
{

    public InfosPlayer infosPlayer1;
    public InfosPlayer infosPlayer2;


    public TMP_Text Player1Text;
    public TMP_Text Player2Text;


    // Start is called before the first frame update
    void Start()
    {
        DemarrerVie();
    }

    // Update is called once per frame
    void Update()
    {
        


        Player1Text.text = infosPlayer1.life.ToString();


        Player2Text.text = infosPlayer2.life.ToString();

        

    }



    public void DemarrerVie(){

        infosPlayer1.life = 5;


        infosPlayer2.life = 5;
    }
}
