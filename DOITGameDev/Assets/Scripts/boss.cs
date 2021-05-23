using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    Rigidbody2D rigid;
    public bool hasSpawn;
    public bool destroy;
    private float TimeLeft = 2.0f;
    private float nextTime = 0.0f;

    public GameObject ����Ʈ;
    public GameObject ������;
    public GameObject �Ἦ;
    public GameObject ����ó��;
    public GameObject ��������;
    public GameObject ���ܾ�;


 
    private bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        hasSpawn = false;
        destroy = false;
        isAttacking = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ư�� �ð��� ���缭 ������ ���;���
        if (hasSpawn == true)
        {
            rigid.velocity = new Vector2(-2, rigid.velocity.y);
        }// ������ ����
        if (rigid.position.x <= 5)                        //x��ǥ 5 ���Ͽ��� ����
        {
            rigid.velocity = new Vector2(0, 0);
           
            if (Time.time>nextTime)
            {
                nextTime = Time.time + TimeLeft;
                Fire();   
            }
        }
        if (hasSpawn == true && destroy == true)
        {
            GameObject.Destroy(gameObject);
        }
        
        //����
        //Ư�� ���ǿ� ���缭 ���� �ؾ���
     

    }
    void Fire()
    {
        GameObject bullet = Instantiate(����Ʈ, new Vector2(6, 2), Quaternion.identity);
        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.left * 5, ForceMode2D.Impulse); ;
    }
}
