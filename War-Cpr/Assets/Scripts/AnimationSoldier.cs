﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSoldier : MonoBehaviour
{

    public GameObject soldier;
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimationStart());
        StartCoroutine(RunStart());

    }

    IEnumerator AnimationStart()
    {
        yield return new WaitForSeconds(45);
        soldier.GetComponent<Animation>().Play("soldierSittin2");
    }


    IEnumerator RunStart()
    {
        yield return new WaitForSeconds(46);
        soldier.GetComponent<Animation>().Play("runFast");
        yield return new WaitForSeconds(1.2f);
        soldier.GetComponent<Animation>().Play("runFast 1");
        yield return new WaitForSeconds(1.2f);
        soldier.GetComponent<Animation>().Play("runFast 2");
        yield return new WaitForSeconds(1.2f);
        soldier.GetComponent<Animation>().Play("runFast 3");
        yield return new WaitForSeconds(1.2f);
        soldier.GetComponent<Animation>().Play("soldierMachineGun");


        //soldier.GetComponent<Animation>().Play("soldierSittin3");
    }
}
