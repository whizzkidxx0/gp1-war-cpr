using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
    public GameObject hand;
    private Animation anim;

    // Start is called before the first frame update
    public void Start()
    {
        hand.SetActive(true);
        StartCoroutine(AnimationStart());
    }

    IEnumerator AnimationStart()
    {
        yield return new WaitForSeconds(3);
        hand.GetComponent<Animation>().Play("NewHandAnim");
    }

}
