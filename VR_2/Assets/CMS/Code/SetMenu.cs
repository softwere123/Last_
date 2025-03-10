using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SetMenu: MonoBehaviour
{
    //public ActionBasedSnapTurnProvider snapturn;
    //public ActionBasedContinuousTurnProvider continiousTurn;

   
    public XRSimpleInteractable[] Fwood;
    public XRSimpleInteractable[] Ffire;
    public XRRayInteractor[] Ftelport;

    //public GameObject dropdownObject;// XRSimpleInteractable ������Ʈ�� �迭

    // SetTypeFromIndex �޼��带 ����Ͽ� �ε����� ���� ������Ʈ ����
    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            
           
            SetFwoodObjectsEnabled(false);
        }
        else if (index == 1)
        {
        
            SetFwoodObjectsEnabled(true);
        }
        else if (index == 2)
        {

            SetFwoodObjectsEnabled(false);
        }
        else if (index == 3)
        {
            

            SetFwoodObjectsEnabled(false);
        }
    }

    // Fwood �迭�� ��� ������Ʈ�� enabled ���� �����ϴ� �޼���
    private void SetFwoodObjectsEnabled(bool enabled)
    {
        foreach (XRSimpleInteractable fwoodObject in Fwood)
        {
            fwoodObject.enabled = enabled;
            
        }
    }
}