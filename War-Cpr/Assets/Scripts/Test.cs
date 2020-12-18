using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject hand;
    private Animation anim;
    // Start is called before the first frame update
    public void PlayAnim()
    {
        hand.SetActive(false);
        hand.GetComponent<Animation>().Stop("NewHandAnim");
    }


}
