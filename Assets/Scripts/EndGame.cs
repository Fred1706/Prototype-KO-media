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
 
    //public Texture[] sponsorTexture;
 
    //private int sponsorIndex = 1;
 
 
    private bool IsActive = true;
 
    [SerializeField]
    private GameObject audioManager;

    [SerializeField]
    private GameObject textureManager;


    public GameObject[] CoeursB;
    public GameObject[] CoeursR;

    public GameObject RenderBob;
    public GameObject VideoBob;

    public GameObject RenderJoe;
    public GameObject VideoJoe;

    public GameObject RenderDraw;
    public GameObject VideoDraw;
 
 
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
               
               RenderBob.SetActive(true);
               VideoBob.SetActive(true);
            }
 
            if(infosPlayer2.life <= 0){
                TextVictory.text = "Lil joe a gagné";

                RenderJoe.SetActive(true);
               VideoJoe.SetActive(true);
               
            }
 
            if(infosTime.Time <= 0){
 
 
                if(infosPlayer1.life > infosPlayer2.life){
                    TextVictory.text = "Lil joe a gagné";
                    TextVictoryJumbo.text = "Lil joe a gagné";

                    RenderJoe.SetActive(true);
                    VideoJoe.SetActive(true);
                }
               
                if(infosPlayer1.life < infosPlayer2.life){
                    TextVictory.text = "Bob a gagné";
                    TextVictoryJumbo.text = "Bob a gagné";

                     RenderBob.SetActive(true);
                    VideoBob.SetActive(true);
                }
 
                if(infosPlayer1.life == infosPlayer2.life){
                    TextVictory.text = "Égalité";
                    TextVictoryJumbo.text = "Égalité";

                     RenderDraw.SetActive(true);
                    VideoDraw.SetActive(true);
                }
 
               
            }
 
 
           
           
           
 
           
 
           
                if(IsActive == true){
                //Invoke("SponsorShow", 2.0f);
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
            infosPlayer2.diff = true;
            infosPlayer1.diff = true;
 
           
       
           
    }
 
 
 
 
    private void ResetGame(){
 
        
 
        //sponsorIndex = Random.Range(0, 5);
 
        infosTime.ready = 0;
 
        infosPlayer1.life = 5;
        infosPlayer2.life = 5;
        infosTime.Time = infosTime.StartTime;
 
        leftController.SetActive(true);
        rightController.SetActive(true);
 
        canvasStart.SetActive(true);
        canvasStart.GetComponent<RandomMusic>().music();
        textureManager.GetComponent<RandomTexture>().ChangerImage();
        Debug.Log("music");
        canvasEnd.SetActive(false);
       
        sponsorImage.SetActive(true);
        
        Invoke("ChangeActive", 1.0f);

        CoeursB[0].SetActive(true);
        CoeursB[1].SetActive(true);
        CoeursB[2].SetActive(true);
        CoeursB[3].SetActive(true);
        CoeursB[4].SetActive(true);


        CoeursR[0].SetActive(true);
        CoeursR[1].SetActive(true);
        CoeursR[2].SetActive(true);
        CoeursR[3].SetActive(true);
        CoeursR[4].SetActive(true);


        RenderBob.SetActive(false);
        VideoBob.SetActive(false);
        RenderJoe.SetActive(false);
        VideoJoe.SetActive(false);
        RenderDraw.SetActive(false);
        VideoDraw.SetActive(false);
    }
 
    //private void SponsorShow(){
     //   sponsorImage.GetComponent<RawImage>().texture = sponsorTexture[sponsorIndex];
    //    sponsorImage.SetActive(true);
    //}




    private void ChangeActive(){
        IsActive = true;
    }
}