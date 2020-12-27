using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWakeUp : MonoBehaviour
{

    public AudioSource playWakeUp;
    public AudioSource stopHeartbeat;
    public GameObject injuredSoldier;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayWakeUpSoundAndAnimation());
        StartCoroutine(StopHeartBeat());

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

}
