using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonTimer : MonoBehaviour
{

    private bool _timerActive = false;

    [SerializeField]
    private float _initialTime = 20f;
    public float _timeLeft = 0;

    public UnityEvent onTimeChange;

    public UnityEvent atTimeEnd;

    // Update is called once per frame
    void Update()
    {
        if(_timerActive)
        {
            if(_timeLeft > 0)
            {
                // On décrémente le temps
                _timeLeft -= Time.deltaTime;

                // on Envoie l'événement
                onTimeChange.Invoke();
            }
            else
            {
                _timeLeft = 0;
                _timerActive = false;

                // On envoie l'événement
                atTimeEnd.Invoke();
            }
        }
        
    }

    public void StartTimer()
    {
        //On réinitialise le temps
        _timeLeft = _initialTime;
        _timerActive = true;
    }
}
