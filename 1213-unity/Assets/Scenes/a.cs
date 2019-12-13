using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour {
#region
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 1.5f;
    [Header("血量"), Range(100, 1000)]
    public float hp = 100;
    public Animator ani;
    public Rigidbody2D r2D;

#endregion

}
