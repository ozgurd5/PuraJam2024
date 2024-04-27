using Mirror;
using UnityEngine;

namespace OzgurTest.Scripts
{
    public class TestPlayerController : NetworkBehaviour
    {
        public float speed = 5f;

        public override void OnStartClient()
        {
            base.OnStartClient();

            if (!NetworkServer.activeHost)
            {
                SceneLog.Instance.Log("Disabling TestPlayerController.");
                enabled = false;
            }
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * (speed * Time.deltaTime));
            if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * (speed * Time.deltaTime));
            if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * (speed * Time.deltaTime));
            if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * (speed * Time.deltaTime));
        }
    }
}
