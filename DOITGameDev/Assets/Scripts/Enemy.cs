using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public string type;
    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.left * 0.5f;
    }

    void meet()
    {   

        Destroy(gameObject);
    }
}
