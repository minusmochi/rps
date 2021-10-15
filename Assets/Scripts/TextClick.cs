using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextClick : MonoBehaviour
{
    //private void Update()
    //{
    //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    if(Physics.Raycast(ray, out var hit))
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //            print(hit.collider.name);
    //    }
    //}
    private void OnMouseDown()
    {
        GameEventSystem.Current.IncreaseScore();
    }
}
