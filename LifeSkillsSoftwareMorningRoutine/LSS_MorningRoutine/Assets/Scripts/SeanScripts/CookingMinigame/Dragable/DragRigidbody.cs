using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Drag a rigidbody with the mouse using a spring joint.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class DragRigidbody : MonoBehaviour
{
	public PlayerControls eggControls;


	

	public float force = 600;
	public float damping = 6;

	Transform jointTrans;
	float dragDepth;

	private void Awake()
	{
	
	}

	private void Update()
	{
		if (jointTrans != null)
		{
			HandleInput();
		}
	}
	public void HandleInputBegin()
	{
		Debug.Log("FIRED FROM HIB");
		var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Interactive"))
			{
				dragDepth = CameraPlane.CameraToPointDepth(Camera.main, hit.point);
				jointTrans = AttachJoint(hit.rigidbody, hit.point);
				EggMicroGameController.instance.enableHitImage();
			}
		}
	}

	public void HandleInput()
	{
		if (jointTrans == null)
			return;
		var worldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
		jointTrans.position = CameraPlane.ScreenToWorldPlanePoint(Camera.main, dragDepth, Mouse.current.position.ReadValue());
	}

	public void HandleInputEnd()
	{
		if (jointTrans != null)
		{
			Destroy(jointTrans.gameObject);
		}
	}

	Transform AttachJoint(Rigidbody rb, Vector3 attachmentPosition)
	{
		GameObject go = new GameObject("Attachment Point");
		go.hideFlags = HideFlags.HideInHierarchy;
		go.transform.position = attachmentPosition;

		var newRb = go.AddComponent<Rigidbody>();
		newRb.isKinematic = true;

		var joint = go.AddComponent<ConfigurableJoint>();
		joint.connectedBody = rb;
		joint.configuredInWorldSpace = true;
		joint.xDrive = NewJointDrive(force, damping);
		joint.yDrive = NewJointDrive(force, damping);
		joint.zDrive = NewJointDrive(force, damping);
		joint.slerpDrive = NewJointDrive(force, damping);
		joint.rotationDriveMode = RotationDriveMode.Slerp;

		return go.transform;
	}

	private JointDrive NewJointDrive(float force, float damping)
	{
		JointDrive drive = new JointDrive();
		drive.mode = JointDriveMode.Position;
		drive.positionSpring = force;
		drive.positionDamper = damping;
		drive.maximumForce = Mathf.Infinity;
		return drive;
	}

	public void CrackEgg()
	{
		if (jointTrans != null)
		{
			if(GetComponent<Egg>().GetIsCracked())
			{
				GetComponent<Egg>().SpawnYolk();
			}
		}
	}


}