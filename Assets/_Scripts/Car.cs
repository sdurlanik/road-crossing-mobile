using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _startPos;
    [SerializeField] private Vector3 _endPos;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPos, _speed * Time.deltaTime);

        if (transform.position == _endPos)
        {
            transform.position = _startPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.GetComponent<Player>().GameOver();
        }
    }
}
