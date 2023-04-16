using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    private Timer _timer;
    [SerializeField]
    private Image _fillBar;
    [SerializeField]
    private float _maxTime;
    [SerializeField]
    private BonusTaker _bonusTaker;

    private void Start()
    {
        _timer = new Timer(_maxTime);
        _bonusTaker.TakingBonus += OnTakingBonus;
    }

    private void Update()
    {
        _fillBar.fillAmount = _timer.TimeLeft / _maxTime;
    }

    private void OnTakingBonus(float time)
    {
        _timer.AddTime(time);
    }
}
