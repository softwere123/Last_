using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName; // �̵��� �� �̸�
    public Vector3 spawnPosition; // ������ ��ġ
    private bool isPlayerInTrigger = false; // �÷��̾ ���� �ȿ� �ִ��� Ȯ��

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInTrigger = true; // �÷��̾ ���� �ȿ� �������� ����
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInTrigger = false; // ���� ������ ������ false�� ����
        }
    }

    private void Update()
    {
        // �÷��̾ Ʈ���� �ȿ� �ְ�, E Ű�� ������ �� �̵�
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            SpawnManager.Instance.SetSpawnPosition(nextSceneName, spawnPosition); // ���� �� ���� ��ġ ����
            SceneManager.LoadScene(nextSceneName); // �� ����
        }
    }
}
