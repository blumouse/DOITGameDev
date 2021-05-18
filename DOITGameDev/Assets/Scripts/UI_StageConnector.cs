using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_StageConnector : MonoBehaviour
{
    GameObject player;
    public GameObject settingPanel;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void JumpClicked()
    {
        
    }

    public void SlideClicked()
    {

    }

    public void MenuClicked()
    {
        settingPanel.SetActive(true);
    }
}
