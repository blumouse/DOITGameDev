using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage_Player : MonoBehaviour
{
    
    public Vector3 playerPos;
    public Vector3 playerRot;

    static Transform playerTrans;
    static Rigidbody2D playerRigid;

    private void Awake()
    {
        playerTrans = gameObject.GetComponent<Transform>();
        playerRigid = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    public static void Player_Jump()
    {
        //애니메이션 재생
        playerRigid.AddForce(new Vector2(0, 600));
    }

    public static void Player_Slide()
    {
        playerTrans.position -= new Vector3(0, 0.6f);
        playerTrans.eulerAngles = new Vector3(0, 0, 90);
    }

    public static void Player_SlideBack()
    {
        playerTrans.position += new Vector3(0, 0.6f);
        playerTrans.eulerAngles = new Vector3(0, 0, 0);
    }

    public void Player_Idle()
    {
        playerTrans.position = playerPos;
        playerTrans.eulerAngles = playerRot;
    }

    public void Player_Run()
    {
        playerTrans.position = playerPos;
        playerTrans.eulerAngles = playerRot;
    }
}
