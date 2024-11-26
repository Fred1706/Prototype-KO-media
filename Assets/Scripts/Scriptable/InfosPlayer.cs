using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosPlayer", menuName = "SO/NewPlayer")]
public class InfosPlayer : ScriptableObject
{
    

    [Header("Points du joueur")]
    public int life;

    public bool power;
    public bool powerLocal;

   

    private void OnEnable()
    {
        
        life = 5;
        power = false;
        powerLocal = false;
    }
}