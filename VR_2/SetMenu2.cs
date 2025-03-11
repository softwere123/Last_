using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SetMenu : MonoBehaviour
{
    //public ActionBasedSnapTurnProvider snapturn;
    //public ActionBasedContinuousTurnProvider continiousTurn;

    public XRSimpleInteractable[] Fwood;
    public XRSimpleInteractable[] Ffire;
    public XRRayInteractor[] Ftelport;

    // SetTypeFromIndex 메서드를 사용하여 인덱스에 따라 오브젝트 변경
    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(false);
            SetFtelportObjectsEnabled(false);
        }
        else if (index == 1)
        {
            SetFwoodObjectsEnabled(true);
            SetFfireObjectsEnabled(false);
            SetFtelportObjectsEnabled(false);
        }
        else if (index == 2)
        {
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(true);
            SetFtelportObjectsEnabled(false);
        }
        else if (index == 3)
        {
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(false);
            SetFtelportObjectsEnabled(true);
        }
    }

    // Fwood 배열의 모든 오브젝트의 enabled 값을 설정하는 메서드
    private void SetFwoodObjectsEnabled(bool enabled)
    {
        foreach (XRSimpleInteractable fwoodObject in Fwood)
        {
            fwoodObject.enabled = enabled;
        }
    }

    // Ffire 배열의 모든 오브젝트의 enabled 값을 설정하는 메서드
    private void SetFfireObjectsEnabled(bool enabled)
    {
        foreach (XRSimpleInteractable ffireObject in Ffire)
        {
            ffireObject.enabled = enabled;
        }
    }

    // Ftelport 배열의 모든 오브젝트의 enabled 값을 설정하는 메서드
    private void SetFtelportObjectsEnabled(bool enabled)
    {
        foreach (XRRayInteractor ftelportObject in Ftelport)
        {
            ftelportObject.enabled = enabled;
        }
    }
}
