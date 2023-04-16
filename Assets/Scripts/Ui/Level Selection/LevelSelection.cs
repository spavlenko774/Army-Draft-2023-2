using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    [SerializeField]
    private Button[] _buttons;

    private void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < _buttons.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                _buttons[i].interactable = false;
            }
        }
    }
}
