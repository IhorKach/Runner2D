using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;


    private float _hardnessLevel;
    private float _elapsedTime;

    private void Start()
    {
        _hardnessLevel = 0;
        _elapsedTime = 0f;
        if (transform.position.y == 3)
        {
            transform.DOMoveY(-3, 3).SetLoops(-1, LoopType.Yoyo).SetAutoKill(false).Restart();
        }
        else if (transform.position.y == -3)
        {
            transform.DOMoveY(3, 3).SetLoops(-1, LoopType.Yoyo).SetAutoKill(false).Restart();
        }
        else if(transform.position.y == 0)
        {
            
            transform.DOMoveY(3, 3).SetLoops(-1, LoopType.Yoyo).SetAutoKill(false).Restart();
        }

    }
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        _hardnessLevel += (Time.deltaTime / (_elapsedTime * 10)) + 0.000025f;

        //Debug.Log(_hardnessLevel);

        transform.Translate(Vector3.left * _speed * Time.deltaTime * _hardnessLevel);

    }

}

