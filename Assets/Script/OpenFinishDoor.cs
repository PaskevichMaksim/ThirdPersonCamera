using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OpenFinishDoor : MonoBehaviour
{
    [SerializeField] private TakeKey _takeKey;

    private void OnTriggerEnter(Collider other)
    {
        if (_takeKey._haveKey)
        {
            transform.DORotate(new Vector3(0f, -90f, 0f), 3f, RotateMode.Fast);
        }
    }
}