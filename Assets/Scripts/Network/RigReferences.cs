using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigReferences : MonoBehaviour
{

    public static RigReferences Singleton;

    public Transform root;
    public Transform head;
    public Transform leftHand;
    public Transform RightHand;

   /// <summary>
   /// Awake is called when the script instance is being loaded.
   /// </summary>
   private void Awake()
   {
        Singleton = this;
   }
}
