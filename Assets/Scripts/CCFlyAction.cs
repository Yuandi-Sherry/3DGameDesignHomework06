using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneBasicCodes;
using ActionBasicCodes;
public class CCFlyAction : SSAction {
		public float g;
		public float xSpeed;
		public float ySpeed;
		public float timeCount;
		public Rigidbody rigidbody;

		/*public override void Start () {
			g = 5f;
			timeCount = 0;
			enable = true;
			destroy = false;
			xSpeed = gameobject.GetComponent<DiskData>().xSpeed;  
			ySpeed = gameobject.GetComponent<DiskData>().ySpeed; 

		}
		public override void Update () {
			if(gameobject.activeSelf) {//debug : 本身就已经是激活状态？
				timeCount += Time.deltaTime;
				//Debug.Log("why you update?");
				gameobject.transform.Translate(new Vector3(xSpeed*Time.deltaTime, (ySpeed - timeCount*g)*Time.deltaTime, 0)); //y为+向上，为-向下
				
				//飞碟坠毁
				if(gameobject.transform.position.y < -10) {
					this.destroy = true;
					this.enable = false;
					this.callback.SSActionEvent(this);
				}
			}
		}
		public static CCFlyAction getSSAction() {
			CCFlyAction action = ScriptableObject.CreateInstance<CCFlyAction>();
			return action;
		}*/

		/**************************************
		 * new codes *
		 **************************************/

		 public void FixedUpdate() {
		 	
		 }


	}