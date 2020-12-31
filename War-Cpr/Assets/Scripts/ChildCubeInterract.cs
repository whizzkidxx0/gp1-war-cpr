using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildCubeInterract : MonoBehaviour
{
    public static bool childCubeInterract = false;
    public static int counter = 0;
    public Text counterText;
    public GameObject txt;


    // Start is called before the first frame update
    public void Start()
    {
        //txt.SetActive(true);
        childCubeInterract = true;
        if(childCubeInterract && HeartMassage.cubeParentInteract)
        {
            counter++;
            counterText.text = counter.ToString();
        } 
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
