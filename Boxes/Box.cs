using System;

namespace Boxes
{
	public class Box {
		private int width;
		private int height;
		private int depth;

		public Box() {
			this.width = 0;
			this.height = 0;
			this.depth = 0;
		}

		public Box(int w, int h, int d) {
			this.width = w;
			this.height = h;
			this.depth = d;
		}

		public int Volume() {
			return width * height * depth;
		}

		public override string ToString() {
			return String.Format("Kasse [højde = {0}, bredde = {1}, dybde = {2}]", height, width, depth);
		}
	}
}

