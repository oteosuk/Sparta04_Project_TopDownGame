using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartSceneController : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public Button joinButton;

    private void Start()
    {
        // 버튼 클릭 이벤트에 함수를 연결
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    private void OnJoinButtonClick()
    {
        string playerName = nameInputField.text;

        // 이름의 길이가 2에서 10 사이인지 확인
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            // 이름이 조건을 만족하면 다음 씬으로 이동
            PlayerPrefs.SetString("PlayerName", playerName); // 플레이어 이름을 저장
            SceneManager.LoadScene("NextScene"); // 다음 씬으로 이동
        }
        else
        {
            Debug.Log("이름은 2에서 10글자 사이어야 합니다.");
        }
    }
}
