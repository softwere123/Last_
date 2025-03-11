using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

// ���� ���� ����� �����ϴ� ��ũ��Ʈ ��3���� �޴��� �����Ͽ� Set meu3�� ���   
public class SetMenu3 : MonoBehaviour
{
    //������ ��ӹڽ��� �����ϰ�    ��Ƽ�������� �־ ����Ϸ��� ������    ����Ƽ6.0������ �̹� ����Ǿ��־ ������� ����
    //public ActionBasedSnapTurnProvider snapturn;
    //public ActionBasedContinuousTurnProvider continiousTurn;

    // Fwood, Ffire, Ftelport �迭�� ���� ���ͷ����̺� ������� ����� �迭�� ������ ������
    public XRSimpleInteractable[] Fwood;
    public XRSimpleInteractable[] Ffire;
    //public XRRayInteractor[] Ftelport;  //����Ʈ ����� ����Ҷ� ����� �迭 ��� ��������

    // SetTypeFromIndex �޼��带 ����Ͽ� �ε����� ���� ������Ʈ ����
    public void SetTypeFromIndex(int index) //dropdown���� ������ �ε����� �޾ƿͼ� �ش� �ε����� �´� ������Ʈ�� Ȱ��ȭ
    {
        //�⺻���´� 0,  �ϰ�� ��� ������Ʈ ��Ȱ��ȭ , ��ӹڽ��� 1.2.3 ��츦 ���ð����ϴ�
        if (index == 0)
        {
            //�迭�� �ִ� ��ȣ�ۿ� ����� ��Ȱ��ȭ
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(false);
            //SetFtelportObjectsEnabled(false);
        }
        else if (index == 1)
        {
            //�迭�� �ִ� ��ȣ�ۿ� fwood�� ��ȣ�ۿ븸 ����� Ȱ��ȭ
            SetFwoodObjectsEnabled(true);
            SetFfireObjectsEnabled(false);
           // SetFtelportObjectsEnabled(false);
        }
        else if (index == 2)
        {
            //�迭�� �ִ� ��ȣ�ۿ� ffire�� ��ȣ�ۿ븸 ����� Ȱ��ȭ
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(true);
           // SetFtelportObjectsEnabled(false);
        }
        else if (index == 3)
        {
            //�迭�� �ִ� ��ȣ�ۿ� ftelport�� ��ȣ�ۿ븸 ����� Ȱ��ȭ
            SetFwoodObjectsEnabled(false);
            SetFfireObjectsEnabled(false);
            //SetFtelportObjectsEnabled(true);
        }
    }

    // Fwood �迭�� ��� ������Ʈ�� enabled ���� �����ϴ� �޼���(�������ظ���)
    //�Ƹ� ��Ҿִ� ��Ȱ��ȭ�Ǿ��ִµ� �� �޼��带 ���� Ȱ��ȭ�Ǵ°����� ���� �װ��� 
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

    //// Ftelport �迭�� ��� ������Ʈ�� enabled ���� �����ϴ� �޼���
    //private void SetFtelportObjectsEnabled(bool enabled)
    //{
    //    foreach (XRRayInteractor ftelportObject in Ftelport)
    //    {
    //        ftelportObject.enabled = enabled;
    //    }
    //}
}
