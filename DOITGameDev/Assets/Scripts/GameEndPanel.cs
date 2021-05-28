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
        if (Stage_Player.isPerfect)
        {
            transform.GetChild(3).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
