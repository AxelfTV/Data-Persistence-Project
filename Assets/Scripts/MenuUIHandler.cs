using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public Text Username_field;
    public string userID;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        userID = Username_field.text.ToString();


    }
    public void StartGame()
    {
        userID = Username_field.text.ToString();
        DataManager.Instance.name = userID;
        SceneManager.LoadScene(1);
    }
}
