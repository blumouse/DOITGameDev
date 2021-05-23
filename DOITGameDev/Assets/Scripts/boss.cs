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

    public GameObject 레포트;
    public GameObject 시험지;
    public GameObject 결석;
    public GameObject 지각처리;
    public GameObject 영어퀴즈;
    public GameObject 영단어;


 
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
        //특정 시간에 맞춰서 앞으로 나와야함
        if (hasSpawn == true)
        {
            rigid.velocity = new Vector2(-2, rigid.velocity.y);
        }// 앞으로 나옴
        if (rigid.position.x <= 5)                        //x좌표 5 이하에서 멈춤
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
        
        //패턴
        //특정 조건에 맞춰서 퇴장 해야함
     

    }
    void Fire()
    {
        GameObject bullet = Instantiate(레포트, new Vector2(6, 2), Quaternion.identity);
        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.left * 5, ForceMode2D.Impulse); ;
    }
}
