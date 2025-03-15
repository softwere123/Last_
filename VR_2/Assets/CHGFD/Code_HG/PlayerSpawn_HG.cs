using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawn : MonoBehaviour
{
    private void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        Vector3 spawnPos = SpawnManager.Instance.GetSpawnPosition(currentScene);
        transform.position = spawnPos; // ���� �´� ��ġ���� ����
    }
}
