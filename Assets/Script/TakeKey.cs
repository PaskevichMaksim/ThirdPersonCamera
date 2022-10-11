using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    public bool _haveKey;
    
    [SerializeField] private GameObject _alert;
    [SerializeField] private Transform _player;
    private float _distance;
    
    private void Update()
    {
        _distance = Vector3.Distance(transform.position, _player.position);
        if (_distance < 1f)
        {
            _alert.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                _haveKey = true;
                Destroy(gameObject);
                _alert.SetActive(false);
            }
        }
        else
        {
            _alert.SetActive(false);
        }
     
    }
}
