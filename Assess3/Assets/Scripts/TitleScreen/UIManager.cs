using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Managers;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 1)
        {
            Managers = GameObject.FindWithTag("QuitButton");
            Button btn = Managers.GetComponent<Button>();

            btn.onClick.AddListener(QuitGame);
        }

    }
}