using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private HitEffect _hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HitEffect effect = Instantiate(_hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.1f);
        Destroy(gameObject);
    }
}
