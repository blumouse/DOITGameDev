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
        //Ư�� �ð��� ���缭 ������ ���;���
        rigid.velocity = new Vector2(-1, rigid.velocity.y);// ������ ����
        if (rigid.position.x <= 5)                        //x��ǥ 5 ���Ͽ��� ����
        {
            rigid.velocity = new Vector2(0, 0);
        }
        
        //����
        //Ư�� ���ǿ� ���缭 ���� �ؾ���
       Destroy(gameObject, DestroyTime);//�ϴ� 10���Ŀ� �ı���Ŵ

    }
}
