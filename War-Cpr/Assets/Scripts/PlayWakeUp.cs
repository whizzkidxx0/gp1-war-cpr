using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWakeUp : MonoBehaviour
{

    public AudioSource playWakeUp;
    public AudioSource stopHeartbeat;
    public GameObject injuredSoldier;
    public GameObject hintHand;
    public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayWakeUpSoundAndAnimation());
        StartCoroutine(StopHeartBeat());
        StartCoroutine(PlayHandAnimation());
    }

    IEnumerator PlayWakeUpSoundAndAnimation()
    {
        yield return new WaitForSeconds(3f);
        playWakeUp.Play();
        injuredSoldier.GetComponent<Animation>().Play("brokenBunker");
    }

    IEnumerator StopHeartBeat()
    {
        yield return new WaitForSeconds(7f);
        stopHeartbeat.Stop();

    }

    IEnumerator PlayHandAnimation()
    {
        yield return new WaitForSeconds(30);
        hintHand.SetActive(true);
        hintHand.GetComponent<Animation>().Play("NewHandAnim");
        cube.SetActive(true);
    }

}
