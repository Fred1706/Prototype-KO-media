using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
 
public class RandomTexture : MonoBehaviour
 
 
{
    [SerializeField] private Texture[] images;
    [SerializeField] private GameObject imageUI;
    private Texture activeImage;
 
   
 
 
    public void ChangerImage(){
    activeImage = images[Random.Range(0, images.Length)];
    imageUI.GetComponent<RawImage>().texture = activeImage;
    }
    // Start is called before the first frame update
 
 
}
 