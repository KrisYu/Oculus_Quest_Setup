using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftHandController : MonoBehaviour, XRIDefaultInputActions.IXRILeftHandActions
{
    private XRIDefaultInputActions controls;

    private void OnEnable()
    {
        if (controls == null)
        {
            controls = new XRIDefaultInputActions();
            controls.XRILeftHand.SetCallbacks( this );
        }
        controls.XRILeftHand.Enable();
    }


    void XRIDefaultInputActions.IXRILeftHandActions.OnPrimaryButtonPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log(message: "[Left Controller]: Primary Button Press!");
        }
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnActivate(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnActivateValue(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnHapticDevice(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnMove(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnPosition(InputAction.CallbackContext context)
    {
        
    }


    void XRIDefaultInputActions.IXRILeftHandActions.OnRotateAnchor(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnRotation(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnSelect(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnSelectValue(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnTeleportModeActivate(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnTeleportModeCancel(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnTeleportSelect(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnTrackingState(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnTranslateAnchor(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnTurn(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnUIPress(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRILeftHandActions.OnUIPressValue(InputAction.CallbackContext context)
    {
        
    }


}
