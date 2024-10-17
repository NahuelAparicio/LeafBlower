using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement movement { get; set; }
    public PlayerStats stats { get; set; }
    public PlayerInputs inputs { get; set; }

    private bool _isInteracting;


    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        stats = GetComponent<PlayerStats>();
        inputs = GetComponent<PlayerInputs>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
