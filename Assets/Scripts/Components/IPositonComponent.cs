using UnityEngine;
using System.Collections;

public interface IPositonComponent : IComponent
{

    Vector3 position { get; }
}
