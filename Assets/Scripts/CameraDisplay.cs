using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisplay : MonoBehaviour
{
    [SerializeField]
    private GameObject camera1; 
    [SerializeField]
    private GameObject camera2; 
    public void DisplayCamera1(){
        camera2.SetActive(false);
        camera1.SetActive(true);
        
    }
    public void DisplayCamera2(){
        camera1.SetActive(false);
        camera2.SetActive(true);
        
    }
}
