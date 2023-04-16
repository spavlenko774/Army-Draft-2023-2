using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private bool _hasAKey = false;
    private bool _canOpen = false;
    private Door _door;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && _canOpen && _door)
        {
            if (_hasAKey == true)
            {
                Debug.Log("Door is opened but you dont have a key more");
                _door.transform.Rotate(0, 0, 90f);
                _hasAKey = false;
            }
            else
            {
                Debug.Log("You dont have a key to open this door");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Key _))
        {
            _hasAKey = true;
            Destroy(collision.gameObject);
            Debug.Log("Now you have a key!");
        }
        else if (collision.TryGetComponent(out Door door))
        {
            _canOpen = true;
            _door = door;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Door _))
        {
            _canOpen = false;
            _door = null;
        }
    }
}
