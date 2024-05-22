using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using UnityEngine.EventSystems;

public class MoveSprite : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody m_Rigidbody;
    public LeanDragTranslate leanDragTranslate;
    private float offsetY = 2f;
    
    private void SwitchLean(bool state)
    {
        leanDragTranslate.enabled = state;
    }

    void OnMouseDown()
    {

        m_Rigidbody.GetComponent<Rigidbody>().isKinematic = true;
        SwitchLean(true);
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + offsetY, currentPosition.z);
        transform.position = newPosition;
    }

    void OnMouseUp()
    {
        m_Rigidbody.GetComponent<Rigidbody>().isKinematic = false;
        SwitchLean(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        m_Rigidbody.GetComponent<Rigidbody>().isKinematic = true;
        SwitchLean(true);
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + offsetY, currentPosition.z);
        transform.position = newPosition;
    }
    
        public void OnPointerUp(PointerEventData eventData)
    {
        m_Rigidbody.GetComponent<Rigidbody>().isKinematic = false;
        SwitchLean(false);
    }
}