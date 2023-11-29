using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    public InputField nameInputField;
    public Button joinButton;

    private void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� �Լ��� ����
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    private void OnJoinButtonClick()
    {
        string playerName = nameInputField.text;

        // �̸��� ���̰� 2���� 10 �������� Ȯ��
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            // �̸��� ������ �����ϸ� ���� ������ �̵�
            PlayerPrefs.SetString("PlayerName", playerName); // �÷��̾� �̸��� ����
            SceneManager.LoadScene("NextScene"); // ���� ������ �̵�
        }
        else
        {
            Debug.Log("�̸��� 2���� 10���� ���̾�� �մϴ�.");
        }
    }
}
