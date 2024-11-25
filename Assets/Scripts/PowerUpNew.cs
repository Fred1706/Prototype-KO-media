using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpNew : MonoBehaviour
{
    public InfosPlayer infosPlayer1;
        public InfosPlayer infosPlayer2;

         public GameObject leftHand;
    public GameObject rightHand;
   
    void Update()
    {

        if(infosPlayer1.power == true || infosPlayer2.power == true){

            leftHand.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

            rightHand.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }



        
    }
}
