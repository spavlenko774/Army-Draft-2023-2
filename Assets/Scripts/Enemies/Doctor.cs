using UnityEngine;

public class Doctor : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth;

    private Enemy _enemy;

    private void Start()
    {
        _enemy = new Enemy(_maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Certificate _))
        {
            _enemy.OnHit();
            Destroy(collision.gameObject);
        }
    }
}
