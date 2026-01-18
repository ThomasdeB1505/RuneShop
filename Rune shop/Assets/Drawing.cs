using System;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public bool circleDrawn;
    public Animator[] runeAnimations;

    private void Start()
    {
        ResetRune();
    }
    public void ResetRune()
    {
        for (int i = 0; i < runeAnimations.Length; i++)
        {
            runeAnimations[i].gameObject.SetActive(false);
        }
        circleDrawn = false;
    }
    public void TriggerAnimation(int _index)
    {
        if (_index == 0)
            circleDrawn = true;
        if(_index >= 1 && _index <= 3)
        {
            runeAnimations[1].gameObject.SetActive(false);
            runeAnimations[2].gameObject.SetActive(false);
            runeAnimations[3].gameObject.SetActive(false);
        }
        else if (_index >= 4 && _index <= 9)
        {
            runeAnimations[4].gameObject.SetActive(false);
            runeAnimations[5].gameObject.SetActive(false);
            runeAnimations[6].gameObject.SetActive(false);
            runeAnimations[7].gameObject.SetActive(false);
            runeAnimations[8].gameObject.SetActive(false);
            runeAnimations[9].gameObject.SetActive(false);
        }
        else if (_index >= 10 && _index <= 15)
        {
            runeAnimations[10].gameObject.SetActive(false);
            runeAnimations[11].gameObject.SetActive(false);
            runeAnimations[12].gameObject.SetActive(false);
            runeAnimations[13].gameObject.SetActive(false);
            runeAnimations[14].gameObject.SetActive(false);
            runeAnimations[15].gameObject.SetActive(false);
        }
        else if (_index >= 16 && _index <= 19)
        {
            runeAnimations[16].gameObject.SetActive(false);
            runeAnimations[17].gameObject.SetActive(false);
            runeAnimations[18].gameObject.SetActive(false);
            runeAnimations[19].gameObject.SetActive(false);
        }

        runeAnimations[_index].gameObject.SetActive(true);
        runeAnimations[_index].Play(0);
    }
}
