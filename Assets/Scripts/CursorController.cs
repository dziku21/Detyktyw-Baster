using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CursorController : MonoBehaviour
{
    public Texture2D cursor;
    public Texture2D cursorClicked;

    private CursorSpec spec;
    private Camera mainCamera;

    private void Awake()
    {
        spec = new CursorSpec();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
        mainCamera = Camera.main;
;
    }
    private void Start()
    {
        spec.Mouse.Click.started += _ => StartedClick();
        spec.Mouse.Click.performed += _ => EndedClick();
    }
    private void OnEnable()
    {
        spec.Enable();
    }
    private void OnDisable()
    {
        spec.Disable();
    }

    private void StartedClick()
    {
        ChangeCursor(cursorClicked);
    }

    private void EndedClick()
    {
        ChangeCursor(cursor);
        DetectObject();
    }

    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(spec.Mouse.Position.ReadValue<Vector2>());
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if (hits2D.collider != null)
        {
            IClicked click = hits2D.collider.gameObject.GetComponent<IClicked>();
            if(click != null) click.OnClickAction();
            Debug.Log("You hits " + hits2D.collider.tag);
        }
    }
    private void ChangeCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }
    void Update()
    {
        
    }
}
