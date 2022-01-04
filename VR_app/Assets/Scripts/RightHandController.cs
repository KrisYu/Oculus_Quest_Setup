using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RightHandController : MonoBehaviour, XRIDefaultInputActions.IXRIRightHandActions
{
    private XRIDefaultInputActions controls;

    private void OnEnable()
    {
        if (controls == null)
        {
            controls = new XRIDefaultInputActions();
            controls.XRIRightHand.SetCallbacks( this );
        }
        controls.XRIRightHand.Enable();
    }


    void XRIDefaultInputActions.IXRIRightHandActions.OnPrimaryButtonPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log(message: "[Right Controller]: Primary Button Press!");
        }
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnActivate(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnActivateValue(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnHapticDevice(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnMove(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnPosition(InputAction.CallbackContext context)
    {
        
    }


    void XRIDefaultInputActions.IXRIRightHandActions.OnRotateAnchor(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnRotation(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnSelect(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnSelectValue(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnTeleportModeActivate(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnTeleportModeCancel(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnTeleportSelect(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnTrackingState(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnTranslateAnchor(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnTurn(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnUIPress(InputAction.CallbackContext context)
    {
        
    }

    void XRIDefaultInputActions.IXRIRightHandActions.OnUIPressValue(InputAction.CallbackContext context)
    {
        
    }


}
