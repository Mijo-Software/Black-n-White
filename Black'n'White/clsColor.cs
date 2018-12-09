using System;
using System.Drawing;

namespace VS2008StripRenderingLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class ClsColor
	{
		/// <summary>
		/// 
		/// </summary>
		public static Color clrHorBG_GrayBlue = Color.FromArgb(alpha: 255, red: 233, green: 236, blue: 250);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrHorBG_White = Color.FromArgb(alpha: 255, red: 244, green: 247, blue: 252);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSubmenuBG = Color.FromArgb(alpha: 255, red: 240, green: 240, blue: 240);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrImageMarginBlue = Color.FromArgb(alpha: 255, red: 212, green: 216, blue: 230);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrImageMarginWhite = Color.FromArgb(alpha: 255, red: 244, green: 247, blue: 252);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrImageMarginLine = Color.FromArgb(alpha: 255, red: 160, green: 160, blue: 180);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSelectedBG_Blue = Color.FromArgb(alpha: 255, red: 186, green: 228, blue: 246);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSelectedBG_Header_Blue = Color.FromArgb(alpha: 255, red: 146, green: 202, blue: 230);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSelectedBG_White = Color.FromArgb(alpha: 255, red: 241, green: 248, blue: 251);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSelectedBG_Border = Color.FromArgb(alpha: 255, red: 150, green: 217, blue: 249);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSelectedBG_Drop_Blue = Color.FromArgb(alpha: 255, red: 139, green: 195, blue: 225);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrSelectedBG_Drop_Border = Color.FromArgb(alpha: 255, red: 48, green: 127, blue: 177);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrMenuBorder = Color.FromArgb(alpha: 255, red: 160, green: 160, blue: 160);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrCheckBG = Color.FromArgb(alpha: 255, red: 206, green: 237, blue: 250);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrVerBG_GrayBlue = Color.FromArgb(alpha: 255, red: 196, green: 203, blue: 219);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrVerBG_White = Color.FromArgb(alpha: 255, red: 250, green: 250, blue: 253);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrVerBG_Shadow = Color.FromArgb(alpha: 255, red: 181, green: 190, blue: 206);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrToolstripBtnGrad_Blue = Color.FromArgb(alpha: 255, red: 129, green: 192, blue: 224);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrToolstripBtnGrad_White = Color.FromArgb(alpha: 255, red: 237, green: 248, blue: 253);

		/// <summary>
		/// 
		/// </summary>
		public static Color clrToolstripBtn_Border = Color.FromArgb(alpha: 255, red: 41, green: 153, blue: 255);
		
		/// <summary>
		/// 
		/// </summary>
		public static Color clrToolstripBtnGrad_Blue_Pressed = Color.FromArgb(alpha: 255, red: 124, green: 177, blue: 204);
		
		/// <summary>
		/// 
		/// </summary>
		public static Color clrToolstripBtnGrad_White_Pressed = Color.FromArgb(alpha: 255, red: 228, green: 245, blue: 252);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="m_diameter"></param>
		/// <param name="color"></param>
		public static void DrawRoundedRectangle(Graphics g, int x, int y,
				int width, int height, int m_diameter, Color color)
		{
			using (Pen pen = new Pen(color: color))
			{
				//Dim g As Graphics
				RectangleF BaseRect = new RectangleF(x: x, y: y, width: width, height: height);
				RectangleF ArcRect = new RectangleF(location: BaseRect.Location, size: new SizeF(width: m_diameter, height: m_diameter));
				//top left Arc
				g.DrawArc(pen: pen, rect: ArcRect, startAngle: 180, sweepAngle: 90);
				g.DrawLine(pen: pen, x1: x + Convert.ToInt32(value: m_diameter / 2), y1: y, x2: x + width - Convert.ToInt32(value: m_diameter / 2), y2: y);

				// top right arc
				ArcRect.X = BaseRect.Right - m_diameter;
				g.DrawArc(pen: pen, rect: ArcRect, startAngle: 270, sweepAngle: 90);
				g.DrawLine(pen: pen, x1: x + width, y1: y + Convert.ToInt32(value: m_diameter / 2), x2: x + width, y2: y + height - Convert.ToInt32(value: m_diameter / 2));

				// bottom right arc
				ArcRect.Y = BaseRect.Bottom - m_diameter;
				g.DrawArc(pen: pen, rect: ArcRect, startAngle: 0, sweepAngle: 90);
				g.DrawLine(pen: pen, x1: x + Convert.ToInt32(value: m_diameter / 2), y1: y + height, x2: x + width - Convert.ToInt32(value: m_diameter / 2), y2: y + height);

				// bottom left arc
				ArcRect.X = BaseRect.Left;
				g.DrawArc(pen: pen, rect: ArcRect, startAngle: 90, sweepAngle: 90);
				g.DrawLine(pen: pen, x1: x, y1: y + Convert.ToInt32(value: m_diameter / 2), x2: x, y2: y + height - Convert.ToInt32(value: m_diameter / 2));
			}
		}
	}
}
