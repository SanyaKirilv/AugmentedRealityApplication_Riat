using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SaleCard : MonoBehaviour
{
    [Header("UI Objects")]
    [SerializeField] private Image image;
    [SerializeField] private Text nameUI;
    [SerializeField] private Text workTimeUI;
    [SerializeField] private Button buttonUI;
    [Header("Data")]
    [SerializeField] private Sprite sprite;
    [SerializeField] [TextArea] private string name;
    [SerializeField] [TextArea] private string work;
    [SerializeField] private int cost;
    private bool state = true;

    private void Awake()
    {
        image.sprite = sprite;
        nameUI.text = name;
        workTimeUI.text = "Время действия:\n" + work;
    }

    private void Update() 
    {
        if(state)
            buttonUI.interactable = PlayerPrefs.GetInt("SaleCard_0001") >= cost;
    }

    public void BuySale()
    {
        PlayerPrefs.SetInt("SaleCard_0001", PlayerPrefs.GetInt("SaleCard_0001") - cost);
        state = false;
        buttonUI.interactable = false;
    }
}
