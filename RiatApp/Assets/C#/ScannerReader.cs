using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerReader : MonoBehaviour
{
    public void SetValue(string name) => PlayerPrefs.SetInt(name, 1);
}
