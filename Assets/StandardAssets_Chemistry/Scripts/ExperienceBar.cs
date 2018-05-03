﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour {

    public Slider experienceBar;
    public float progress;

	// Use this for initialization
	void Start () {
        CalculateExperience();
	}
	
    public void CalculateExperience()
    {
        int totalMolecules = 2 * MoleculeManager.instance.standard_strategy.Count;
        int playersMolecules = GameManager.namedMolecules + GameManager.constructedMolecules;
        progress = Mathf.Clamp01 ((float)playersMolecules / (float)totalMolecules);
        experienceBar.value = progress;
    }
}