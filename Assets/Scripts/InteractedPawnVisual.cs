using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectedPawnVisual : MonoBehaviour
{
    [SerializeField] private GameObject visualGameObject;
    [SerializeField] private Pawn pawn;

    private void Start() 
    {
        pawn.OnHoverOverPawnChanged += Pawn_OnHoverOverPawnChanged;
    }

    private void Pawn_OnHoverOverPawnChanged(object sender, Pawn.OnHoverOverPawnChangedEventArgs e) 
    {
        Debug.Log("enter");
        if (e.hoverOverPawn == pawn)
        {
            if (visualGameObject.activeSelf)
            {
                visualGameObject.SetActive(false);
            }
            else
            {
                visualGameObject.SetActive(true);
            }
        }
        else
        {
            visualGameObject.SetActive(false);
        }
    }
}
