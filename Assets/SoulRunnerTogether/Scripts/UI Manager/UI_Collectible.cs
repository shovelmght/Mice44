using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Collectible : MonoBehaviour
{
    public static UI_Collectible Instance { get; private set; }
    [SerializeField] private Animator _Animator;
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void SetCollectibleAnimator(string trigger)
    {
        _Animator.SetTrigger(trigger);
    }
    
}
