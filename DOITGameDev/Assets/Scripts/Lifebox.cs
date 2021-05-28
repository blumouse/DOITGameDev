using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifebox : MonoBehaviour
{
    public static bool gameover = false;
    float rest = 0;
    GameObject life1;
    GameObject life2;
    GameObject life3;

    private void Awake()
    {
        life1 = transform.GetChild(0).gameObject;
        life2 = transform.GetChild(1).gameObject;
        life3 = transform.GetChild(2).gameObject;
    }

    private void Update()
    {
        if (rest > 0)
        {
            rest -= Time.deltaTime;
        }
        else if (rest <= 0)
        {
            if (Stage_Player.isHurt == true)
            {
                rest = 3f;

                if (life3.active == true)
                {
                    life3.SetActive(false);
                    return;
                }
                else if (life3.active == false && life2.active == true)
                {
                    life2.SetActive(false);
                    return;
                }
                else if (life3.active == false && life2.active == false && life1.active == true)
                {
                    life1.SetActive(false);
                    gameover = true;
                }
            }
        }        
    }
}
