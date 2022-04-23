using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    void Update()
    {
        transform.position = new Vector3(0, _target.position.y, -10);
    }
}
