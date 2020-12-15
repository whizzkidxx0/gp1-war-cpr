using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeHeartBeat : MonoBehaviour
{
    public AudioSource heartbeat;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DimVolume());
    }

    IEnumerator DimVolume()
    {
        yield return new WaitForSeconds(4f);
        heartbeat.volume = .2f;
        yield return new WaitForSeconds(2f);
        heartbeat.volume = .09f;

    }
}
