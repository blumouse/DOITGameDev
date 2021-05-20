using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_JumpEvent : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator playeranim;
    float jumptime;

    private void Update()
    {
        if (jumptime >= 0)
        {
            jumptime -= Time.deltaTime;
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (jumptime <= 0)
        {
            playeranim.SetBool("isJump", true);
            Stage_Player.Player_Jump();
            jumptime = 1f;
        }        
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        playeranim.SetBool("isJump", false);
    }
}
