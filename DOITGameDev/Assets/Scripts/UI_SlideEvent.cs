using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_SlideEvent : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator playeranim;

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
