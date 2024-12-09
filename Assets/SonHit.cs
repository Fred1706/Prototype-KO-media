using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonHit : MonoBehaviour
{

    public GameObject AudioManager;
    

    [SerializeField]
    private InfosPlayer infoPlayer1;

    [SerializeField]
    private InfosPlayer infoPlayer2;

     private float currentValue1;
     private float currentValue2;

    void Start()
    {
       

        currentValue1 = infoPlayer1.life;

        currentValue2 = infoPlayer2.life;






    }

    

    // Update is called once per frame
    void Update()
    {
        if(infoPlayer1.life == currentValue1 - 1){

            AudioManager.GetComponent<RandomSons>().Hit();
            currentValue1 = infoPlayer1.life;
        }



        if(infoPlayer2.life == currentValue2 - 1){

            AudioManager.GetComponent<RandomSons>().Hit();
            currentValue2 = infoPlayer2.life;
        }




        if(infoPlayer1.life == 0 || infoPlayer2.life == 0){

            currentValue2 = infoPlayer2.life;
            currentValue1 = infoPlayer1.life;
            
        }

    }
}
