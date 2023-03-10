using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    [SerializeField] private AudioSource _scoreSound;
    [SerializeField] private AudioClip _scorePlus;
    [SerializeField] private AudioClip _death;




    private BirdMover _mover;
    public int _score;
    public int _scoreMaxInt;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;


    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    public void IncreaseScore()
    {
        _scoreSound.PlayOneShot(_scorePlus);
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetPlayer()
    {

        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetBird();
    }
    public void Die()
    {
        _scoreSound.PlayOneShot(_death);
        GameOver?.Invoke();

    }
}
