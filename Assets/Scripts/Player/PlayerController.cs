using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement movement { get; set; }
    public PlayerStats stats { get; set; }
    public PlayerInputs inputs { get; set; }
    public PlayerInteractable interactable { get; set; }

    private bool _isInteracting;


    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        stats = GetComponent<PlayerStats>();
        inputs = GetComponent<PlayerInputs>();
        // interactable = get reference
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
