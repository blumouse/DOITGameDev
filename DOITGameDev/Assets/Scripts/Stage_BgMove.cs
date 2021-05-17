using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_BgMove : MonoBehaviour
{
    public static float moveSpeed;
    Vector3 bgSpeed;
    Transform bgTrans;

    private void OnEnable()
    {
        moveSpeed = 1f;
        bgTrans = gameObject.GetComponent<Transform>();
        bgSpeed = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }
    
    void Update()
    {
        bgTrans.position -= bgSpeed;

        if (bgTrans.position.x <= -15)
        {
            bgTrans.position += new Vector3(30, 0, 0);
        }

    }

}
