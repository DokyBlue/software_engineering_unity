using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SignUpButton : MonoBehaviour
{
    private Button signUpButton;
    public GameObject wrongText;
    private string username;
    private string password;

    //ִ��ע�Ṧ��
    private void OnSignUpButtonClick()
    {
        //TODO: ʵ��ע�Ṧ��
        username = GameObject.FindWithTag("username").GetComponent<TMP_InputField>().text;
        password = GameObject.FindWithTag("password").GetComponent<TMP_InputField>().text;
        if (username == "022020114" && password == "085518")
        {
            wrongText.SetActive(true);
            Debug.Log("ע��ʧ��!");
        }
        else
        {
            Debug.Log(username + password);
            Debug.Log("ע��ɹ�");
            wrongText.SetActive(false);
        }
    }

    void Start()
    {
        signUpButton = GetComponent<Button>();
        signUpButton.onClick.AddListener(OnSignUpButtonClick);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
