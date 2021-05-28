using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_BgMove : MonoBehaviour
{
    
    public static float moveSpeed = 0;
    Vector3 bgSpeed;
    Transform bgTrans;

    private void OnEnable()
    {
        bgTrans = gameObject.GetComponent<Transform>();
        Invoke("SetSpeed", 3f);        
    }
    
    void Update()
    {
        bgSpeed = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        bgTrans.position += bgSpeed;

        if (Lifebox.gameover)
        {
            moveSpeed = 0;
        }
    }

    void SetSpeed()
    {
        moveSpeed = 5f;
    }

    
}
