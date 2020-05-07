﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairBehaviour : MonoBehaviour
{
    CarInfo carInfo;

    // Start is called before the first frame update
    private void OnEnable()
    {
        carInfo = GetComponentInParent<CarInfo>();
    }

    public void RepairDamage(float repairAmount)
    {
        carInfo.carStats.health -= repairAmount;
    }
}