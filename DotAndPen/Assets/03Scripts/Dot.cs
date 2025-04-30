using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    [SerializeField] private float dstroTim;

    private void Start()
    {
        Destroy(gameObject, dstroTim);
    }
}
