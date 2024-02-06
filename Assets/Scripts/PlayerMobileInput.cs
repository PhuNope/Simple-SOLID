using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobileInput : MonoBehaviour, IMovementInput {
    public Vector2 MovementInputVector { get; private set; }

    public event Action OnInteractEvent;

    public void GetMovementInput(Vector2 direction) {
        MovementInputVector = direction;
    }

    public void InteractInput() {
        OnInteractEvent?.Invoke();
    }

    public void ResetInput() {
        MovementInputVector = Vector2.zero;
    }
}
