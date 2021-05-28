using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonateMan : MonoBehaviour
{
    Animator donateAnim;
    public GameObject donation;

    private void Awake()
    {
        donateAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        GetComponent<Transform>().position += new Vector3(Time.deltaTime * 5f, 0);
    }

    private void OnEnable()
    {
        Invoke("PlayZero", 2.5f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }

    void PlayZero()
    {
        donateAnim.SetBool("watch", true);
        Invoke("PlayOne", 1.2f);
    }


    void PlayOne()
    {
        donateAnim.SetBool("throw", true);
        int ranPoint = Random.Range(0, 3);

        switch (ranPoint)
        {
            case 0:
                Instantiate(donation, new Vector3(GetComponent<Transform>().position.x, 0.4f), Quaternion.Euler(0, 0, 0));
                break;
            case 1:
                Instantiate(donation, new Vector3(GetComponent<Transform>().position.x, -0.8f), Quaternion.Euler(0, 0, 0));
                break;
            case 2:
                Instantiate(donation, new Vector3(GetComponent<Transform>().position.x, -2.3f), Quaternion.Euler(0, 0, 0));
                break;
        }        
    }
}
