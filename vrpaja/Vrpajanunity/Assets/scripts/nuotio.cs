using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class nuotio : XRSocketInteractor
{
    public string targetTag = string.Empty;
    private Component testi;
    

    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);
    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        if(interactable.tag == "wood")
        {
            //otan interactablen ja poistan grab koodin
            Destroy(interactable.GetComponent<XRGrabInteractable>());
            Destroy(interactable.GetComponent<Rigidbody>());
            
        }
        return base.CanSelect(interactable) && MatchUsingTag(interactable);
    }


    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }

    

}
