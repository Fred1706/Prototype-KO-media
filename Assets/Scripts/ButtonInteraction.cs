using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInteraction : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;
    [SerializeField]
    private GameObject _powerUpManager;
    [SerializeField]
    private float buttonTime = 5f;
    [SerializeField]
    private GameObject _buttonPlayerWinObject;
    [SerializeField]
    private GameObject _buttonWaitObject;
    [SerializeField]
    private GameObject _buttonGoObject;
    [SerializeField]
    private GameObject _buttonTimerUI;
    [SerializeField]
    private TMP_Text _buttonPlayerWinText;
    [SerializeField]
    private InfosPlayer _player1;
    [SerializeField]
    private InfosPlayer _player2;
    public InfosTime infosTime;
    [SerializeField]
    private float timeUntilStart = 90f;


    public PowerUpManager power;

    void Update(){
        if(timeUntilStart - 1 <= infosTime.Time && infosTime.Time <= timeUntilStart){
            StartTimer();
        }
    }

    private void OnPressP1()
    {
        player1Score++;
        Debug.Log("Player 1 : " + player1Score);
    }
    private void OnPressP2()
    {
        player2Score++;
        Debug.Log("Player 2 : " + player2Score);
    }
    public void StartTimer(){
        _buttonWaitObject.SetActive(true);
        StartCoroutine(ButtonTimerWait(buttonTime));

            IEnumerator ButtonTimerWait(float buttonTime)
            {
            //Wait for the specified delay time before continuing.
            yield return new WaitForSeconds(buttonTime);
            _buttonGoObject.SetActive(true);
            _buttonWaitObject.SetActive(false);
            _buttonTimerUI.SetActive(true);
            player1Score = 0;
            player2Score = 0;
            _buttonPlayerWinObject.SetActive(false);
            gameObject.GetComponent<ButtonTimer>().StartTimer();
            }
        
    }
    public void CompareScore(){

        power.PowerUpLarge();



        if(player1Score > player2Score){
            Debug.Log("Player 1 wins!");
            _buttonPlayerWinObject.SetActive(true);
            _player1.power = true;
            _buttonPlayerWinText.text = "Player 1 Wins!";
        }
        else if(player1Score < player2Score){
            Debug.Log("Player 2 wins!");
            _buttonPlayerWinObject.SetActive(true);
            _player2.power = true;
            _buttonPlayerWinText.text = "Player 2 Wins!";
        }
        else{
            Debug.Log("Draw!");
            _buttonPlayerWinObject.SetActive(true);
            _buttonPlayerWinText.text = "Draw!";
        }
        _buttonGoObject.SetActive(false);
        StartCoroutine(ScoreTimerWait(buttonTime));

            IEnumerator ScoreTimerWait(float buttonTime)
            {
            //Wait for the specified delay time before continuing.
            yield return new WaitForSeconds(buttonTime);
            _buttonPlayerWinObject.SetActive(false);
            _buttonTimerUI.SetActive(false);
            }
        _powerUpManager.GetComponent<PowerUpManager>().PowerUpSelection();
    }

}
