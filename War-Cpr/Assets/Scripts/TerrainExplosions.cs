using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainExplosions : MonoBehaviour
{

    public GameObject explosionParticle;
    public GameObject explosionParticle2;
    public GameObject explosionParticle3;
    public GameObject explosionParticle4;
    public GameObject explosionParticle5;
    public GameObject explosionParticle6;
    public GameObject explosionParticle7;
    public GameObject explosionParticle8;
    public GameObject explosionParticle9;
    public GameObject explosionParticle10;
    public GameObject explosionParticle11;
    public GameObject explosionParticle12;
    public GameObject explosionParticle13;
    public GameObject explosionParticle14;
    public GameObject explosionParticle15;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayExplosions());
    }


    IEnumerator PlayExplosions()
    {
        yield return new WaitForSeconds(50);
        explosionParticle.SetActive(true);
        yield return new WaitForSeconds(.5f);
        explosionParticle2.SetActive(true);
        yield return new WaitForSeconds(.5f);
        explosionParticle3.SetActive(true);
        yield return new WaitForSeconds(.5f);
        explosionParticle4.SetActive(true);
        yield return new WaitForSeconds(.5f);
        explosionParticle5.SetActive(true);
        explosionParticle6.SetActive(true);
        yield return new WaitForSeconds(.5f);
        explosionParticle7.SetActive(true);
        yield return new WaitForSeconds(1f);
        explosionParticle8.SetActive(true);
        explosionParticle9.SetActive(true);
        yield return new WaitForSeconds(1f);
        explosionParticle10.SetActive(true);
        explosionParticle11.SetActive(true);
        explosionParticle12.SetActive(true);
        yield return new WaitForSeconds(1f);
        explosionParticle13.SetActive(true);
        yield return new WaitForSeconds(1f);
        explosionParticle14.SetActive(true);
        explosionParticle15.SetActive(true);
    }
}
