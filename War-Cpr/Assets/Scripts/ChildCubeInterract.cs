using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildCubeInterract : MonoBehaviour
{
    public static bool childCubeInterract = false;
    public static int counter = 0;
    public static int counter2 = 0;
    public Text counterText;
    public Text counterText2;
    public GameObject txt;


    // Start is called before the first frame update
    public void Start()
    {
        //txt.SetActive(true);
        childCubeInterract = true;
        if(childCubeInterract && HeartMassage.cubeParentInteract)
        {
            if (HeartMassage.sceneCounter == 1)
            {
                counter++;
                counterText.text = counter.ToString();
                PlayerPrefs.SetInt("SecondScore", counter);

            }
            else if(HeartMassage.sceneCounter == 0){
                counter2++;
                counterText2.text = counter2.ToString();
                PlayerPrefs.SetInt("FirstScore", counter2);
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
