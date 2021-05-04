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
//<<<<<<< HEAD
        if (gameObject.CompareTag("cube") && socketActive == false)
//=======
        //Tarkistaa onko peli objecti suojalasit jos on katsoo onko Socket active jos on niin poistaa lasit
        if (gameObject.CompareTag("Lasit") && socketActive == true)
//>>>>>>> 983ffbb771216c7ee89bbbb01a62ab2cfc3f8d9a
        {
            Destroy(interactable);
        }
        return interactable.CompareTag(targetTag);
    }
  
}
