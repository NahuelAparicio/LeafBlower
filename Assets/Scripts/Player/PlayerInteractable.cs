using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    private PlayerController _player;

    private void Awake()
    {
        _player = transform.parent.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(_player.stats.IsInteracting)
        {
            other.GetComponent<IInteractable>().OnInteract();
        }
    }
}
