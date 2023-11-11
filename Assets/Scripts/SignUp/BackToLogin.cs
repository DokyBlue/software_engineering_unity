using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToLogin : MonoBehaviour
{
    private Button backButton;

    //·µ»ØµÇÂ¼½çÃæ
    private void LoadScene()
    {
        SceneManager.GetSceneManager().LoadScene("Login");
    }

    // Start is called before the first frame update
    void Start()
    {
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(LoadScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
