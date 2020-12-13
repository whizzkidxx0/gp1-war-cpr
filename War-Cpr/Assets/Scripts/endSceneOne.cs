using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSceneOne : MonoBehaviour
{
    public GameObject anim;
    public AudioSource flauwvallen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(eindScene());
    }

  
    IEnumerator eindScene()
    {
        yield return new WaitForSeconds(65);
        anim.SetActive(true);
        flauwvallen.Play();
    }

}
