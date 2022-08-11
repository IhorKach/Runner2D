using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoresAndElapsedTime : MonoBehaviour
{
    [SerializeField] private TMP_Text _textScores;
    [SerializeField] private TMP_Text _textElapsedTime;
    [SerializeField] private TMP_Text _earnedScoresBoard;


    private float _speedScores;
    private double _totalScores;
    private double _totalElapsedTime;

    public double TotalScores => _totalScores;

    private void Start()
    {
        _totalScores = 1;
        _speedScores = 0;
        _totalElapsedTime = 1;
    }

    private void Update()
    {
        _speedScores +=Time.deltaTime;
        
        _totalScores += _speedScores * Time.deltaTime;
        _totalElapsedTime += Time.deltaTime;
        
        _textElapsedTime.text = _totalElapsedTime.ToString("# s");
        _textScores.text = _totalScores.ToString("#");
        _earnedScoresBoard.text = TotalScores.ToString("Earned scores: #\n");

    }
}
