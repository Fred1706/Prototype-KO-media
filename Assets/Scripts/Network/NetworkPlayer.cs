using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayer : NetworkBehaviour
{

    [SerializeField]
    private InfosPlayer infoPlayer1;

    [SerializeField]
    private InfosPlayer infoPlayer2;

    public Transform root;
    public Transform head;
    public Transform leftHand;
    public Transform RightHand;
    

    public GameObject headTag;
    public GameObject leftHandTag;
    public GameObject rightHandTag;
    


    public GameObject headplayer1;
    public GameObject rightHandPlayer1;
    public GameObject leftHandPlayer1;


    public GameObject headplayer2;
    public GameObject rightHandPlayer2;
    public GameObject leftHandPlayer2;
    

    


    public Renderer[] meshToDisable;

    public GameObject[] headAppear;
    // Start is called before the first frame update

    public override void OnNetworkSpawn(){

         if(IsOwner){
            
            foreach(var item in meshToDisable)
            {
            item.enabled = false;
            }
        }



        if(!IsHost && IsOwner){



            headTag.tag = "Player";
            leftHandTag.tag = "Glove";
            rightHandTag.tag = "Glove";

            headplayer1.SetActive(false);
            leftHandPlayer1.SetActive(false);
            rightHandPlayer1.SetActive(false);

            headplayer2.layer = 3;
            
            
        }
        else if(!IsHost && !IsOwner){
            headplayer2.SetActive(false);
            leftHandPlayer2.SetActive(false);
            rightHandPlayer2.SetActive(false);
            headplayer1.layer = 6;

             foreach(var item in headAppear)
            {
            item.layer = 6;
            }
        }





        if(IsHost && IsOwner){
            headTag.tag = "Player1";
            leftHandTag.tag = "Glove1";
            rightHandTag.tag = "Glove1";

            headplayer2.SetActive(false);
            leftHandPlayer2.SetActive(false);
            rightHandPlayer2.SetActive(false);
            headplayer1.layer = 3;
        }
        
        else if(IsHost && !IsOwner){


            headplayer1.SetActive(false);
            leftHandPlayer1.SetActive(false);
            rightHandPlayer1.SetActive(false);
            headplayer2.layer = 6;
        }


       
    }
  

    // Update is called once per frame
    void Update()
    {
        if(IsOwner){


        
        root.position = RigReferences.Singleton.root.position;
        root.rotation = RigReferences.Singleton.root.rotation;

        head.position = RigReferences.Singleton.head.position;
        head.rotation = RigReferences.Singleton.head.rotation;


        leftHand.position = RigReferences.Singleton.leftHand.position;
        leftHand.rotation = RigReferences.Singleton.leftHand.rotation;
        

        RightHand.position = RigReferences.Singleton.RightHand.position;
        RightHand.rotation = RigReferences.Singleton.RightHand.rotation;
       
       
        

        }



        if(infoPlayer1.power == true && rightHandTag.tag == "Glove1" && IsHost && IsOwner){
            Debug.Log("JOUER GROS");
            leftHand.localScale =  RigReferences.Singleton.leftHand.localScale;
            RightHand.localScale = RigReferences.Singleton.RightHand.localScale;
        }





        if(infoPlayer2.power == true && rightHandTag.tag == "Glove" && !IsHost && IsOwner){

           Debug.Log("JOUER2 GROS");
            leftHand.localScale = RigReferences.Singleton.leftHand.localScale;
            RightHand.localScale = RigReferences.Singleton.RightHand.localScale;
        }

        

        
    }



    



    
}
