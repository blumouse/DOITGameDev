using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndPanel : MonoBehaviour
{
    public static bool gameend;

    public void Quit()
    {
        Application.Quit();
    }

    private void OnEnable()
    {
        gameend = true;
    }
}
