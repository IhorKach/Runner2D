using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _maxHeight;
    
    
    private Vector3 _targetPosition;
    

    private void Start()
    {
        _targetPosition = transform.position;
    }
    private void Update()
    {
        if (transform.position != _targetPosition)
     
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
    }
    public void TryMoveUp()
    {
        if(transform.position.y < _maxHeight)
            SetNextPosition(_stepSize);
    }
    public void TryMoveDown()
    {
        if (transform.position.y > _minHeight)
        SetNextPosition(-_stepSize);
    }
    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }
}
