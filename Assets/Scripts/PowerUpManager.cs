using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField]
    private InfosPlayer _player1;
    [SerializeField]
    private InfosPlayer _player2;
    [SerializeField]
    private GameObject _player1Body;
    [SerializeField]
    private float powerUpTime = 10f;
    [SerializeField]
    private float powerUpSize = 1.5f;
    private int _playerIndex;
    public void PowerUpSelection(){
        if(_player1.power == true){
            _playerIndex = 1;
        }
        else if(_player2.power == true){
            _playerIndex = 2;
        }
        else{
            Debug.Log("No Power up");
        }
        PowerUpLarge();
    }
    
    private void PowerUpLarge(){

        //Les switch cases fonctionnent comme des if, on verifie c'est quoi la valeur du player index et selon sa valeur on execute le code.
        switch (_playerIndex)
        {
            case 1:
                Debug.Log("Power up large P1.");

                GameObject leftHand = _player1Body.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
                leftHand.transform.localScale = new Vector3(powerUpSize, powerUpSize, powerUpSize);
                GameObject rightHand = _player1Body.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject;
                rightHand.transform.localScale = new Vector3(powerUpSize, powerUpSize, powerUpSize);

                StartCoroutine(PowerUpFinish(powerUpTime));

                IEnumerator PowerUpFinish(float powerUpTime)
                {
                //Wait for the specified delay time before continuing.
                yield return new WaitForSeconds(powerUpTime);

                //Do the action after the delay time has finished.
                _player1.power = false;
                _playerIndex = 0;

                rightHand.transform.localScale = new Vector3(1f, 1f, 1f);
                leftHand.transform.localScale = new Vector3(1f, 1f, 1f);

                Debug.Log("PowerUp finished.");
                }
                
            break;
            case 2:
                Debug.Log("Power up large P2.");
                _player2.power = false;
                _playerIndex = 0;
            break;
        }
    }
}