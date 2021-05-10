using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Utilities {
	public partial class GradientPanel : UserControl {
		public Color ColorTop { get; set; }
		public Color ColorBottom { get; set; }

		protected override void OnPaint(PaintEventArgs e) {
			var brush = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, 90F);
			Graphics g = e.Graphics;
			g.FillRectangle(brush, ClientRectangle);
			base.OnPaint(e);
		}
	}
}
