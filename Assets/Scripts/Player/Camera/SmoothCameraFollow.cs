using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    private Vector3 _offset;
    [SerializeField]
    private float _damping;
    private Vector2 _currentVelocity = Vector2.zero;

    private void FixedUpdate()
    {
        Vector2 movePosition = 
            _target.position + _offset;
        transform.position = Vector2.SmoothDamp(
            transform.position, movePosition, ref _currentVelocity, _damping * Time.fixedDeltaTime);
    }
}
