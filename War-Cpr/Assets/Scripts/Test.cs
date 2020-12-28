using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test : MonoBehaviour
{
    public static float totalTime = 5;
    public Text text;
    private float seconds;
    public GameObject hand;
    private Animation anim;
    public static bool startTimer = false;
    // Start is called before the first frame update
    public void PlayAnim()
    {
        startTimer = true;
        hand.SetActive(false);
        hand.GetComponent<Animation>().Stop("NewHandAnim");
    }


    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
                totalTime -= Time.deltaTime;
                seconds = (int)(totalTime % 60);
               
                if (seconds <= 0)
                {
                    text.text = "NEXT STEP";
                }
                else
                {
                text.text = seconds.ToString();
                }
         
        }
    }
}
