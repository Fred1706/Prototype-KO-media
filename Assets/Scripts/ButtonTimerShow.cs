using UnityEngine;
using TMPro;
using System;

public class ButtonTimerShow : MonoBehaviour
{
    [SerializeField]
    private float time;

    [SerializeField]
    private TMP_Text _buttonTimeText;

    public void ShowTime()
    {
        float time = gameObject.GetComponent<ButtonTimer>()._timeLeft;

        if(time < 0)
        {
            time = 0;
        }

        //convertir la variable en temps en seconde
        TimeSpan ts = TimeSpan.FromSeconds(time);

        // 00:00:00:000 (heures, minutes, secondes, millisecondes)
        _buttonTimeText.text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
