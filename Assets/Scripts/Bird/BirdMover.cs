using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce = 10;
    [SerializeField] private AudioSource _birdSound;
    [SerializeField] private AudioClip _soundJump;
    [SerializeField] private Button _buttonFly;


    private Rigidbody2D _rigidbody2D;



    private void Start()
    {

        _rigidbody2D = GetComponent<Rigidbody2D>();



        ResetBird();
    }


    public void OnClickFly()
    {
        _birdSound.PlayOneShot(_soundJump);
        _rigidbody2D.velocity = new Vector2(_speed, 0);
        _rigidbody2D.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);

    }



    public void ResetBird()
    {
        transform.position = _startPosition;
        transform.rotation = Quaternion.Euler(0,0,0);
        _rigidbody2D.velocity = Vector2.zero;
    }

}
