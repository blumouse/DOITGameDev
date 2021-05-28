using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgStop1 : MonoBehaviour
{
    public static bool bgStoped = false;

    void Update()
    {
        if (gameObject.transform.position.x >= 5)
        {
            Stage_BgMove.moveSpeed = 0;
            bgStoped = true;
            Invoke("ToBoss", 5f);
        }
    }

    void ToBoss()
    {
        bgStoped = false;
    }
}
