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
    public GameObject txt;
    public static bool playHandAnim = false;
    private Animation anim;
    public static bool startTimer = false;
    public static bool nextStep = false;
    public GameObject cube;
    public GameObject canvas;
    public AudioSource playNext;
    int counter = 0;
    // Start is called before the first frame update
    public void PlayAnim()
    {
        startTimer = true;
        if (playHandAnim == false)
        {
            hand.SetActive(false);
            hand.GetComponent<Animation>().Stop("NewHandAnim");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
                txt.SetActive(true);
                totalTime -= Time.deltaTime;
                seconds = (int)(totalTime % 60);


            if (seconds <= 0)
                {
                    cube.SetActive(false);
                    canvas.SetActive(false);
                    text.text = "NEXT STEP";
                    nextStep = true;
                    hand.GetComponent<Animation>().Stop("NewHandAnim");
                    hand.SetActive(false);
                    startTimer = false;
                }
                else
                {
                text.text = seconds.ToString();
                playHandAnim = true;
                }
         
        }


        if (nextStep)
        {
            if (playNext.isPlaying == false)
            {
                StartCoroutine(playNextScene()); 
            }
        }
    }



    IEnumerator playNextScene()
    {
        playNext.Play();
        yield return new WaitForSeconds(3);
        playNext.Stop();
        totalTime = 30;
        nextStep = false;
        yield return new WaitForSeconds(3);
        //startTimer = true;
    }


}
