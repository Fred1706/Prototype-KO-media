using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerUpdate : MonoBehaviour
{

    
    public InfosTime infosTime;
    private bool TimerOn = false;

    

    
    public TMP_Text TimeText;


    
    // Start is called before the first frame update
    void Start()
    {
        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn == true)
        {
            if (infosTime.Time >= 0)
            {
                infosTime.Time -= Time.deltaTime;

               

               
            }
            else
            {
                infosTime.Time = 0;
                TimerOn = false;

                
                 
                
            }
        }


        float _Time = infosTime.Time;

        if (_Time < 0)
        {
            _Time = 0;
        }

        TimeSpan ts = TimeSpan.FromSeconds(_Time);

        //00:00:00:000
        TimeText.text = string.Format("{0:00}:{1:00}",ts.Minutes, ts.Seconds);
    }


    public void DemarrerDecompte()
    {

        infosTime.Time = infosTime.StartTime;

        TimerOn = true;

        
    }



}