using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private float _moveSpeed;
   [SerializeField] private int _edgeDistance;
   private Vector3 _targetPos;

   [SerializeField] private int _score;

   private void Start()
   {
      _targetPos = transform.position;
   }

   public void Move(Vector3 moveDirection)
   {
      if (Mathf.Abs(_targetPos.x + moveDirection.x) > _edgeDistance)
      {
         return;
      }
      _targetPos += moveDirection;
   }

   private void Update()
   {
      transform.position = Vector3.MoveTowards(transform.position, _targetPos, _moveSpeed * Time.deltaTime);
   }

   public void AddScore(int amount)
   {
      _score += amount;
   }

   public void GameOver()
   {
      print("Game Over");
   }
}
