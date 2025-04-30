using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrapSpawner : MonoSingleton<TrapSpawner>
{
    [SerializeField] private GameObject[] _traps;
    [SerializeField] private GameObject _player;

    private float _lastYPos;

    private void Start()
    {
        _lastYPos = _player.transform.position.y;
    }

    private void Update()
    {
        float Distance = _lastYPos - _player.transform.position.y;
        if (Distance >= 5)
        {
            _lastYPos = _player.transform.position.y;
            CreateTrap();
        }
    }

    private void CreateTrap()
    {
        int typ = Random.Range(0, _traps.Length);
        Instantiate(_traps[typ], transform.position, Quaternion.identity);
    }

    public void StartLerpYDamping()
    {
        Vector3 targtPos = new Vector3(0, _player.transform.position.y -7, 0);
        transform.position = Vector3.Lerp(transform.position, targtPos, 2 * Time.deltaTime);
    }

    //public void StartTrapSpawn()
    //{
    //    StartCoroutine(nameof(TrapSpawn));
    //}

    //IEnumerator TrapSpawn()
    //{
    //    int typ = Random.Range(0, traps.Length);
    //    Instantiate(traps[typ], transform.position, Quaternion.identity);
    //    yield return new WaitForSeconds(6);
    //    yield return null;
    //}
}
