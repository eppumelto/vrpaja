using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Clothes : XRSocketInteractor
{
    public string targetTag = string.Empty;

    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);
    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
            return base.CanSelect(interactable) && MatchUsingTag(interactable);
    }


    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        //Tarkistaa onko peli objecti suojalasit jos on katsoo onko Socket active jos on niin poistaa lasit
        if (gameObject.CompareTag("lasit") && socketActive == true)
        {
            Destroy(gameObject);
        }
        return interactable.CompareTag(targetTag);
    }
  
}
