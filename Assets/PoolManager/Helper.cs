using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper
{
    public static void MoveX(Transform transform, float posEnd, float speed, bool peedBased = true, Action action = null)
    {
        transform.DOMoveX(posEnd, speed).SetSpeedBased(peedBased).SetEase(Ease.Linear).OnComplete(()=>action?.Invoke());
    }
    public static void MoveY(Transform transform, float posEnd, float speed, bool peedBased = true, Action action = null)
    {
        transform.DOMoveY(posEnd, speed).SetSpeedBased(peedBased).SetEase(Ease.Linear).OnComplete(() => action?.Invoke());
    }
    public static void MoveZ(Transform transform, float posEnd, float speed, bool peedBased = true, Action action = null)
    {
        transform.DOMoveZ(posEnd, speed).SetSpeedBased(peedBased).SetEase(Ease.Linear).OnComplete(() => action?.Invoke());
    }
    public static void Move(Transform transform, Vector3 posEnd, float speed, bool peedBased = true, Action action = null)
    {
        transform.DOMove(posEnd, speed).SetSpeedBased(peedBased).SetEase(Ease.Linear).OnComplete(() => action?.Invoke());
    }
    public static void LocalRotate(Transform transform, Quaternion quaternion, float speed, bool peedBased = true, Action action = null)
    {
        transform.DOLocalRotateQuaternion(quaternion, speed).SetSpeedBased(peedBased).SetEase(Ease.Linear).OnComplete(() => action?.Invoke());
    }
}
