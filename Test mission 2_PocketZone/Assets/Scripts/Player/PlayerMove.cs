using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;

    [SerializeField] private Transform _playerTransform;
    [SerializeField, Min(0)] private float _speed = 1.0f;

    private void Start()
    {
        if (_joystick == null)
        {
            Debug.LogAssertion("Joystick component was null");
        }
    }

    private Vector2 _input;
    private Vector2 _target;

    private void Update()
    {
        _input = _joystick.Direction;

        _target = new Vector2(_input.x + _playerTransform.position.x, _input.y + _playerTransform.position.y);

        _playerTransform.position = Vector2.MoveTowards(_playerTransform.position, _target, _speed * Time.deltaTime * _input.magnitude);
    }
}
