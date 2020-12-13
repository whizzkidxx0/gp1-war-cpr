using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public GameObject machineGunParticle;
    public GameObject machineGunParticle2;
    public AudioSource machineGunSound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MachineGunScript());
        StartCoroutine(MachineGunScript2());

    }


    IEnumerator MachineGunScript()
    {
        yield return new WaitForSeconds(51);
        machineGunSound.Play();
    }


    IEnumerator MachineGunScript2()
    {
        yield return new WaitForSeconds(52);
        machineGunParticle.SetActive(true);
        machineGunParticle2.SetActive(true);
    }

  

}
