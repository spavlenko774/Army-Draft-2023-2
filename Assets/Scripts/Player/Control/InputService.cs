using UnityEngine;

public class InputService
{
    private Camera _camera;

    private Vector2 _movementInput;
    public Vector2 MovementInput
    {
        get
        {
            _movementInput.x = Input.GetAxisRaw("Horizontal");
            _movementInput.y = Input.GetAxisRaw("Vertical");
            return _movementInput;
        }
    }
    private Vector2 _mousePosition;
    public Vector2 MousePosition
    {
        get
        {
            _mousePosition = _camera.ScreenToWorldPoint(
                Input.mousePosition);
            return _mousePosition;
        }
    }

    public InputService(Camera camera) => _camera = camera;
}
