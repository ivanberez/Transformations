﻿using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speedRotation * Time.deltaTime);
    }
}