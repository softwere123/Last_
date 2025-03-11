using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public string nextSceneName; // �Ѿ �� �̸�

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾�� ����� ���� ����
        {
            SceneManager.LoadScene(nextSceneName); // ���� ������ ��ȯ
        }
    }
}