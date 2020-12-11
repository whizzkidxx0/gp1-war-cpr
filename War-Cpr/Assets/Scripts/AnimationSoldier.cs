using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSoldier : MonoBehaviour
{

    public GameObject soldier;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimationStart());
    }



    IEnumerator AnimationStart()
    {
        yield return new WaitForSeconds(45);
        soldier.GetComponent<Animation>().Play("soldierSittin2");
    }

}
