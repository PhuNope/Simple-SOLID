using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public PlayerMovement playerMovement;
    public PlayerRenderer playerRenderer;
    public PlayerAIInteractions playerAIInteractions;
    public IMovementInput movementInput;
    public PlayerAnimations playerAnimations;

    public GameObject ui_window;

    private void Start() {
        playerMovement = GetComponent<PlayerMovement>();
        playerRenderer = GetComponent<PlayerRenderer>();
        playerAIInteractions = GetComponent<PlayerAIInteractions>();
        movementInput = GetComponent<IMovementInput>();
        playerAnimations = GetComponent<PlayerAnimations>();

        movementInput.OnInteractEvent += () => playerAIInteractions.Interact(playerRenderer.IsSpriteFlipped); ;
    }

    private void FixedUpdate() {
        playerMovement.MovePlayer(movementInput.MovementInputVector);

        playerRenderer.RendererPlayer(movementInput.MovementInputVector);

        playerAnimations.SetupAnimations(movementInput.MovementInputVector);

        if (movementInput.MovementInputVector.magnitude > 0) {
            ui_window.SetActive(false);
        }
    }

    public void ReceiveDamaged() {
        playerRenderer.FlashRed();
    }
}
