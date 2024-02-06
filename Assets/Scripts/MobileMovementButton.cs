using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileMovementButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public PlayerMobileInput input;
    public Vector2 movementDirection;

    public void OnPointerDown(PointerEventData eventData) {
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData) {
        throw new System.NotImplementedException();
    }
}
