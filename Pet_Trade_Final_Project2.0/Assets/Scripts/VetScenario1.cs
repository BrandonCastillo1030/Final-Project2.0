using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VetScenario1 : MonoBehaviour
{

    public Animator animator;

    //public static float money2 = GetLizard.money;

    

   // public Text MoneyText;

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "GetBetterVet")
        {
           
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                FadertoLevel(1);
                
            }
        }
        
       // DisplayScores();

    }

    //void DisplayScores()
    //{
  //      MoneyText = "Money: " + GetLizard.money2.ToString("000");
    //}

       
        public void FadertoLevel (int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Leo");
    }
}
