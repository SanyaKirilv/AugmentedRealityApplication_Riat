using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("SaleCard_0001"))
        {
            PlayerPrefs.SetInt("SaleCard_0001", 100);
        }
    }
}
