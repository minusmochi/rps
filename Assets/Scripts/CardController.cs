using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public RPS Rps;

    private void OnMouseUp()
    {
        GameEventSystem.Current.CardSelected(Rps);
    }
}
