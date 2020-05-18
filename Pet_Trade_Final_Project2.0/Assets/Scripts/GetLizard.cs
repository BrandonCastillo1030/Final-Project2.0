using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetLizard : MonoBehaviour
{
    //public static float money;
    

    private void Start()
    {
        //money = UnityEngine.Random.Range(1000, 2000);
        //Debug.Log(money);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("PetStoreLeo");
            //money = money - 40;
            //Debug.Log(money);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("BreederLeo");
            //money = money - 100;
            //Debug.Log(money);
        }
    }
}
