using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SegmentScript : MonoBehaviour
{
    public Image [] segments = new Image[7];


    void Start()
    {
        for (int i = 0; i < segments.Length; i++)
        {
            segments[i].enabled = false;
        }
        StartCoroutine(StartAnim());
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            segments[0].enabled = true;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = true;
            segments[4].enabled = true;
            segments[5].enabled = true;
            segments[6].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            segments[0].enabled = false;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = false;
            segments[4].enabled = false;
            segments[5].enabled = false;
            segments[6].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            segments[0].enabled = true;
            segments[1].enabled = true;
            segments[2].enabled = false;
            segments[3].enabled = true;
            segments[4].enabled = true;
            segments[5].enabled = false;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            segments[0].enabled = true;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = true;
            segments[4].enabled = false;
            segments[5].enabled = false;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            segments[0].enabled = false;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = false;
            segments[4].enabled = false;
            segments[5].enabled = true;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            segments[0].enabled = true;
            segments[1].enabled = false;
            segments[2].enabled = true;
            segments[3].enabled = true;
            segments[4].enabled = false;
            segments[5].enabled = true;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            segments[0].enabled = true;
            segments[1].enabled = false;
            segments[2].enabled = true;
            segments[3].enabled = true;
            segments[4].enabled = true;
            segments[5].enabled = true;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            segments[0].enabled = true;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = false;
            segments[4].enabled = false;
            segments[5].enabled = false;
            segments[6].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            segments[0].enabled = true;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = true;
            segments[4].enabled = true;
            segments[5].enabled = true;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            segments[0].enabled = true;
            segments[1].enabled = true;
            segments[2].enabled = true;
            segments[3].enabled = true;
            segments[4].enabled = false;
            segments[5].enabled = true;
            segments[6].enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].enabled = false;
            }
            StartCoroutine(StartAnim());
        }
    }

    IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(0.5f);

        segments[5].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments[0].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments[1].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments[6].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments[4].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments[3].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments[2].enabled = true;
    }
}
