using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordText : MonoBehaviour
{
    private TMP_InputField inputField;
    private string password = "";

    // 给密码做加密措施
    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.text = "Input Password...";
        inputField.contentType = TMP_InputField.ContentType.Password;
        inputField.onSelect.AddListener(OnInputFieldSelect);
        inputField.onDeselect.AddListener(OnInputFieldDeselect);
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    private void OnInputFieldSelect(string value)
    {
        if (inputField.text == "Input Password...")
        {
            inputField.text = "";
        }
    }

    private void OnInputFieldDeselect(string value)
    {
        if (inputField.text == "")
        {
            inputField.text = "Input Password...";
        }
    }

    private void OnInputFieldValueChanged(string value)
    {
        password = value;
    }

    public string GetPassword()
    {
        return password;
    }
}