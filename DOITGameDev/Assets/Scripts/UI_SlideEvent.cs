using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_SlideEvent : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Animator playeranim;

    void OnEnable()
    {
        playeranim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            playeranim.SetBool("isSlide", true);
            Stage_Player.Player_Slide();
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            playeranim.SetBool("isSlide", false);
            Stage_Player.Player_SlideBack();
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        playeranim.SetBool("isSlide", true);
        Stage_Player.Player_Slide();
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        playeranim.SetBool("isSlide", false);
        Stage_Player.Player_SlideBack();
    }    
}
