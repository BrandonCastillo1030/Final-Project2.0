using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public Scene scene;
        
void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == "End Scene" && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync("Scenes/Menu");
        }
    }
}
