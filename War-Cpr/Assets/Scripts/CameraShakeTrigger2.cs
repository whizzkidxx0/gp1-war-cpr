using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger2 : MonoBehaviour
{
    public CameraShake cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(camShake());
    }


    IEnumerator camShake()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(cameraShake.Shake(2.5f, .7f));
    }
}
