using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // 플레이어 캐릭터의 Transform을 저장하기 위한 변수
    public float smoothSpeed = 0.125f; // 카메라의 부드러운 이동을 제어하는 변수
    public Vector3 offset; // 카메라와 플레이어 간의 거리를 조절하는 변수

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
