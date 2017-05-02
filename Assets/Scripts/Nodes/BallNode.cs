using UnityEngine;
using System.Collections;
using Svelto.ECS;

public class BallNode : NodeWithID
{
    public ISpeedComponent SpeedComponent;
    public IRigidbody2DComponent Rigidbody2DComponent;
    public IPositonComponent PositonComponent;
    public IDirectionComponent DirectionComponent;

}
