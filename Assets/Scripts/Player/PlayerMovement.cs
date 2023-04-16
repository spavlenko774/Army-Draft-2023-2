using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 5f;

    private Rigidbody2D _rigidbody2D;
    private Camera _camera;

    private InputService _input;

    private void Start()
    {
        _camera = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _input = new InputService(_camera);
    }

    private void FixedUpdate()
    {
        MovePlayer();
        //RotatePlayer();
    }

    private void MovePlayer()
    {
        _rigidbody2D.MovePosition(
            _rigidbody2D.position + _input.MovementInput * _playerSpeed * Time.fixedDeltaTime);
    }

    private void RotatePlayer()
    {
        var lookDirection = _input.MousePosition - _rigidbody2D.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x)
            * Mathf.Rad2Deg - 90f;
        _rigidbody2D.rotation = angle;
    }
}
