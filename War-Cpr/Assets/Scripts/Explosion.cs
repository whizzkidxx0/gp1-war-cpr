using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionSoundEffects;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplosionPlayScript());
    }


    IEnumerator ExplosionPlayScript()
    {
        yield return new WaitForSeconds(52);
        explosionSoundEffects.Play();
    }
}
