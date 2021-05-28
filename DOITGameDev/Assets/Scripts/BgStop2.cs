using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgStop2 : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.x >= -5)
        {
            Stage_BgMove.moveSpeed = 0;
        }
    }
}
