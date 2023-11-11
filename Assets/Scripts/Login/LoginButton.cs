using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginButton : MonoBehaviour
{
    private string username;
    private string password;
    public GameObject failedText;
    private Button loginButton;

    //ִ�е�¼Ч��
    void Start()
    {
        loginButton = GetComponent<Button>();
        if(failedText == null)
        {
            Debug.Log("wrong");
        }
        loginButton.onClick.AddListener(OnLoginButtonClick);
    }

    private void OnLoginButtonClick()
    {
        username = GameObject.FindWithTag("username").GetComponent<TMP_InputField>().text;
        password = GameObject.FindWithTag("password").GetComponent<PasswordText>().GetPassword();
        if(username == "022020114" && password == "085518")
        {
            Debug.Log("��¼�ɹ�");
        } else
        {
            failedText.SetActive(true);
            Debug.Log(username + password);
            Debug.Log("��¼ʧ��");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
