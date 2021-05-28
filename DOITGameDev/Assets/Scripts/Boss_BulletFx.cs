using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_BulletFx : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<AudioSource>().Play();
    }
}
