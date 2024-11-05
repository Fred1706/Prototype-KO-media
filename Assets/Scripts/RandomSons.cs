using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSons : MonoBehaviour
{
     public AudioSource audioSource;
    [SerializeField]  private AudioClip[] sonsHit;
    [SerializeField]  private AudioClip[] sonsBlock;
    
    

     private AudioClip activeSound;
    // Start is called before the first frame update
    

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.UpArrow))
    //     {
    //         Hit();
    //         Debug.Log("bon");
    //     }
    //     if (Input.GetKeyDown(KeyCode.DownArrow))
    //     {
    //         Block();
            
    //     }
    // }

    public void Hit(){
       activeSound = sonsHit[Random.Range(0, sonsHit.Length)];
        audioSource.PlayOneShot(activeSound);

    }
    public void Block(){
       activeSound = sonsBlock[Random.Range(0, sonsBlock.Length)];
        audioSource.PlayOneShot(activeSound);

    }
}
