using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticleSystems : MonoBehaviour
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
        StartCoroutine(ParticleScript());
     
    }


    IEnumerator ParticleScript()
    {
        yield return new WaitForSeconds(63);
        explosionParticle.SetActive(true);
        explosionParticle2.SetActive(true);
        explosionParticle3.SetActive(true);
        explosionParticle4.SetActive(true);
        explosionParticle5.SetActive(true);
        explosionParticle6.SetActive(true);
        explosionParticle7.SetActive(true);
        explosionParticle8.SetActive(true);
        explosionParticle9.SetActive(true);
        explosionParticle10.SetActive(true);
        explosionParticle11.SetActive(true);
        explosionParticle12.SetActive(true);
        explosionParticle13.SetActive(true);
        explosionParticle14.SetActive(true);
        explosionParticle15.SetActive(true);

    }


}
