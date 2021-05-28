using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Eng : MonoBehaviour
{
    Transform transform;
    float moveSpeed = 16f;

    private void OnEnable()
    {
        transform = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 speed = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        transform.position += speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
