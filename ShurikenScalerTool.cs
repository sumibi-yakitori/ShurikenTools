using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SumibiYakitori.PlaTools {
	public class ShurikenScalerTool : Tool {
		public ShurikenScalerTool() : base() { 
			this.Text = "Scale";
			this.Filters.NeedSelection = true;
			this.Filters.NeedComponentType = typeof(ParticleSystem);
		} 

		public override void Run() {
		}
	}
}

