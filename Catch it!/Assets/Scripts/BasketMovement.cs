using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BasketMovement : MonoBehaviour
{
    public float swipeSpeed;
    Vector3 lastMousePosition;
    private void OnMouseDown()
    {
        lastMousePosition = Input.mousePosition;
    }
    private void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePosition;
        Vector3 pos = transform.position;
        pos.x += delta.x * swipeSpeed;
        transform.position = pos;
        lastMousePosition = Input.mousePosition;
    }

}
