using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public event EventHandler<OnHoverOverPawnChangedEventArgs> OnHoverOverPawnChanged;
    public class OnHoverOverPawnChangedEventArgs : EventArgs 
    {
        public Pawn hoverOverPawn;
    }
    private void OnMouseEnter() 
    {
        HoverPawnChanged();
    }
    private void OnMouseExit() 
    {
        HoverPawnChanged();
    }

    private void HoverPawnChanged()
    {
        OnHoverOverPawnChanged?.Invoke(this, new OnHoverOverPawnChangedEventArgs
        {
            hoverOverPawn = this
        });
    }
}
