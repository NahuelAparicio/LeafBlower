using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float _speed;
    public float Speed { get { return _speed; } }

    private bool _isInteracting;
    public bool IsInteracting { get { return _isInteracting; } }

    void Update()
    {
        
    }

    public void SetIsInteracting (bool interacted)
    {
        _isInteracting = interacted;
    }
}
