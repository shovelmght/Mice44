using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashWhiteScreenManager : MonoBehaviour
{
    static public FlashWhiteScreenManager _Instance;
   [SerializeField] private Color _FlashingColor;
   [SerializeField] private float _Liftime = 0;
   [SerializeField] private Image _ImageReference;


    private void Awake()
    {
        if (_Instance == null)
        {
            _Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public IEnumerator Flash()
    {
        _ImageReference.enabled = true;
        _ImageReference.color = _FlashingColor;
        yield return new WaitForSeconds(_Liftime);
        _ImageReference.enabled = false;
    }
    
    public IEnumerator Flash(Color color)
    {
        _ImageReference.enabled = true;
        _ImageReference.color = color;
        yield return new WaitForSeconds(_Liftime);
        _ImageReference.enabled = false;
    }
}
