using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumbotronConfettis : MonoBehaviour
{
    [SerializeField]
    private Transform redConfettiSpawn;

    [SerializeField]
    private Transform blueConfettiSpawn;
    
    [SerializeField]
    private GameObject redConfetti;
    
    [SerializeField]
    private GameObject blueConfetti;

    private List<GameObject> confettiObjects = new List<GameObject>();

    void Update()
    {
        btnCheck();
    }

    private void btnCheck()
    {
        if(Input.GetKeyDown(KeyCode.Z)) 
        {
            SpawnConfetti(redConfetti, redConfettiSpawn);
        }

        if(Input.GetKeyDown(KeyCode.X)) 
        {
            SpawnConfetti(blueConfetti, blueConfettiSpawn);
        }
    }

    private void SpawnConfetti(GameObject confettiPrefab, Transform confettiSpawn)
    {
        GameObject newConfetti = Instantiate(confettiPrefab, confettiSpawn.position, confettiSpawn.rotation);
        newConfetti.GetComponent<ParticleSystem>().Play();
        confettiObjects.Add(newConfetti);
        StartCoroutine(DestroyConfettiAfterPlay(newConfetti));
    }

    private IEnumerator DestroyConfettiAfterPlay(GameObject confetti)
    {
        ParticleSystem confettiPS = confetti.GetComponent<ParticleSystem>();

        if (confettiPS != null)
        {
            yield return new WaitForSeconds(confettiPS.main.duration + confettiPS.main.startLifetime.constantMax);
        }

        confettiObjects.Remove(confetti);
        Destroy(confetti);
    }
}
