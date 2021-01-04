using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VisionFade : MonoBehaviour
{
    public GameObject volObj;
    public Volume v;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WakeAndBake());
    }


    IEnumerator WakeAndBake()
    {
        yield return new WaitForSeconds(1);
        volObj.SetActive(true);
        for (int i = 0; i < 3000; i++)
        {
            v.weight = .5f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .6f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .7f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .8f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .9f;
            yield return new WaitForSeconds(0.1f);
            v.weight = 1f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .9f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .8f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .7f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .6f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .5f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .4f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .5f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .6f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .7f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .8f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .9f;
            yield return new WaitForSeconds(0.1f);
            v.weight = 1f;
            yield return new WaitForSeconds(0.1f);
            v.weight = .9f;
            yield return new WaitForSeconds(0.1f);

        }

        v.weight = .8f;
        yield return new WaitForSeconds(0.1f);
        v.weight = .7f;
        yield return new WaitForSeconds(0.1f);

    }
}
