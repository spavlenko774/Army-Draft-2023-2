using UnityEngine;

public class Fighter : MonoBehaviour
{
    [SerializeField]
    private Transform _firePoint;
    [SerializeField]
    private Bullet _moneyBullet;
    [SerializeField]
    private Bullet _certificateBullet;
    [SerializeField]
    private float _bulletForce = 20f;

    private Inventory _inventory;

    private void Start()
    {
        _inventory = new Inventory();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (_inventory.AmountOfMoney > 0)
            {
                Shoot(_moneyBullet);
                _inventory.DecrementMoney();
                Debug.Log($"Now you have {_inventory.AmountOfMoney} money");
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_inventory.AmountOfCertificates > 0)
            {
                Shoot(_certificateBullet);
                _inventory.DecrementCertificates();
                Debug.Log($"Now you have {_inventory.AmountOfCertificates} certificates");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Money _))
        {
            _inventory.IncrementMoney();
            Destroy(collision.gameObject);
            Debug.Log($"Now you have {_inventory.AmountOfMoney} money");
        }
        else if (collision.TryGetComponent(out Certificate _))
        {
            _inventory.IncrementCertificates();
            Destroy(collision.gameObject);
            Debug.Log($"Now you have {_inventory.AmountOfCertificates} certificates");
        }
    }

    private void Shoot(Bullet bulletPrefab)
    {
        Bullet bullet = Instantiate(bulletPrefab, _firePoint.position, _firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>()
            .AddForce(_firePoint.up * _bulletForce, ForceMode2D.Impulse);
    }
}
