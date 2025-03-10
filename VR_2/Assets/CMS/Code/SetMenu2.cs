using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SetMenu2 : MonoBehaviour
{
    //public ActionBasedSnapTurnProvider snapturn;
    //public ActionBasedContinuousTurnProvider continiousTurn;

    public XRSimpleInteractable[] Fwood;
    public XRSimpleInteractable[] Ffire;
   

    // SetTypeFromIndex �޼��带 ����Ͽ� �ε����� ���� ������Ʈ ����
    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(false);
           
        }
        else if (index == 1)
        {
            SetFwoodObjectsEnabled(true);
            SetFfireObjectsEnabled(false);
          
        }
        else if (index == 2)
        {
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(true);
         
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

    // Ffire �迭�� ��� ������Ʈ�� enabled ���� �����ϴ� �޼���
    private void SetFfireObjectsEnabled(bool enabled)
    {
        foreach (XRSimpleInteractable ffireObject in Ffire)
        {
            ffireObject.enabled = enabled;
        }
    }

  
}
