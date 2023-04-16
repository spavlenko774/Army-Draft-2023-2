using UnityEngine.Events;

public class Enemy
{
    private int _maxHealth;
    private int _health;

    public event UnityAction Deactivation;

    public Enemy(int maxHealth)
    {
        _maxHealth = maxHealth;
        _health = maxHealth;
    }

    public void OnHit()
    {
        _health--;
        if (_health == 0)
        {
            Deactivation?.Invoke();
        }
    }
}
