using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class GUIScript : MonoBehaviour
{
    public RectTransform GUI;

    DateTime RevertToCenterAt = DateTime.MinValue;

    public void MoveToLeft()
    {
        GUI.DOAnchorMin(new Vector2(0, 0.25f), 1);
        GUI.DOAnchorMax(new Vector2(0.5f, 0.75f), 1);

        RevertToCenterAt = DateTime.Now + new TimeSpan(0, 0, 3);
    }

    public void MoveToRight()
    {
        GUI.DOAnchorMin(new Vector2(0.5f, 0.25f), 1);
        GUI.DOAnchorMax(new Vector2(1.0f, 0.75f), 1);

        RevertToCenterAt = DateTime.Now + new TimeSpan(0, 0, 3);
    }

    public void Update()
    {
        if(RevertToCenterAt != DateTime.MinValue && RevertToCenterAt < DateTime.Now)
        {
            RevertToCenterAt = DateTime.MinValue;

            GUI.DOAnchorMin(new Vector2(0.25f, 0.25f), 1);
            GUI.DOAnchorMax(new Vector2(0.75f, 0.75f), 1);
        }
    }
}
