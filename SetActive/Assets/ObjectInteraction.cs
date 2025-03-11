using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject targetObject; // Ȱ��ȭ�� ������Ʈ
    public string nextSceneName; // ��ȯ�� �� �̸�
    private bool isPlayerNear = false; // �÷��̾ ��ó�� �ִ��� Ȯ��

    void Update()
    {
        // �÷��̾ ��ó�� �ְ�, E Ű�� ������ ����
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            targetObject.SetActive(true); // ������Ʈ Ȱ��ȭ
            Invoke("ChangeScene", 1f); // 1�� �� �� ��ȯ (������ ���� ������)
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName); // �� ��ȯ
    }

    // �÷��̾ ���� �ȿ� ������ ��
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾�� �浹�ߴ��� Ȯ��
        {
            isPlayerNear = true;
        }
    }

    // �÷��̾ ���� ������ ������ ��
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
}
