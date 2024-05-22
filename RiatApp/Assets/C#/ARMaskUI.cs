using UnityEngine;
using UnityEngine.UI;

public class ARMaskUI : MonoBehaviour
{
    public string name;
    [SerializeField] private Button button;
    [SerializeField] private Image image;

    [SerializeField] private Sprite sprite;
    public bool mode;

    private void Awake()
    {
        image.sprite = sprite;
    }

    private void Update()
    {
        button.interactable = PlayerPrefs.GetInt(name) == 1 && !mode;
    }

    public void OpenScene() => UnityEngine.SceneManagement.SceneManager.LoadScene(name);
}
