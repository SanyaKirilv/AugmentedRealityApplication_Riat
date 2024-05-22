using UnityEngine;
using UnityEngine.UI;

public class GoodsCard : MonoBehaviour
{
    [Header("UI Objects")]
    [SerializeField] private Image image;
    [SerializeField] private Text nameUI;
    [SerializeField] private Text priceUI;
    [Header("Data")]
    [SerializeField] private string sceneName;
    [SerializeField] private Sprite sprite;
    [SerializeField] private string name;
    [SerializeField] private string price;

    private void Awake()
    {
        image.sprite = sprite;
        nameUI.text = name;
        priceUI.text = price;
    }

    public void OpenScene() => UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
}
