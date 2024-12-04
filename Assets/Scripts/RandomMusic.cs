using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RandomMusic : MonoBehaviour
 
 
{
    public AudioSource audioSource;
    [SerializeField]  private AudioClip[] musique;
 
    private AudioClip activeSound;
    // Start is called before the first frame update
    void Start()
    {
        music();
       
    }
 
    // Update is called once per frame
    void Update()
    {
       
    }
 
public void music(){
    activeSound = musique[Random.Range(0,musique.Length)];
        audioSource.PlayOneShot(activeSound);
}
 
   
}
 