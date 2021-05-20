using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string test;
    public string type;//�÷��̾�� � ���������� �˷��ִ� ����
    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.left * 0.1f;//�������� �������� ���� �ӵ� ����
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
