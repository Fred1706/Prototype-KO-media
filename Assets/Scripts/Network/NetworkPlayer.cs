using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayer : NetworkBehaviour
{

    public Transform root;
    public Transform head;
    public Transform leftHand;
    public Transform RightHand;

    public GameObject headTag;
    


    public Renderer[] meshToDisable;
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
        }
        else {
            headTag.tag = "Player1";
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

        

        
    }



    
}
