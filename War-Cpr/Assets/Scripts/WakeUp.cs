using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class WakeUp : MonoBehaviour
{
    public Volume v;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WakeAndBake());
    }


    IEnumerator WakeAndBake()
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 3; i++)
        {
            v.weight = .997f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .994f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .991f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .987f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .984f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .987f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .990f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .994f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .997f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .994f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .990f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .987f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .984f;
            yield return new WaitForSeconds(0.2f);
            v.weight = .980f;
            yield return new WaitForSeconds(0.2f);

        }

        v.weight = .984f;
        yield return new WaitForSeconds(0.15f);
        v.weight = .980f;
        yield return new WaitForSeconds(0.15f);

    }

}
