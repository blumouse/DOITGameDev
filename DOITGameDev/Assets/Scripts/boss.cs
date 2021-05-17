using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    Rigidbody2D rigid;
    public float DestroyTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //특정 시간에 맞춰서 앞으로 나와야함
        rigid.velocity = new Vector2(-1, rigid.velocity.y);// 앞으로 나옴
        if (rigid.position.x <= 5)                        //x좌표 5 이하에서 멈춤
        {
            rigid.velocity = new Vector2(0, 0);
        }
        
        //패턴
        //특정 조건에 맞춰서 퇴장 해야함
       Destroy(gameObject, DestroyTime);//일단 10초후에 파괴시킴

    }
}
