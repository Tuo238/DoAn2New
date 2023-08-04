using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public Transform[] checkpoints; // Mảng lưu trữ các checkpoint
    private Vector3 spawnPoint; // Vị trí xuất hiện

    void Start()
    {
        // Đặt vị trí xuất hiện ban đầu
        spawnPoint = gameObject.transform.position;
    }

    void Update()
    {
        // Kiểm tra nếu rơi xuống khỏi map
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra xem người chơi đã tiếp xúc với checkpoint chưa
        for (int i = 0; i < checkpoints.Length; i++)
        {
            if (other.gameObject.transform == checkpoints[i])
            {
                // Cập nhật vị trí xuất hiện khi tiếp xúc với checkpoint
                spawnPoint = checkpoints[i].position;
                Destroy(checkpoints[i].gameObject); // Hủy checkpoint
                break;
            }
        }
    }
}