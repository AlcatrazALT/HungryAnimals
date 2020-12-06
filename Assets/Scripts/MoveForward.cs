﻿using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private float speed = 40.0f;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}