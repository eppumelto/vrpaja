using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public enum handType
{
    left,
    right
}

public class kasiAnim : MonoBehaviour
{

    public handType handType;
    public float thumbSpeed = 0.2f;

    private Animator animator;
    private InputDevice inputDevice;
    private float indexvalue;
    private float ThumbValue;
    private float kolmeSormeaValue;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animateHand();
        Debug.Log(kolmeSormeaValue);
    }


    InputDevice GetInputDevice()
    {
        InputDeviceCharacteristics controllerCharacteristic = InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.Controller;

        if(handType == handType.left)
        {
            controllerCharacteristic = controllerCharacteristic | InputDeviceCharacteristics.Left;

        }
        else
        {
            controllerCharacteristic = controllerCharacteristic | InputDeviceCharacteristics.Right;
        }

        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristic, inputDevices);

        return inputDevices[0];
    }

  void animateHand()
    {

        
        inputDevice.TryGetFeatureValue(CommonUsages.trigger, out indexvalue);
        inputDevice.TryGetFeatureValue(CommonUsages.grip, out kolmeSormeaValue);

        inputDevice.TryGetFeatureValue(CommonUsages.primaryTouch, out bool primaryTouched);
        inputDevice.TryGetFeatureValue(CommonUsages.secondaryTouch, out bool secondaryTouched);

        if(primaryTouched || secondaryTouched)
        {
            ThumbValue += thumbSpeed;
        }
        else
        {
            ThumbValue -= thumbSpeed;
        }

        ThumbValue = Mathf.Clamp(ThumbValue, 0, 1);


       

        animator.SetFloat("index", indexvalue);
        animator.SetFloat("3Sormea", kolmeSormeaValue);
        animator.SetFloat("Thumb", ThumbValue);
    }
}
