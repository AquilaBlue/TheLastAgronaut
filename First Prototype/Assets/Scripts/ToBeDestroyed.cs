﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBeDestroyed : MonoBehaviour
{
    public List<GameObject> toBeDestroyed = new List<GameObject>();
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add(GameObject obj)
    {
        toBeDestroyed.Add(obj);
    }
}