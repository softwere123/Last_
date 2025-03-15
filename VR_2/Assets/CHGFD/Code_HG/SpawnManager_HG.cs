using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;
    private Vector3 defaultSpawn = new Vector3(-14, 2, -13); // �⺻ ���� ��ġ

    // ���� ���� ��ġ ����
    private Dictionary<string, Vector3> spawnPositions = new Dictionary<string, Vector3>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ���� ���� ��ġ ����
    public void SetSpawnPosition(string sceneName, Vector3 position)
    {
        if (spawnPositions.ContainsKey(sceneName))
        {
            spawnPositions[sceneName] = position;
        }
        else
        {
            spawnPositions.Add(sceneName, position);
        }
    }

    // ���� ���� ���� ��ġ ��������
    public Vector3 GetSpawnPosition(string sceneName)
    {
        if (spawnPositions.ContainsKey(sceneName))
        {
            return spawnPositions[sceneName];
        }
        return defaultSpawn; // �⺻ ��ġ ��ȯ
    }
}
