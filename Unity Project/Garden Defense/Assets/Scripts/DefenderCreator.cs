using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderCreator : MonoBehaviour
{
    private static DefenderCreator _instance = null;
    public static DefenderCreator Instance
    {
        get
        {
            if (_instance == null)
            {
                // TODO: - Realizacian Chot Durs chi galis
                _instance = FindObjectOfType<DefenderCreator>();
            }

            return _instance;
        }
    }

    private GameObject _defenfer;
    public GameObject Defender
    {
        set
        {
            if (value == _defenfer)
            {
                _defenfer = null;
            }
            else
            {
                _defenfer = value;
            }
        }
    }

    private void OnMouseDown()
    {
        if (_defenfer)
        {
            Instantiate(_defenfer, SnapToGrid(GetSquareClicked()), Quaternion.identity);
        }
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPosition)
    {
        float newX = Mathf.RoundToInt(rawWorldPosition.x);
        float newY = Mathf.RoundToInt(rawWorldPosition.y);

        return new Vector2(newX, newY);
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);

        return worldPosition;
    }
}
