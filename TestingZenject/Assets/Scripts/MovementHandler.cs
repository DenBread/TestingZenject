using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementHandler : IDisposable
{
    private IInput _input;

    public MovementHandler(IInput input)
    {
        _input = input;

        Debug.Log("Wow");
        
        _input.ClickDown += OnClickDown;
        _input.ClickUp += OnClickUp;
        _input.Drag += OnDrag;
        
        
    }

    public void OnClickDown(Vector3 position)
    {
        // обработка нажатия
    }

    private void OnClickUp(Vector3 position)
    {
        // обработка нажатий
    }

    private void OnDrag(Vector3 position)
    {
        // обработка нажатий
    }
    
    public void Dispose()
    {
        _input.ClickDown -= OnClickDown;
        _input.ClickUp -= OnClickUp;
        _input.Drag -= OnDrag;

    }
    
    
}
