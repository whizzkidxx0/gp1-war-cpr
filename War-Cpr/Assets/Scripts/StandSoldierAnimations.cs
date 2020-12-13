using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandSoldierAnimations : MonoBehaviour
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
        yield return new WaitForSeconds(0);
        soldier.GetComponent<Animation>().Play("soldierTalking");
    }


    IEnumerator RunStart()
    {
        yield return new WaitForSeconds(49);
        soldier.GetComponent<Animation>().Play("runToCounter");
        yield return new WaitForSeconds(1.5f);
        soldier.GetComponent<Animation>().Play("runToCounter2");
        yield return new WaitForSeconds(1.5f);
        soldier.GetComponent<Animation>().Play("counterSoldier");


        //soldier.GetComponent<Animation>().Play("soldierSittin3");
    }

}
