using Svelto.ECS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleNode : NodeWithID {

    public ISpeedComponent speedComponent;
    public IPositonComponent positionComponent;
    public IRigidbody2DComponent rigidbody2DComponent;
}
