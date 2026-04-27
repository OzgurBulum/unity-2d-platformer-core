using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public static CheckpointManager Instance;
    public Transform spawnPoint;
    private Transform activeCheckpoint;

    void Awake()
    {
        Instance = this;
        activeCheckpoint = spawnPoint;
    }

    public void SetCheckpoint(Transform newCheckpoint)
    {
        activeCheckpoint = newCheckpoint;
        Debug.Log("Checkpoint aktif: " + newCheckpoint.name);
    }

    public Vector3 GetSpawnPosition()
    {
        return activeCheckpoint.position;
    }
}