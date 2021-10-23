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
        RPS UserSelection;
        RPS WheelSelection;
        public void Awake()
        {
            GameEventSystem.Current.onCardSelected += CardClicked;
            GameEventSystem.Current.onWheelStopped += WheelStopped;
        }

        public void CardClicked(RPS usersPick)
        {
            Debug.Log("User selected " + usersPick);
        }

        public void WheelStopped(RPS wheelPick)
        {
            Debug.Log("Wheel stopped: " + wheelPick);
        }

        public void OnDestroy()
        {
            GameEventSystem.Current.onCardSelected -= CardClicked;
            GameEventSystem.Current.onWheelStopped -= WheelStopped;
        }
    }
}
