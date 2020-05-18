using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReptileChoices : MonoBehaviour
{
    public GameObject[] reptiles;
    public GameObject Leo;
    public GameObject Rico;
    public GameObject Neo;
    public GameObject Ted;
    public GameObject Ned;
    public GameObject Shred;
    public GameObject storytext;
    public StoryText st;

    void Start()
    {
        reptiles = new GameObject[4];
        Leo = GameObject.Find("/Canvas/Bearded DragonPT"); // Petco
        Rico = GameObject.Find("/Canvas/IguanaPT"); // Petco
        Neo = GameObject.Find("/Canvas/Leopard GeckoPT"); // Petco
        Ted = GameObject.Find("/Canvas/Bearded DragonB");  // Bred
        Ned = GameObject.Find("/Canvas/IguanaB"); // Bred
        Shred = GameObject.Find("/Canvas/Leopard GeckoB");// Bred
        storytext = GameObject.Find("StoryText");
        st = storytext.GetComponent<StoryText>();

    }

    // Update is called once per frame
    void Update()
    {
        // Pet Lizards = 1-3
        // Private Lizards = 4-6

        while (reptiles.Length < 4)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                reptiles[reptiles.Length] = Leo;
                st.money -= 30;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                reptiles[reptiles.Length] = Rico;
                st.money -= 35;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                reptiles[reptiles.Length] = Neo;
                st.money -= 20;

            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                reptiles[reptiles.Length] = Ted;
                st.money -= 100;

            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                reptiles[reptiles.Length] = Ned;
                st.money -= 250;

            }

            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                reptiles[reptiles.Length] = Shred;
                st.money -= 40;

            }
        }
    }
}
