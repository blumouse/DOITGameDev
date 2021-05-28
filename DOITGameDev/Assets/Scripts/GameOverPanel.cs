using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("FieldStage");
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        Lifebox.gameover = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
