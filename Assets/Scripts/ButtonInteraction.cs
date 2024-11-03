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
    private GameObject _buttonPlayerWinObject;
    [SerializeField]
    private TMP_Text _buttonPlayerWinText;
    [SerializeField]
    private InfosPlayer _player1;
    [SerializeField]
    private InfosPlayer _player2;

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
    private void OnStartTimer(){
        player1Score = 0;
        player2Score = 0;
        _buttonPlayerWinObject.SetActive(false);
        gameObject.GetComponent<ButtonTimer>().StartTimer();
    }
    public void CompareScore(){
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
        _powerUpManager.GetComponent<PowerUpManager>().PowerUpSelection();
    }

}
