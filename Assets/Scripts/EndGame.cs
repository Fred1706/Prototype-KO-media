using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class EndGame : MonoBehaviour
{
   
    public InfosPlayer infosPlayer1;
    public InfosPlayer infosPlayer2;
 
    public InfosTime infosTime;
 
    public GameObject canvasEnd;
 
    public GameObject canvasStart;
 
    public GameObject canvasPlayer;
 
    public GameObject leftController;
 
    public GameObject rightController;
 
    public GameObject CanvasEndJumbotron;
 
    public GameObject sponsorImage;
 
    public GameObject jumbotron;
 
    public TMP_Text TextVictory;
    public TMP_Text TextVictoryJumbo;
 
    public Texture[] sponsorTexture;
 
    private int sponsorIndex = 1;
 
 
    private bool IsActive = true;
 
 
 
 
 
 
   
 
    [SerializeField]
    private GameObject audioManager;
 
 
    // Start is called before the first frame update
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void Update()
    {
        if(infosPlayer1.life <= 0 || infosPlayer2.life <= 0 || infosTime.Time <= 0){
            verifyVictory();
        }
       
 
    }
 
 
 
    public void verifyVictory(){
 
       
 
 
        CanvasEndJumbotron.SetActive(true);
 
            if(infosPlayer1.life <= 0){
                TextVictory.text = "Bob a gagné";
               
            }
 
            if(infosPlayer2.life <= 0){
                TextVictory.text = "Lil joe a gagné";
               
            }
 
            if(infosTime.Time <= 0){
 
 
                if(infosPlayer1.life > infosPlayer2.life){
                    TextVictory.text = "Lil joe a gagné";
                    TextVictoryJumbo.text = "Lil joe a gagné";
                }
               
                if(infosPlayer1.life < infosPlayer2.life){
                    TextVictory.text = "Bob a gagné";
                    TextVictoryJumbo.text = "Bob a gagné";
                }
 
                if(infosPlayer1.life == infosPlayer2.life){
                    TextVictory.text = "Égalité";
                    TextVictoryJumbo.text = "Égalité";
                }
 
               
            }
 
 
           
           
           
 
           
 
           
                if(IsActive == true){
                Invoke("SponsorShow", 2.0f);
                Invoke("ResetGame", 7.0f);
                Debug.Log("reset");
                IsActive = false;
                }
               
               
           
           
           
            canvasEnd.SetActive(true);
            canvasPlayer.SetActive(false);
            jumbotron.SetActive(false);
            leftController.SetActive(false);
            rightController.SetActive(false);
            CanvasEndJumbotron.SetActive(false);
            sponsorImage.SetActive(false);
 
           
       
           
    }
 
 
 
 
    private void ResetGame(){
 
        IsActive = true;
 
        sponsorIndex = Random.Range(0, 5);
 
        infosTime.ready = 0;
 
        infosPlayer1.life = 5;
        infosPlayer2.life = 5;
        infosTime.Time = infosTime.StartTime;
 
        leftController.SetActive(true);
        rightController.SetActive(true);
 
        canvasStart.SetActive(true);
        canvasStart.GetComponent<RandomMusic>().music();
        Debug.Log("music");
        canvasEnd.SetActive(false);
       
 
    }
 
    private void SponsorShow(){
        sponsorImage.GetComponent<RawImage>().texture = sponsorTexture[sponsorIndex];
        sponsorImage.SetActive(true);
    }
}