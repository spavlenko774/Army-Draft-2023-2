using UnityEngine;

public class Inventory
{
    public int AmountOfMoney { get; private set; }
    public int AmountOfCertificates { get; private set; }

    public Inventory()
    {
        AmountOfMoney = 0;
        AmountOfCertificates = 0;
    }

    public void IncrementMoney()
    {
        AmountOfMoney++;
    }

    public void DecrementMoney()
    {
        if (AmountOfMoney > 0)
        {
            AmountOfMoney--;
        }
    }

    public void IncrementCertificates()
    {
        AmountOfCertificates++;
    }

    public void DecrementCertificates()
    {
        if (AmountOfCertificates > 0)
        {
            AmountOfCertificates--;
        }
    }
}
