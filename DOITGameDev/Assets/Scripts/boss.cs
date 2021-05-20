using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator animator;
    public float DestroyTime = 100.0f;
    public float PatternTime;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PatternTime += Time.deltaTime;
        //Ư�� �ð��� ���缭 ������ ���;���
        rigid.velocity = new Vector2(-1, rigid.velocity.y);// ������ ����
        if (rigid.position.x <= 5)                        //x��ǥ 5 ���Ͽ��� ����
        {
            rigid.velocity = new Vector2(0, 0);
        }

        //����
        if ((PatternTime > 5)&&(PatternTime<=10))
        {
            animator.SetBool("pattern1", true);
        }
        else
        {
            animator.SetBool("pattern1", false);
        }
        //Ư�� ���ǿ� ���缭 ���� �ؾ���
       Destroy(gameObject, DestroyTime);//100���Ŀ� �ı���Ŵ

    }
}
