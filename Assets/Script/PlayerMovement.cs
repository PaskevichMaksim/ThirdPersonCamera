using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform _camera;
    [SerializeField] private float _speed;
    [SerializeField] private float _turnSmoothTime = 0.1f;

    private float _turnSmoothVelocity;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool("IsWalking", _speed!= 0);
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (horizontal !=0 || vertical !=0)
        {
            _speed = 1f;
        }
        else
        {
            _speed = 0f;
        }
        
        if (direction.magnitude >= 0.1f);
        {
            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref _turnSmoothVelocity,
                _turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f,angle,0f);

             Vector3 moveDirection = Quaternion.Euler(0f, targetAngel, 0f) * Vector3.forward;
            _controller.Move(moveDirection.normalized *_speed * Time.deltaTime);
        }
    }
}
