﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Game State Data")]
public class GameStateData : ScriptableObject
{
    public delegate void OnGameStateChangedEvent(GameState gameState);
    public event OnGameStateChangedEvent onGameStateChanged;
    public enum GameState { Unknown, Menu, Tutorial, Live, Finished }

    [ReadOnly, SerializeField]
    private GameState currentState;
    public GameState CurrentState
    {
        get { return currentState; }
        set
        {
            if (currentState != value)
            {
                currentState = value;
                if (onGameStateChanged != null)
                {
                    onGameStateChanged(currentState);
                }
            }
        }
    }
}