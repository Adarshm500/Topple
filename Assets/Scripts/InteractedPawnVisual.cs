using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractedPawnVisual : MonoBehaviour
{
    [SerializeField] private GameObject visualGameObject;
    [SerializeField] private Pawn pawn;
    [SerializeField] private PawnMovementController pawnMovementController;

    private bool pawnIsSelected = false;

    private void Start() 
    {
        pawn.OnHoverOverPawnChanged += Pawn_OnHoverOverPawnChanged;
        pawnMovementController.OnSelectedPawnChanged += PawnMovementController_OnSelectedPawnChanged;
    }

    private void PawnMovementController_OnSelectedPawnChanged(object sender, PawnMovementController.OnSelectedPawnChangedEventArgs e)
    {
        Debug.Log(e.selectedPawn);
        if (e.selectedPawn == pawn)
        {
            pawnIsSelected = true;
            visualGameObject.SetActive(true);
        }
        else
        {
            pawnIsSelected = false;
            visualGameObject.SetActive(false);
        }
    }

    private void Pawn_OnHoverOverPawnChanged(object sender, Pawn.OnHoverOverPawnChangedEventArgs e) 
    {
        Debug.Log("enter");
        if (!pawnIsSelected)
        {
            if (e.hoverOverPawn == pawn)
            {
                if (e.visualIsActive)
                {
                    visualGameObject.SetActive(true);
                }
                else
                {
                    visualGameObject.SetActive(false);
                }
            }
            else
            {
                visualGameObject.SetActive(false);
            }
        }
    }
}
