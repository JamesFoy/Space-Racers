﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public void OnTrackButton()
    {
        SceneManager.LoadScene("TrackTestScene");
    }

    public void OnArenaButton()
    {
        SceneManager.LoadScene("ArenaTestScene");
    }

    public void OnTutorialButton()
    {
        SceneManager.LoadScene("TutorialTrackScene");
    }
}
