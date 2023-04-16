using UnityEngine;
using UnityEngine.Events;

public class BonusTaker : MonoBehaviour
{
    public event UnityAction<float> TakingBonus;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out TimeBonus bonus))
        {
            TakingBonus?.Invoke(bonus.Time);
        }
        Destroy(collision.gameObject);
    }
}
