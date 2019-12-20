using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Rules;
    public void Begin()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("ProjectM");
    }
    public void Close()
    {
        Application.Quit();
    }
    public void Settings()
    {
        Menu.SetActive(false);
        Rules.SetActive(true);
    }
    public void gotomenu()
    {
        Menu.SetActive(true);
        Rules.SetActive(false);
    }
    public void Exittomenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
