using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorAnimation : MonoBehaviour
{
    public string nameAniOpen, nameAniClose;

    private Animator doorAnimator;
    private bool isOpen = true;

    private void Start()
    {
        if (doorAnimator == null)
        {
            doorAnimator = GetComponent<Animator>();
        }
    }

    public void OnDoorSelect(SelectEnterEventArgs args)
    {
        if (isOpen)
        {
            doorAnimator.Play(nameAniOpen);
        }
        else
        {
            doorAnimator.Play(nameAniClose);
        }
        isOpen = !isOpen;
    }
}
