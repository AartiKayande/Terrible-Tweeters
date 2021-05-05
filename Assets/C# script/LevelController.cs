using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    Monster[] _monsters;
    [SerializeField] string _nextLevelName;

    public Text TextLevel;
   // [SerializeField] public GameObject Text;
   // [SerializeField] public GameObject Image;
    void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();
    }



    void Update()
    {
        if (MonstersAreAllDead())


            GoToNextLevel();
    }
     

    void GoToNextLevel()
    { 
        Debug.Log("Go to level" + _nextLevelName);
          
            SceneManager.LoadScene(_nextLevelName);
        
    }
     bool MonstersAreAllDead()
    {
        foreach(var monster in _monsters)
        {
            if (monster.gameObject.activeSelf)
                return false;
            // Text.SetActive(true);
           // Image.SetActive(true);
            
        }
        return true;
    }
}
