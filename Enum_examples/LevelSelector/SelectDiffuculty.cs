using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDiffuculty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,   //0
        Normal, //1
        Hard,   //2
        Expert  //3
    }

    public LevelSelector currentDifficulty;
    void Start()
    {
        switch (currentDifficulty)
        {
            case LevelSelector.Easy:
                break;

            case LevelSelector.Normal:
                break;

            case LevelSelector.Hard:
                break;

            case LevelSelector.Expert:
                break;
        }
    }

    
}
