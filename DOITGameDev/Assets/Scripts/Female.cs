using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Female : MonoBehaviour
{    
    Transform transform;
    float moveSpeed = 8f;

    private void OnEnable()
    {
        transform = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 speed = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        transform.position += speed;
        if (BgStop1.bgStoped)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
