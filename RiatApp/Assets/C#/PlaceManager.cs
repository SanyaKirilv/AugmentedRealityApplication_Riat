using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceManager : MonoBehaviour {
    public PlaceIndicator placeIndicator;
    public GameObject objectToPlace;

    public void Place() {
        Instantiate(objectToPlace, placeIndicator.transform.position, 
            placeIndicator.transform.rotation);
    }
}
