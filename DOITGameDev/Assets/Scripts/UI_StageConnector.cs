using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_StageConnector : MonoBehaviour
{
    public GameObject settingPanel;

    public void MenuClicked()
    {
        settingPanel.SetActive(true);
    }
}
