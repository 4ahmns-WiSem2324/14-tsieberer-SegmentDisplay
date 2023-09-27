using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimScript : MonoBehaviour
{
    public Image [] segments1 = new Image[7];
    public Image [] segments2 = new Image[7];
    public Image [] segments3 = new Image[7];
    public Image [] segments4 = new Image[7];


    void Start()
    {
        for (int i = 0; i < segments1.Length; i++)
        {
            segments1[i].enabled = false;
            segments2[i].enabled = false;
            segments3[i].enabled = false;
            segments4[i].enabled = false;
        }
        StartCoroutine(StartAnim());
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < segments1.Length; i++)
            {
                segments1[i].enabled = false;
                segments2[i].enabled = false;
                segments3[i].enabled = false;
                segments4[i].enabled = false;
            }
            StartCoroutine(StartAnim());
        }
    }

    IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(0.5f);

        segments1[5].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments1[0].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments1[1].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments1[6].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments1[4].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments1[3].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments1[2].enabled = true;

        yield return new WaitForSeconds(0.25f);
        segments2[5].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments2[0].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments2[1].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments2[6].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments2[4].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments2[3].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments2[2].enabled = true;

        yield return new WaitForSeconds(0.25f);
        segments3[5].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments3[0].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments3[1].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments3[6].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments3[4].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments3[3].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments3[2].enabled = true;

        yield return new WaitForSeconds(0.25f);
        segments4[5].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments4[0].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments4[1].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments4[6].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments4[4].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments4[3].enabled = true;
        yield return new WaitForSeconds(0.25f);
        segments4[2].enabled = true;

        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < segments1.Length; i++)
        {
            segments1[i].enabled = false;
            segments2[i].enabled = false;
            segments3[i].enabled = false;
            segments4[i].enabled = false;
        }
    }
}
