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
    public Vector2 GetBlowerMoveDirection() => _actions.Player.BlowerMove.ReadValue<Vector2>(); // Right Stick -- Mouse Scroll

    private void MoveLeftStick_performed(InputAction.CallbackContext context)
    {

    }
    private void MoveBlower_performed(InputAction.CallbackContext context)
    {

    }
    private void Blow_performed(InputAction.CallbackContext context)
    {

    }
    private void Blow_canceled(InputAction.CallbackContext context)
    {

    }
    private void Aspire_performed(InputAction.CallbackContext context)
    {

    }
    private void Aspire_canceled(InputAction.CallbackContext context)
    {

    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        _player.movement.HandleJumping();
    }

    private void Dash_performed(InputAction.CallbackContext context)
    {
        _player.movement.HandleDash();
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
