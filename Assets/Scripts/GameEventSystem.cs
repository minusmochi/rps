using System;
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


    public event Action<RPS> onCardSelected;
    public void CardSelected(RPS rps)
    {
        if (onCardSelected != null)
            onCardSelected(rps);
    }


    public event Action<RPS> onWheelStopped;
    public void WheelStopped(RPS rotation)
    {
        if (onWheelStopped != null)
            onWheelStopped(rotation);
    }
}