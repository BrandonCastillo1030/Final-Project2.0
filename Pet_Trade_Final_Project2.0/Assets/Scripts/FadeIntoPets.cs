using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIntoPets : MonoBehaviour
{
    public Animator animator;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadertoLevel(int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }
}
