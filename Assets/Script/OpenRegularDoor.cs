using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OpenRegularDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.DORotate(new Vector3(0f, -90f, 0f), 3f, RotateMode.Fast);
    }
}