using UnityEngine;
using UnityEngine.UI;

public class RCoinData : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text = PlayerPrefs.GetInt("SaleCard_0001").ToString();
    }
}
