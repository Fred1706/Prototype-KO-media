using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "InfosTime", menuName = "SO/NewTimer")]
public class InfosTime : ScriptableObject
{

    public float Time;
    public float StartTime;

    public int ready;


    private void OnEnable()
    {
        
       ready = 0;
    }
    

}