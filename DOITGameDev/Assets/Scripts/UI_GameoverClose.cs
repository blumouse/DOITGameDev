using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameoverClose : MonoBehaviour
{
    private void Update()
    {
        if (Lifebox.gameover || GameEndPanel.gameend)
        {
            gameObject.SetActive(false);
        }
    }
}
