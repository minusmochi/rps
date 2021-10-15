using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int _score = 0;

    public void Start()
    {
        GameEventSystem.Current.onIncreaseScore += OnIncreseScore;
    }

    private void OnIncreseScore()
    {
        Debug.Log("Increasing the score");
        var scoreArea = GetComponent<TextMeshProUGUI>();

        _score += 1;

        scoreArea.text = _score.ToString();
    }

    private void OnDestroy()
    {
        GameEventSystem.Current.onIncreaseScore -= OnIncreseScore;
    }
}

