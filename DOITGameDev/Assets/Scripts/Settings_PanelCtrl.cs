using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_PanelCtrl : MonoBehaviour
{
    Animation anim;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    private void Update()
    {
        if (Lifebox.gameover)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        anim.Play("Settings_PanelOpen");
        Invoke("Open", 0.5f);
    }

    public void CloseClicked()
    {
        Time.timeScale = 1f;
        anim.Play("Settings_PanelClose");
        Invoke("Close", 1f);        
    }

    void Open()
    {
        Time.timeScale = 0;
    }

    void Close()
    {
        GameObject panel = transform.parent.gameObject;
        panel.SetActive(false);
    }

    public void QuitClicked()
    {
        Application.Quit();
    }
}
