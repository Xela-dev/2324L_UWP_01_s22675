﻿using System;

public class Player : Character
{
    public static int CountKills => countkills;
    public static Player Instance => instance;
    
    private static int countkills;
    
    private static Player instance;
    
    public void AddKill()
    {
        countkills++;
        UI.Instance.ChangeKillsText(countkills);
    }
    
    private void Awake()
    {
        base.Awake();
        GameManager.InstanceInputManager.OnMove += Move;
        GameManager.InstanceInputManager.OnShoot += Shoot;
        instance = this;
    }

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        UI.Instance.ChangeHealthText($"{Health}/{MaxHealth}");
    }

    private void OnDestroy()
    {
        GameManager.InstanceInputManager.OnMove -= Move;
        GameManager.InstanceInputManager.OnShoot += Shoot;
    }
}