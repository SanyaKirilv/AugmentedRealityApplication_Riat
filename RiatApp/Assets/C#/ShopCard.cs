using UnityEngine;
using UnityEngine.UI;

public class ShopCard : MonoBehaviour
{
    [Header("UI Objects")]
    [SerializeField] private Image image;
    [SerializeField] private Text locationUI;
    [SerializeField] private Text workTimeUI;
    [Header("Data")]
    [SerializeField] private string link;
    [SerializeField] private Sprite sprite;
    [SerializeField] [TextArea] private string location;
    [SerializeField] [TextArea] private string work;

    private void Awake()
    {
        image.sprite = sprite;
        locationUI.text = location;
        workTimeUI.text = "Время работы:\n" + work;
    }

    public void OpenURL() => Application.OpenURL(link);
}
