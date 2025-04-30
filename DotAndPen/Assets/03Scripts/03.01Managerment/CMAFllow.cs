using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMAFollow : MonoSingleton<CMAFollow>
{
    [SerializeField] private GameObject _mainCMA;
    [SerializeField] private GameObject _player;

    [SerializeField] private float _fallYPanTime;

    public void StartLerpYDamping()
    {
        Vector3 targtPos = new Vector3(0, _player.transform.position.y - 2, -10);
        _mainCMA.transform.position = Vector3.Lerp(_mainCMA.transform.position, targtPos, 2 * Time.deltaTime);
    }
}
