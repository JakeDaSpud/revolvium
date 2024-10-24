using GD;
using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO - better manage tiles, so that many types can be made


/*
 *  ROTATION TILE BEHAVIOUR - STARTED BY AND WRITTEN BY RUBY
 */

public class RotationTileBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameEvent enableRotation;
    [SerializeField]
    private GameEvent disableRotation;

    [SerializeField]
    private Transform parentTransform;

    [SerializeField]
    private Transform transform;

    public void Start()
    {

    }

    public bool isCorrectlyOrientated()
    {
        return transform.up.y == 1;
    }


    [ContextMenu("Disable Rotation")]
    public void evokeDisableRotation()
    {
        disableRotation?.Raise();
    }
    [ContextMenu("Enable Rotation")]
    public void evokeEnableRotation()
    {
        if(isCorrectlyOrientated())
            enableRotation?.Raise();

    }
}
