using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LipsCollision : MonoBehaviour
{
    public static float totalTimeLip = 5;
    public Text text;
    private float seconds;
    public GameObject txt;
    public GameObject canvas;
    public static bool startTimerLip = false;
    public static bool nextStepLip = false;
    public GameObject timerText;
    public GameObject mouth;
    public GameObject lips;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimerLip)
        {
            txt.SetActive(true);
            totalTimeLip -= Time.deltaTime;
            seconds = (int)(totalTimeLip % 60);


            if (seconds <= 0)
            {
                lips.SetActive(false);
                mouth.SetActive(false);
                canvas.SetActive(false);
                text.text = "NEXT STEP";
                nextStepLip = true;
                startTimerLip = false;
            }
            else
            {
                text.text = seconds.ToString();
            }
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "mouth")
        {
            startTimerLip = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "mouth")
        {
            StartCoroutine(AnimationStart());
        }
    }


    IEnumerator AnimationStart()
    {
        yield return new WaitForSeconds(.1f);

        if (nextStepLip == false)
        {
            startTimerLip = false;

            if (startTimerLip == false)
            {
                timerText.SetActive(false);
            }
            totalTimeLip = 5;
        }
    }


}
