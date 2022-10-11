using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.DORotate(new Vector3(0f, -90f, 0f), 3f, RotateMode.Fast);
        
    }
}
