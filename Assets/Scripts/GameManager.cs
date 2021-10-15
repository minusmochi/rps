using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public void Awake()
        {
            GameEventSystem.Current.onCardSelected += CardClicked;
            GameEventSystem.Current.onWheelStopped += WheelStopped;
        }

        public void CardClicked(RPS usersPick)
        {
            Debug.Log("User selected");
            Debug.Log(usersPick);
        }

        public void WheelStopped(RPS wheelPick) {
            Debug.Log("Wheel stopped");
            Debug.Log(wheelPick);
        }

        public void OnDestroy()
        {
            GameEventSystem.Current.onCardSelected -= CardClicked;
            GameEventSystem.Current.onWheelStopped -= WheelStopped;
        }
    }
}
