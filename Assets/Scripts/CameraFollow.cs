using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // �÷��̾� ĳ������ Transform�� �����ϱ� ���� ����
    public float smoothSpeed = 0.125f; // ī�޶��� �ε巯�� �̵��� �����ϴ� ����
    public Vector3 offset; // ī�޶�� �÷��̾� ���� �Ÿ��� �����ϴ� ����

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }
    }
}
