using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    public string nextSceneName; // ��ȯ�� ���� �̸�

    private void OnDisable()
    {
        SceneManager.LoadScene(nextSceneName); // ������Ʈ�� ��Ȱ��ȭ�Ǹ� �� ��ȯ
    }
}