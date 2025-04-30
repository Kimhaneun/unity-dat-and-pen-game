using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    [SerializeField] private GameObject _dotPrefab;

    private void Update()
    {
        if (!Player.Instance.IsGameOver() && Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreatePen();
        }
    }

    private void CreatePen()
    {
        Vector3 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 dotPos = new Vector2(mousPos.x, mousPos.y);
        Instantiate(_dotPrefab, dotPos, Quaternion.identity);
    }
}
