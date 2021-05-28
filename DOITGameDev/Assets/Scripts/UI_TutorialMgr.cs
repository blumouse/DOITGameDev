using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_TutorialMgr : MonoBehaviour
{
    public GameObject jumptext;
    public GameObject slidetext;

    private void OnEnable()
    {
        Invoke("Tutorial", 2f);
    }

    public void JumpClicked()
    {
        jumptext.SetActive(false);
    }

    public void SlideClicked()
    {
        slidetext.SetActive(false);
    }

    void Tutorial()
    {
        StartCoroutine("Blink", jumptext);
        StartCoroutine("Blink", slidetext);
    }

    IEnumerator Blink(GameObject text)
    {
        for (int i = 0; i < 3; i++)
        {
            text.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            text.SetActive(true);
            yield return new WaitForSeconds(0.5f);            
        }
    }
}
