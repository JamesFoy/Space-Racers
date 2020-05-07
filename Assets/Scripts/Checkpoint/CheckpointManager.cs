﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    List<Checkpoint> checkpoints = new List<Checkpoint>();
    public static CheckpointManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    /// <summary>
    /// Adds the checkpoint instance provided to the list of checkpoints in CheckpointManager
    /// </summary>
    /// <param name="checkpoint"></param>
    public void AddThisCheckpointToCheckpointList(Checkpoint checkpoint)
    {
        if (!checkpoints.Contains(checkpoint))
        {
            checkpoints.Add(checkpoint);
        }
    }
    /// <summary>
    /// Removes the given GameObject from all checkpoints
    /// </summary>
    /// <param name="a"></param>
    public void RemoveThisGameObjectFromAllCheckpoints(GameObject a)
    {
        Checkpoint c = FindCheckpointThatContainsThisGameObject(a);
        if (c != null)
        {
            c.RemoveGameObjectFromThisCheckpoint(a);
        }
    }
    public Checkpoint FindCheckpointThatContainsThisGameObject(GameObject a)
    {
        foreach (Checkpoint c in checkpoints)
        {
            if (c.CurrentCars.Contains(a))
            {
                return c;
            }
        }
        return null;
    }
}