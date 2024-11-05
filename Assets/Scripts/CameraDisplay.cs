using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisplay : MonoBehaviour
{

    [SerializeField]
    private Camera camera2; 
    void Start(){
        camera2.targetDisplay = 1; 
        Display.displays[1].Activate();
    }
}
