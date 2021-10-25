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
        Dictionary<RPS, RPS> _winners = new Dictionary<RPS, RPS> {
            { RPS.Paper, RPS.Rock },
            { RPS.Rock, RPS.Sissors },
            { RPS.Sissors, RPS.Paper }
        };
        RPS _userSelection;
        RPS _wheelSelection;
        public void Awake()
        {
            GameEventSystem.Current.onCardSelected += CardClicked;
            GameEventSystem.Current.onWheelStopped += WheelStopped;
        }

        public void CardClicked(RPS usersPick)
        {
            _userSelection = usersPick;
            Debug.Log("User selected " + usersPick);
        }

        public void WheelStopped(RPS wheelPick)
        {
            _wheelSelection = wheelPick;
            Debug.Log("Wheel stopped: " + wheelPick);

            CheckResult();
        }

        private void CheckResult()
        {
            var winningPick = _winners[_userSelection];

            if(_wheelSelection == winningPick)
            {
                GameEventSystem.Current.IncreaseScore();
            }
                
        }

        public void OnDestroy()
        {
            GameEventSystem.Current.onCardSelected -= CardClicked;
            GameEventSystem.Current.onWheelStopped -= WheelStopped;
        }
    }
}
