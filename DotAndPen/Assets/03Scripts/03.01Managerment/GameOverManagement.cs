using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManagement : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Player.Instance.IsGameOver())
        {
            gameObject.SetActive(true);
            TrapSpawner.Instance.StopAllCoroutines();
        }
    }

    public void OnClickButton()
    {
        SceneManager.LoadScene(0);
    }
}
