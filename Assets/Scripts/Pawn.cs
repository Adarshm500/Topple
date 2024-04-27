using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public event EventHandler<OnHoverOverPawnChangedEventArgs> OnHoverOverPawnChanged;
    // public event EventHandler<OnSelectedPawnChangedEventArgs> OnSelectedPawnChanged;
    // public class OnSelectedPawnChangedEventArgs : EventArgs 
    // {
    //     public Pawn selectedPawn;
    // }

    public class OnHoverOverPawnChangedEventArgs : EventArgs 
    {
        public Pawn hoverOverPawn;
        public bool visualIsActive;
    }

    // public bool isMoving = false;

    private void OnMouseEnter() 
    {
        HoverPawnChanged(true);
    }
    private void OnMouseExit() 
    {
        HoverPawnChanged(false);
    }

    // private void Update() 
    // {
    //     // HandleMouseInput();
    // }

    // private void HandleMouseInput()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         isMoving = true;
    //         SelectedPawn(this);
    //     }
    //     else if (Input.GetMouseButtonUp(0))
    //     {
    //         isMoving = false;
    //         SelectedPawn(null);
    //     }
    // }

    // private void SelectedPawn(Pawn pawn)
    // {
    //     OnSelectedPawnChanged?.Invoke(this, new OnSelectedPawnChangedEventArgs
    //     {
    //         selectedPawn = pawn
    //     });
    // }

    private void HoverPawnChanged(bool visualIsActive)
    {
        OnHoverOverPawnChanged?.Invoke(this, new OnHoverOverPawnChangedEventArgs
        {
            hoverOverPawn = this,
            visualIsActive = visualIsActive
        });
    }
}
