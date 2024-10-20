using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    private PlayerController _player;

    private PlayerInputsActions _actions;

    private void Awake()
    {
        _player = GetComponent<PlayerController>();
        _actions = new PlayerInputsActions();
        _actions.Player.Enable();
    }

    public Vector2 GetMoveDirection() => _actions.Player.Move.ReadValue<Vector2>(); // Left Stick -- WASD

    private void Jump_performed(InputAction.CallbackContext context)
    {
        _player.movement.HandleJumping();
    }

    private void Dash_performed(InputAction.CallbackContext context)
    {
        _player.movement.HandleDash(); // If jump + Blow HandleDash()
    }

    private void Pause_performed(InputAction.CallbackContext context) 
    {
        GameManager.Instance.PauseGameHandler();
    }
    private void OnDestroy()
    {
        _actions.Player.Disable();
    }

}
