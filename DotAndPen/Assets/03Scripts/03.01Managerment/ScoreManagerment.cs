using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagerment : MonoSingleton<ScoreManagerment>
{
    protected ScoreManagerment() { }

    [SerializeField] private TextMeshProUGUI _scoreText;

    public float currentScore;

    private void Start()
    {
        currentScore = 0;
    }

    public void UpdatScor()
    {
        currentScore += 100;

        _scoreText.text = currentScore.ToString("0000");
    }
}
