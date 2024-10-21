using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]private float _speed;
    public float Speed { get { return _speed; } }

    [SerializeField] private float _dashForce;
    public float DashForce {  get { return _dashForce; } }

    [SerializeField] private float _jumpForce;
    public float JumpForce { get { return _jumpForce; } }
    //Change this to variables with modifiers
}
