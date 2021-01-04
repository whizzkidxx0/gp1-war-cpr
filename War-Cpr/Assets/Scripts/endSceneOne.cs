using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSceneOne : MonoBehaviour
{
    public GameObject anim;
    public AudioSource flauwvallen;
    public GameObject explosionParticle;
    public GameObject explosionParticle2;
    public GameObject explosionParticle3;
    public GameObject explosionParticle4;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(eindScene());
        StartCoroutine(disableParticles());

    }


    IEnumerator eindScene()
    {
        yield return new WaitForSeconds(64.5f);
        anim.SetActive(true);
        flauwvallen.Play();
    }

    IEnumerator disableParticles()
    {
        yield return new WaitForSeconds(66);
        explosionParticle.SetActive(false);
        yield return new WaitForSeconds(.5f);
        explosionParticle2.SetActive(false);
        yield return new WaitForSeconds(.5f);
        explosionParticle3.SetActive(false);
        explosionParticle4.SetActive(false);

    }

}
