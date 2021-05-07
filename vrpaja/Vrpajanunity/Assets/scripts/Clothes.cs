using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Clothes : XRSocketInteractor
{
    public string targetTag = string.Empty;
    public GameObject lasit;
    

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
        return interactable.CompareTag(targetTag);
    }

    public  void test()
    {
        //päässä, muokkaa lasien väriä

        if (lasit != null)
        {
            lasit.SetActive(false);
            
            
            //mainCamera.color juttuja VAIHDA
        }
            
    }

    public void test2()
    {
        //Lasit pois laita laisen väri takaisin normaaliin
        if(lasit != null)
        {
            lasit.SetActive(true);

            //mainCamera normaaliksi
        }
       
    }
}
