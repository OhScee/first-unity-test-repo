using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  private PlayerInputActions _playerInput;

  void Awake() {
    _playerInput = new PlayerInputActions();
    _playerInput.Player.Walk.performed += OnWalk;
  }

  void OnEnable() {
    _playerInput.Player.Walk.Enable();
  }

  void OnDisable() {
    _playerInput.Player.Walk.Disable();
  }

  private void OnWalk(InputAction.CallbackContext context) {
    Debug.Log("TEST");
  }
}
