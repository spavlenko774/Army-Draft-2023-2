using UnityEngine;

public class Military : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth;

    private Enemy _enemy;

    private void Start()
    {
        _enemy = new Enemy(_maxHealth);
        _enemy.Deactivation += () =>
        {

        };
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Money _))
        {
            _enemy.OnHit();
            Destroy(collision.gameObject);
        }
    }
}
