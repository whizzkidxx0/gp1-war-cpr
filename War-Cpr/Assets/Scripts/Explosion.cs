using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionSoundEffects;
    public AudioSource explosionSoundEffects1;
    public AudioSource explosionSoundEffects2;
    public AudioSource explosionSoundEffects3;
    public AudioSource explosionSoundEffects4;
    public AudioSource explosionSoundEffects5;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplosionPlayScript());
        StartCoroutine(ExplosionPlayScript2());

    }


    IEnumerator ExplosionPlayScript()
    {
        yield return new WaitForSeconds(52);
        explosionSoundEffects.Play();
        explosionSoundEffects5.Play();
    }

    IEnumerator ExplosionPlayScript2()
    {
        yield return new WaitForSeconds(62);
        explosionSoundEffects1.volume = 0.1f;
        explosionSoundEffects2.volume = 0.1f;
        explosionSoundEffects3.volume = 0.1f;
        explosionSoundEffects4.Play();
    }

   

}
