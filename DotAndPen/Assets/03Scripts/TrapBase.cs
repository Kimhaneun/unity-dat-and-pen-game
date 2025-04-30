using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBase : MonoBehaviour
{
    [SerializeField] private float _destroyTime;

    private void Start()
    {
        StartCoroutine(nameof(Destroy));
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(_destroyTime);
        Destroy(gameObject);
        yield return null;
    }
}
