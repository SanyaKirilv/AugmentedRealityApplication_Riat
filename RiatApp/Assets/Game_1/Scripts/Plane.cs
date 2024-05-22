using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public int k;
    public GameObject anim;

    private void OnTriggerEnter(Collider Chh)
    {
        if(Chh.gameObject.tag == "Chh")
            k++;
        if (k == 10)
        {
            anim.SetActive(true);
            PlayerPrefs.SetInt("SaleCard_0001", PlayerPrefs.GetInt("SaleCard_0001") + 100);
        }
    }
}
