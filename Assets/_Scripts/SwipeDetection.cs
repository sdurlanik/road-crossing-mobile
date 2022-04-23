using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _pixelDistToDetect = 20;
    private Vector2 _startPos;
    private bool _fingerDown;

    private void Update()
    {
        if (!_fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            _startPos = Input.touches[0].position;
            _fingerDown = true;
        }

        // ekrana dokunuldu mu
        if (_fingerDown)
        {
            // yukarı kaydırıldı mı
            if (Input.touches[0].position.y >= _startPos.y + _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.up);

            }
            else if (Input.touches[0].position.y <= _startPos.y - _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.down);

            }
            else if (Input.touches[0].position.x <= _startPos.x - _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.left);

            }
            else if (Input.touches[0].position.x >= _startPos.x + _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.right);

            }
        }

        // parmak ekrandan kaldırıldı mı
        if (_fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            _fingerDown = false;
        }
        
        // Testing for PC

        if (!_fingerDown && Input.GetMouseButtonDown(0))
        {
            _startPos = Input.mousePosition;
            _fingerDown = true;
        }

        if (_fingerDown)
        {
            if (Input.mousePosition.y >= _startPos.y + _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.up);
            } 
            else if (Input.mousePosition.y <= _startPos.y - _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.down);

            } 
            else if (Input.mousePosition.x <= _startPos.x - _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.left);

            }
            else if (Input.mousePosition.x >= _startPos.x + _pixelDistToDetect)
            {
                _fingerDown = false;
                _player.Move(Vector3.right);

            }
        }

        if (_fingerDown && Input.GetMouseButtonUp(0))
        {
            _fingerDown = false;
        }
    }
}
