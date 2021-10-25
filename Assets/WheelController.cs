using Assets.Scripts.helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WheelState
{
    Spinning,
    Slowing,
    Stopped,
    Restarting
}
public class WheelController : MonoBehaviour
{
    public float runningSpeed = 2;

    private WheelState _state = WheelState.Spinning;
    private float spinSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = runningSpeed;

        GameEventSystem.Current.onCardSelected += OnCardSelected;
    }

    // Update is called once per frame
    void Update()
    {
        switch (_state)
        {
            case WheelState.Spinning:
                rotate();
                break;
            case WheelState.Slowing:
                rotate();

                if (spinSpeed < 0.5)
                {
                    spinSpeed = 0;
                    GameEventSystem.Current.WheelStopped(CheckPosition());
                    _state = WheelState.Stopped;
                }
                else
                {
                    spinSpeed *= 0.98f;
                }
                break;
            case WheelState.Stopped:
                break;
            case WheelState.Restarting:
                spinSpeed = runningSpeed;
                break;
        }

    }

    void OnCardSelected(RPS rps)
    {
        if (_state == WheelState.Spinning)
        {
            _state = WheelState.Slowing;
        }
    }

    void rotate()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }

    private RPS CheckPosition()
    {
        var degrees = RotationHelper.ToDegree(transform.rotation.z);

        if (degrees >= 0 && degrees <= 120)
        {
            return RPS.Rock;
        }
        else if (degrees > 120 && degrees <= 240)
        {
            return RPS.Paper;
        }
        else
        {
            return RPS.Sissors;
        }

    }

    
}
