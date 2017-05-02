using UnityEngine;
using System.Collections;

public interface IRigidbody2DComponent : IComponent
{

    Rigidbody2D rigidbody2D { get; }
}
