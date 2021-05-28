using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_StartBtn : MonoBehaviour
{
    Image curtain;
    Color setAlpha;

    public void GameStart()
    {
        curtain = GameObject.Find("Curtain").GetComponent<Image>();
        setAlpha = new Color(0, 0, 0, 0);
        StartCoroutine("Fadeout");
        Invoke("LoadScene", 3f);
    }

    IEnumerator Fadeout()
    {
        while (curtain.color.a < 255)
        {
            setAlpha.a += 0.002f;
            curtain.color = setAlpha;
            yield return new WaitForEndOfFrame();
        }        
    }

    void LoadScene()
    {
        SceneManager.LoadScene("FieldStage");
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }
}
