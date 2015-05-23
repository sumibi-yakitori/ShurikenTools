using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SumibiYakitori.PlaTools {
	public class CreateShurikenTool : Tool {
		public CreateShurikenTool() : base() { 
			this.Text = "Shuriken";
			this.Filters.NeedSelection = false;
		} 

		public override void Run() {
			Selection.activeGameObject = new GameObject("Particle System").AddComponent<ParticleSystem>().gameObject;
			Undo.RegisterCreatedObjectUndo(Selection.activeGameObject, this.GetType().Name);
		}
	}
}

