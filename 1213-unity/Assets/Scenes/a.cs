using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour {
#region
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 1.5f;
    [Header("血量"), Range(100, 1000)]
    public float hp = 100;
    
    private Animator ani;
    private Rigidbody2D r2d;
    private AudioSource aud;

    [Header("子彈物件")]
    public GameObject bullte;
    [Header("發射音效")]
    public AudioClip soundFire ;

    public Transform point;
    public float speedBullet=1000;

#endregion

private void Start(){
    ani = GetComponent<Animator>();
    r2d = GetComponent<Rigidbody2D>();
    aud = GetComponent<AudioSource>();
}
private void FixedUpdate() {
    Move();
}
private void Update() {
    Fire();
}
private void Move(){
    float h = Input.GetAxisRaw("Horizontal");
    r2d.AddForce(new Vector2(speed*h,0));
    if (h!=0) transform.localScale= new Vector3(h,1,1);
}
private void Fire(){
    if(Input.GetKeyDown(KeyCode.Mouse0))
    {
        aud.PlayOneShot(soundFire);
        GameObject temp = Instantiate(bullte,point.position,Quaternion.identity);
        temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(speedBullet*transform.localScale.x,0));
    }
}
}
