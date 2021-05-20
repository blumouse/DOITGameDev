using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string test;
    public string type;//플레이어에게 어떤 아이템인지 알려주는 변수
    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.left * 0.1f;//아이템이 왼쪽으로 가는 속도 조절
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
