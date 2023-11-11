using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToSignUpButton : MonoBehaviour
{
    private Button goToSignUpButton;

    //Ç°Íù×¢²á½çÃæ
    private void LoadScene()
    {
        SceneManager.GetSceneManager().LoadScene("SignUp");
    }

    // Start is called before the first frame update
    void Start()
    {
        goToSignUpButton = GetComponent<Button>();
        goToSignUpButton.onClick.AddListener(LoadScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
