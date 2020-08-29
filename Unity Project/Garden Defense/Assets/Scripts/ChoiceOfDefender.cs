using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceOfDefender : MonoBehaviour
{
    [SerializeField] private GameObject defender;
    [SerializeField] private int cost;

    private void OnMouseDown()
    {
        DefenderCreator.Instance.Defender = defender;
    }
}
