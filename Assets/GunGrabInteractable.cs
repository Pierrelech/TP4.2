using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GunGrabInteractable : XRGrabInteractable
{
    public Transform rightHandAttachPoint;  // Point d'attache pour la main droite
    public Transform leftHandAttachPoint;   // Point d'attache pour la main gauche

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        // V�rifie si c'est la main gauche ou droite qui a attrap� l'objet
        XRBaseInteractor interactor = args.interactor;
        if (interactor.CompareTag("LeftHand"))  // Si l'interactor a le tag "LeftHand"
        {
            attachTransform = leftHandAttachPoint;  // Utilise le point d'attache de la main gauche
        }
        else
        {
            attachTransform = rightHandAttachPoint;  // Utilise le point d'attache de la main droite
        }

        // Appelle la m�thode de base pour g�rer l'attachement
        base.OnSelectEntering(args);
    }
}
