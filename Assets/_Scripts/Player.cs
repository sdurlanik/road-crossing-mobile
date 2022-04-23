using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private float _moveSpeed;
   private Vector3 targetPos;

   private void Start()
   {
      targetPos = transform.position;
   }

   public void Move(Vector3 moveDirection)
   {
      targetPos += moveDirection;
   }

   private void Update()
   {
      transform.position = Vector3.MoveTowards(transform.position, targetPos, _moveSpeed * Time.deltaTime);
   }
}
