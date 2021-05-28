using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_JumpEvent : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Animator playeranim;
    float jumptime;

    void OnEnable()
    {
        playeranim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    private void Update()
    {
        if (jumptime >= 0)
        {
            jumptime -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (jumptime <= 0)
            {
                playeranim.SetBool("isJump", true);
                Stage_Player.Player_Jump();
                jumptime = 0.95f;
                Invoke("SetJump", 0.55f);
            }
        }

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (jumptime <= 0)
        {
            playeranim.SetBool("isJump", true);
            Stage_Player.Player_Jump();
            jumptime = 0.95f;
            Invoke("SetJump", 0.55f);
        }        
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        
    }

    void SetJump()
    {
        playeranim.SetBool("isJump", false);
    }
}
