using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement movement { get; set; }
    public PlayerStats stats { get; set; }
    public PlayerInputs inputs { get; set; }
    public PlayerInteractable interactable { get; set; }

    private Rigidbody _rb;

    public Rigidbody Rigidbody { get {  return _rb; } }

    private void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        stats = GetComponent<PlayerStats>();
        inputs = GetComponent<PlayerInputs>();
        interactable = transform.GetChild(1).GetComponent<PlayerInteractable>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
