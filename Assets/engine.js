#pragma strict

public var rotateSpeed: float = 1;

function Update () {
    if (Input.GetKey("w"))
        transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);

    if (Input.GetKey("s"))
        transform.Rotate(Vector3.back, rotateSpeed * Time.deltaTime);

    if (Input.GetKey("d"))
        transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);

    if (Input.GetKey("a"))
        transform.Rotate(Vector3.left, rotateSpeed * Time.deltaTime);

}
