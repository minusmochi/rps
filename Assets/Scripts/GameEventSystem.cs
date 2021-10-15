using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventSystem : MonoBehaviour
{
    public uint Score = 0;
    public static GameEventSystem Current;

    private void Awake()
    {
        Current = this;
    }

    public event Action onIncreaseScore;
    public void IncreaseScore()
    {
        if (onIncreaseScore != null)
            onIncreaseScore();
    }
}